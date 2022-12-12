using System;
using System.Diagnostics;
using System.ComponentModel;

namespace TaskManager
{
    public static class TaskManager
    {
        public static void ShowAllProcesses()
        {
            Console.WriteLine("Список процессов");
            Process[] localAll = Process.GetProcesses();
            // List<List<string>> table = new List<List<string>>();
            foreach (var proc in localAll)
            {
                try
                {
                    // List<string> procInfo = new List<string>();
                    Console.WriteLine($"( ) - {proc.ProcessName}\n    |- Выделенная память: {proc.PagedMemorySize64 / (1024 * 1024)}MB\n    |- Время начала выполнения: {proc.StartTime}");
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    // List<string> procInfo = new List<string>();
                    Console.WriteLine($"( ) - {proc.ProcessName}\n    |- Выделенная память: {proc.PagedMemorySize64 / (1024 * 1024)}MB\n    |- Время начала выполнения: Отказано в доступе");
                }

            }
        }
        public static void Main()
        {
            ShowAllProcesses();
        }
    }
}