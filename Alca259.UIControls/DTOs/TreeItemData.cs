using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alca259.UIControls.DTOs
{
    public sealed class TreeItemData
    {
        internal enum Constants
        {
            File = 0,
            FolderClosed = 1,
            FolderOpened = 2
        }

        private const char SplitChar = '.';

        public string Key { get; set; }

        internal static TreeNode[] GetNodes(List<TreeItemData> items)
        {
            var allKeys = items
                .Select(s => s.Key)
                .Where(w => !string.IsNullOrEmpty(w))
                .Distinct()
                .OrderBy(o => o)
                .ToArray();

            var parentKeys = allKeys
                .Where(s => s.Split(SplitChar, StringSplitOptions.RemoveEmptyEntries).Length > 0)
                .Select(s => s.Split(SplitChar, StringSplitOptions.RemoveEmptyEntries)[0])
                .Distinct()
                .ToArray();

            var result = new List<TreeNode>();

            for (int keyIndex = 0; keyIndex < parentKeys.Length; keyIndex++)
            {
                string parentKey = parentKeys[keyIndex];
                int processIndex = 1;
                var node = new TreeNode(parentKey, (int)Constants.File, (int)Constants.File);
                int childCount = ProcessKey(parentKey, allKeys, processIndex, node);

                if (childCount > 0)
                    node.ImageIndex = node.SelectedImageIndex = (int)Constants.FolderClosed;

                result.Add(node);
            }

            return result.ToArray();
        }

        internal static int ProcessKey(string key, string[] allKeys, int processIndex, TreeNode node)
        {
            var subKeys = allKeys
                .Where(w => w.StartsWith(key + SplitChar, StringComparison.InvariantCultureIgnoreCase))
                .Where(s => s.Split(SplitChar, StringSplitOptions.RemoveEmptyEntries).Length > processIndex)
                .Select(s => GetSubKey(s, processIndex))
                .Distinct()
                .ToArray();

            for (int keyIndex = 0; keyIndex < subKeys.Length; keyIndex++)
            {
                var subKey = subKeys[keyIndex];
                var nodeName = subKey.Split(SplitChar, StringSplitOptions.RemoveEmptyEntries)[processIndex];
                var subNode = new TreeNode(nodeName, (int)Constants.File, (int)Constants.File);
                int childCount = ProcessKey(subKey, allKeys, processIndex + 1, subNode);

                if (childCount > 0)
                    subNode.ImageIndex = subNode.SelectedImageIndex = (int)Constants.FolderClosed;

                node.Nodes.Add(subNode);
            }

            return subKeys.Length;
        }

        internal static string GetSubKey(string key, int processIndex)
        {
            var splitted = key.Split(SplitChar, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var subKey = new StringBuilder();
            for (int i = 0; i <= processIndex; i++)
            {
                subKey.Append(splitted[i]);
                if (i < processIndex) subKey.Append(SplitChar);
            }
            return subKey.ToString();
        }
    }
}
