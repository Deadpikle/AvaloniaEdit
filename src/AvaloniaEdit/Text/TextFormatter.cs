namespace AvaloniaEdit.Text
{
    public class TextFormatter
    {
        public TextLine FormatLine(TextSource textSource, int firstCharIndex, double paragraphWidth, TextParagraphProperties paragraphProperties)
        {
            var a = Avalonia.Media.TextFormatting.TextFormatter.Current;
            a.FormatLine(textSource, firstCharIndex, paragraphWidth, paragraphProperties);

            return TextLineImpl.Create(paragraphProperties, firstCharIndex, (int)paragraphWidth, textSource);
        }
    }
}