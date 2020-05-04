using Avalonia.Media.TextFormatting;

namespace AvaloniaEdit.Text
{
    public class TextEndOfParagraph : TextEndOfLine
    {
        public TextEndOfParagraph(int length) : base(length)
        {
        }

        public TextEndOfParagraph(int length, TextStyle textRunProperties)
            : base(length, textRunProperties)
        {
        }
    }
}