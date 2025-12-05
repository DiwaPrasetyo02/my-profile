using System;
using System.Collections.Generic;

public class Taskitem
{
    public int Id { get; set; }
    public string Description { get; set; } = "";
    public bool IsCompleted { get; set; }
    public void MarkComplete() => IsCompleted = true;
}

public class Program
{
    public static void Main()
    {
        List<Taskitem> tasks = new();
        int id = 1;
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Add | 2. List | 3. Complete | 4. Exit");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter task description:");
                    string? desc = Console.ReadLine();
                    tasks.Add(new Taskitem { Id = id++, Description = desc ?? "" });
                    break;

                case "2":
                    foreach (var t in tasks)
                        Console.WriteLine($"{t.Id}. {t.Description} - {(t.IsCompleted ? "Done" : "Pending")}");
                    break;

                case "3":
                    Console.Write("Enter ID : ");
                    if (int.TryParse(Console.ReadLine(), out int markId))
                        tasks.Find(t => t.Id == markId)?.MarkComplete();
                    else
                        Console.WriteLine("ID harus angka.");
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak dikenali.");
                    break;
            }
        }
    }
}
