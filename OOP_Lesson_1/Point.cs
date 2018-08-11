using System;
namespace OOP_Lesson_1
{
    public class Point
    {

        public int x;
        public int y;
        public char symb;


        public void Draw(int x, int y, char symb)

        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);

        }


    }
}
