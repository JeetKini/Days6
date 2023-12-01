using Microsoft.Win32;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days6
{
    interface Itwo {
        void play();
    }

    interface Ione {

        void play();
    }
   
    class TextBox :Ione,Itwo {
    
        public  void play() {

            System.Console.WriteLine("Hello All Methods Are Override");
        }

        
    }
    internal class Program
    {
       public static void Main(string[] args)
        {
            //var lifo = new LIFO();
            //Console.WriteLine("Welcome to Stack Class");
            //lifo.call();

            //var user = Convert.ToInt32(Console.ReadLine());
            //switch (user)
            //{
            //    case 1:
            //        lifo.push();
            //        break;
            //    case 2: lifo.Pop(); break;
            //    case 3: lifo.clear(); break;
            //        case 4: Environment.Exit(0); break;
            //    default:
            //        Console.WriteLine("Invalid Input");
            //        lifo.call();
            //        break;
            // }
            //Mehtod Overrriding
            //Circle shape = new Circle();
            // shape.Draw();

            // Abstract Class
            //Animal animal = new Tiger();
            //animal.Eat();


            //    var a = 0;
            //    while (true)
            //    {

            //        Console.WriteLine("Enter the number");
            //       var s= Console.ReadLine();
            //        if (s == "ok")
            //        {
            //            break;
            //        }
            //        a = a + Convert.ToInt16(s);

            //    }
            //    Console.WriteLine(a);

            //var c=ConsoleColor.Cyan;
            //Console.WriteLine(c);

            //var db=new DbMigrate(new FileLogger(@"C:\\Users\\hp\\Desktop\\log.txt"));
            //db.Migrate();

            TextBox textBox = new TextBox();    
            textBox.play();

        }
    }
    }

