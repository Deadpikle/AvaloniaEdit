using Avalonia.Media.TextFormatting;

namespace AvaloniaEdit.Text
{
    public abstract class TextSource : ITextSource
    {
        public abstract Avalonia.Media.TextFormatting.TextRun GetTextRun(int characterIndex);
    }
}