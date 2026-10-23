using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Data structures as required
        Queue<string> waitingQueue = new Queue<string>();
        Stack<string> servedStack = new Stack<string>();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("      STUDENT SERVICE QUEUE SYSTEM      ");
            Console.WriteLine("========================================");
            Console.WriteLine("[1] ADD STUDENT");
            Console.WriteLine("[2] SHOW WAITING STUDENTS");
            Console.WriteLine("[3] SERVE NEXT STUDENT");
            Console.WriteLine("[4] SHOW LAST SERVED STUDENT");
            Console.WriteLine("[5] EXIT");
            Console.WriteLine("----------------------------------------");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                 
                    Console.Write("Enter student's name: ");
                    string name = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        waitingQueue.Enqueue(name);
                        Console.WriteLine($"\nStudent '{name}' added successfully to the queue.");
                    }
                    else
                    {
                        Console.WriteLine("\nError: Name cannot be empty.");
                    }
                    break;

                case "2":
                   
                    if (waitingQueue.Count == 0)
                    {
                        Console.WriteLine("No students currently waiting in the queue.");
                    }
                    else
                    {
                        Console.WriteLine("Students currently waiting:");
                        int i = 1;
                        foreach (string student in waitingQueue)
                        {
                            Console.WriteLine($"{i}. {student}");
                            i++;
                        }
                        Console.WriteLine($"\nTotal waiting students: {waitingQueue.Count}");
                    }
                    break;

                case "3":
                   
                    if (waitingQueue.Count == 0)
                    {
                        Console.WriteLine("No students waiting to be served.");
                    }
                    else
                    {
                        string servedStudent = waitingQueue.Dequeue();
                        servedStack.Push(servedStudent);
                        Console.WriteLine($"Serving student: {servedStudent}");
                        Console.WriteLine("Student successfully served!");
                    }
                    break;

                case "4":
                    
                    if (servedStack.Count == 0)
                    {
                        Console.WriteLine("No students have been served yet.");
                    }
                    else
                    {
                        string lastServed = servedStack.Peek();
                        Console.WriteLine($"Last served student: {lastServed}");
                    }
                    break;

                case "5":
                    
                    Console.WriteLine("Exiting program. Thank you!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 5.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}

