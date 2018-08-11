using System;

namespace OOP_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Point p1 = new Point();

            p1.x = 2;
            p1.y = 2;
            p1.symb = '*';


            Point p2 = new Point();

            p2.x = 5;
            p2.y = 5;
            p2.symb = '#';





            p1.Draw(p1.x, p1.y, p1.symb);
            p2.Draw(p2.x, p2.y, p2.symb);


            Console.ReadLine();
        }

        static void Draw (int x, int y, char sym)
        {

            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }
    }
}
