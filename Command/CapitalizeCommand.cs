namespace DesignPatterns
{
    using System.Text;
    using System.Threading.Channels;

    internal class CapitalizeCommand : Command
    {
        private readonly int _startIndex;
        private readonly int _length;

        public CapitalizeCommand(int startIndex, int length)
        {
            _startIndex = startIndex;
            _length = length;
        }

        protected override void ExecuteInternal(TextEditor textEditor)
        {
            string document = textEditor.Document;
            string capitalizedFragment = document.ToUpper().Substring(_startIndex, _length);
            
            StringBuilder builder = new StringBuilder();

            builder.Append(document.Substring(0, _startIndex));
            builder.Append(capitalizedFragment);
            builder.Append(document.Substring(_startIndex + _length));

            textEditor.Document = builder.ToString();
        }

        /// <inheritdoc />
        protected override void UndoInternal(TextEditor textEditor)
        {
            
        }
    }
}