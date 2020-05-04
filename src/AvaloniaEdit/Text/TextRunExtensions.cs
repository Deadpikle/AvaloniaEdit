using Avalonia.Media.TextFormatting;
using Avalonia.Utility;
using System;

namespace AvaloniaEdit.Text
{
    internal static class TextRunExtensions
    {
        internal static StringRange GetStringRange(this TextRun textRun)
        {
            switch (textRun)
            {
                case TextCharacters _:
                    return new StringRange(textRun.Text.ToString(), 0, textRun.Text.Length);// textRun.StringRange;
                default:
                    return StringRange.Empty;
            }
        }
    }
}