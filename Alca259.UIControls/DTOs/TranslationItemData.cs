using System.Collections.Generic;

namespace Alca259.UIControls.DTOs
{
    public sealed class TranslationItemData
    {
        public string Key { get; set; }
        public List<TranslationItemElementData> Elements { get; set; }
    }
}
