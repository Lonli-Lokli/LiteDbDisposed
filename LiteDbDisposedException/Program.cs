using System;

namespace LiteDbDisposedException
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key = default;
            var readRepo = new ReadRepository();
            var writeRepo = new WriteRepository();
            do
            {
                Console.WriteLine("Choose numpad action (1, 2, 3):");
                Console.WriteLine("1. Add document");
                Console.WriteLine("2. List all document");
                Console.WriteLine("3. Exit");
                key = Console.ReadKey();
                try
                {
                    Console.WriteLine();
                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            Console.WriteLine("Enter title and press enter");
                            var title = Console.ReadLine();
                            writeRepo.Add(title);
                            Console.WriteLine("New document has been added");
                            break;
                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            Console.WriteLine("All documents:");
                            var all = readRepo.GetAll();
                            foreach (var documentDto in all)
                            {
                                Console.WriteLine("Document " + documentDto.Title);
                            }
                            Console.WriteLine("All printed.");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            } while (key.Key != ConsoleKey.NumPad3 || key.Key != ConsoleKey.D3);
            Console.WriteLine("EXITED. Press any key to close window.");
        }
    }
}