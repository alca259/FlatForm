namespace Alca259.UIControls.DTOs
{
    public sealed class TranslationItemElementData
    {
        public TranslationItemElementData()
        {

        }

        public TranslationItemElementData(string languageKey, string value, bool isApproved)
        {
            LanguageKey = languageKey;
            Value = value;
            IsApproved = isApproved;
        }

        public string LanguageKey { get; set; }
        public string Value { get; set; }
        public bool IsApproved { get; set; }
    }
}
