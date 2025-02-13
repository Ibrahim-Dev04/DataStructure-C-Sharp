//using System;
//using System.Collections.Generic;

//class Program
//{
//    static Stack<string> undoStack = new Stack<string>();
//    static Stack<string> redoStack = new Stack<string>();

//    static void Main()
//    {
//        DoAction("Action 1");
//        DoAction("Action 2");
//        DoAction("Action 3");
//        Undo();
//        Undo();
//        Redo();
//        Redo();
//        Console.ReadKey();
//    }

//    static void DoAction(string action)
//    {
//        undoStack.Push(action);
//        redoStack.Clear(); // Clear redo on new action
//        Console.WriteLine($"Did: {action}");
//    }

//    static void Undo()
//    {
//        if (undoStack.Count > 0)
//        {
//            string action = undoStack.Pop();
//            redoStack.Push(action);
//            Console.WriteLine($"Undid: {action}");
//        }
//    }

//    static void Redo()
//    {
//        if (redoStack.Count > 0)
//        {
//            string action = redoStack.Pop();
//            undoStack.Push(action);
//            Console.WriteLine($"Redid: {action}");

           
//        }
//    }
//}