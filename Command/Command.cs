namespace DesignPatterns
{
    public abstract class Command
    {
        protected abstract void ExecuteInternal(TextEditor textEditor);
        protected abstract void UndoInternal(TextEditor textEditor);

        public void Execute(TextEditor textEditor)
        {
            ExecuteInternal(textEditor);
            
            SaveState(textEditor);
        }

        private void SaveState(TextEditor textEditor)
        {
            textEditor.HistoricalStates.Add(textEditor.Document);
        }
    }
}