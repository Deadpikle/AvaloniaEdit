using Avalonia.Media.TextFormatting;

namespace AvaloniaEdit.Text
{
    public class TextFormatter
    {
        public TextLine FormatLine(ITextSource textSource, int firstCharIndex, double paragraphWidth, TextParagraphProperties paragraphProperties)
        {
            var a = Avalonia.Media.TextFormatting.TextFormatter.Current;
            return a.FormatLine(textSource, firstCharIndex, paragraphWidth, paragraphProperties);

            //return TextLineImpl.Create(paragraphProperties, firstCharIndex, (int)paragraphWidth, textSource);
        }
    }
}