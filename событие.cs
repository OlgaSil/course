using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ob = new Class1();
            ob.OnKeyPressed += Ob_OnKeyPressed;
            ob.Run();
        }
        
        private static void Ob_OnKeyPressed(object sender, char e)
        {
            Console.WriteLine($"Вы ввели: {e}");
        }
    }

    class Class1
    {
        public event EventHandler<char> OnKeyPressed;
        public void Run()
        {
            char n;
            do
            {
                Console.Write("Введите символ: ");
                n = Convert.ToChar(Console.ReadLine());
                OnKeyPressed(this, n);
            } while (n != 'c');
        }
    }
}
