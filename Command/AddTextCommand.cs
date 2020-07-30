namespace DesignPatterns
{
    public class AddTextCommand : Command
    {
        private readonly string _textToAdd;

        public AddTextCommand(string textToAdd)
        {
            _textToAdd = textToAdd;
        }

        protected override void ExecuteInternal(TextEditor textEditor)
        {
            textEditor.Document += _textToAdd;
        }

        /// <inheritdoc />
        protected override void UndoInternal(TextEditor textEditor)
        {
            throw new System.NotImplementedException();
        }
    }
}