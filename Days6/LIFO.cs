using System.Collections.Generic;
using System;

namespace Days6
{
    class LIFO {
        List<string> list = new List<string>();
        public void push()
        {

            Console.WriteLine("Enter num to add in list");
            while (true)
            {
                var c = Console.ReadLine();
                list.Add(c);
                if (String.IsNullOrEmpty(c)) break;
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            call();
        }
        public void Pop()
        {
            Console.WriteLine("Enter pop to Remove One Element");
            var pop = "pop";
            if (pop == "pop")
            {
                list.Remove(list[0]);
            }
            else
            {
                Console.WriteLine("Invalid input");
                Pop();
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            call();

        }
        public void clear()
        {
            var remove = "remove";
            Console.WriteLine("Enter remove to clear all");
            remove = Console.ReadLine();
            if (remove == "remove")
            {
                list.Clear();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                clear();
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
        public void call()
        {

            Console.WriteLine("Press 1  to Push");
            Console.WriteLine("Press 2 to Pop");
            Console.WriteLine("Press 3 to Remove");
            Console.WriteLine("Press 4 to exit");
            var user = Convert.ToInt32(Console.ReadLine());
            switch (user)
            {
                case 1:
                    push();
                    break;
                case 2: Pop(); break;
                case 3: clear(); break;
                case 4:Environment.Exit(0);
                    ;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    call();
                    break;
            }
        }
    }
}

