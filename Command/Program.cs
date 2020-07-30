using System;

namespace DesignPatterns
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var textEditor = new TextEditor();

            var addText1 = new AddTextCommand("Zaczynam pisać książkę. ");
            addText1.Execute(textEditor);
            Console.WriteLine("stan po addText1: " + textEditor.Document);
            
            var addText2 = new AddTextCommand("To drugie zdanie ");
            addText2.Execute(textEditor);
            Console.WriteLine("stan po addText2: " + textEditor.Document);


            var capitalize1Command = new CapitalizeCommand(3, 5);
            capitalize1Command.Execute(textEditor);
            Console.WriteLine("stan po capitalize: " + textEditor.Document);

            textEditor.Undo();
            Console.WriteLine("stan po undo: " + textEditor.Document);

            textEditor.Undo();
            Console.WriteLine("stan po undo drugim: " + textEditor.Document);

        }
    }

    public class TextEditor
    {
        public string Document { get; set; }
        public List<string> HistoricalStates = new List<string>();

        public void Undo()
        {
            string lastHistoricalState = HistoricalStates[^2];
            
            HistoricalStates.RemoveAt(HistoricalStates.Count-1); // nie pozwala na Redo()

            Document = lastHistoricalState;
        }
    }
}