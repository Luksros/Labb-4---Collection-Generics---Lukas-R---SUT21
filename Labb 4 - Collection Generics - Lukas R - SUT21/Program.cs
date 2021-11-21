using System;
using System.Collections.Generic;

namespace Labb_4___Collection_Generics___Lukas_R___SUT21
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Employee> empStack = new Stack<Employee>();
            Employee lukas = new Employee(101, "Lukas", "Rose", 'M', 250000f);
            Employee erikN = new Employee(207, "Erik", "Norell", 'M', 260500f);
            Employee viktor = new Employee(183, "Viktor", "Gunnarsson HK", 'M', 272300f);
            Employee erikR = new Employee(214, "Erik", "Risholm", 'M', 260000f);
            Employee helga = new Employee(142, "Helga", "Hildenbrau", 'F', 302000f);

            empStack.Push(lukas);
            empStack.Push(erikN);
            empStack.Push(viktor);
            empStack.Push(erikR);
            empStack.Push(helga);

            WriteGreen("STACK.COUNT:");
            foreach (Employee e in empStack)
            {
                Console.WriteLine(e);
                WriteYellow("Föremål kvar i stack: " + empStack.Count);
            }
            Continue();

            WriteGreen("STACK.POP:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(empStack.Pop());
                WriteYellow("Föremål kvar i stack: " + empStack.Count);
            }
            Continue();

            empStack.Push(lukas);
            empStack.Push(erikN);
            empStack.Push(viktor);
            empStack.Push(erikR);
            empStack.Push(helga);

            WriteGreen("STACK.PEEK");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(empStack.Peek()); 
                WriteYellow("Föremål kvar i stack: " + empStack.Count);
            }
            Continue();

            WriteGreen("Is item 3 in stack?");
            Console.WriteLine((empStack.Contains(viktor)) ? "\nItem 3  is in stack" : "\nItem 3 is not in stack");
            Console.Clear();

            List<Employee> empList = new List<Employee>() { lukas, erikN, erikR, viktor, helga};

            WriteGreen("LIST: ");
            Console.WriteLine((empList.Contains(viktor) ? "Viktor exists in the list\n" : "Viktor does not exist in the list\n"));
            WriteYellow("First male employee in list:");
            Console.WriteLine(empList.Find(emp => emp.Gender == 'M'));
            List<Employee> maleEmpList = new List<Employee>(empList.FindAll(emp => emp.Gender == 'M'));

            WriteYellow("\nAll male employees: ");
            foreach  (Employee employee in maleEmpList)
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();

        }
        public static void WriteYellow(string input)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(input);
            Console.ResetColor();
        }

        public static void WriteGreen(string input)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(input);
            Console.ResetColor();
        }

        public static void Continue()
        {
            Console.WriteLine();
            Console.WriteLine("Tryck Enter för att fortsätta.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
