using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsControleConsole
{
    class Program
    {

        static private string generateBorder(int width, int height)
        {
            string result = "";
            string upDownLines = "";
            string otherLines = "";

            width--;
            height--;

            for (int i = 0; i < width; i++)
            {
                upDownLines += "_";

                if ((i == 0) || (i == width - 1))
                    otherLines += "|";
                else
                    otherLines += " ";
            }

            for (int i = 0; i < height; i++)
            {
                if ((i == 0) || (i == height - 1))
                    result += upDownLines + "\n";
                else
                    result += otherLines + "\n";

            }


            return result;
        }

        static void Main(string[] args)
        {

            string border = generateBorder(50,20);
            ConsoleKeyInfo pressedKey;

            Console.Clear();
            Console.CursorVisible = false;
            Console.Title="Tests de contrôle de la console";

            Console.SetWindowSize(50, 20);
            Console.SetBufferSize(50,20);
            Console.Write(border);

            do
            {
                pressedKey = Console.ReadKey(true);
                Console.Clear();
                Console.Write(border);
                Console.SetCursorPosition(1, 9);
                Console.WriteLine("Vous avez tapé sur " + pressedKey.Key.ToString());

            } while (pressedKey.Key != ConsoleKey.Escape);

            





            


        }
    }
}
