namespace AvaloniaEdit.Text
{
    public abstract class TextRun
    {
        public abstract StringRange StringRange { get; }

        public abstract int Length { get; }

        public abstract TextStyle Properties { get; }
    }
}