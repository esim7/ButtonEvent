using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ButtonDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            void GetMyName()
            {
                Console.WriteLine("Yessimzhan");
            }
            void GetARiddle()
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Он программы пишет-пишет,\nЗа компьютером сидит,\nВсе эмоции здесь лишни – \nЛишь исходный код твердит.");
                Console.ResetColor();
            }

            void GetAJoke()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("- Вчера долго пытался объяснить бабуле, что работаю программистом...\n- ???\n-Короче, сошлись на том, что чиню телевизоры и развожу мышей...");
                Console.ResetColor();
            }

            void GetASecondJoke()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Первые 90% кода занимают первые 90% времени на разработку… \nОставшиеся 10% кода занимают еще 90% времени на разработку.");
                Console.ResetColor();
            }
            List<Button> buttons = new List<Button>
            {
                new Button("W", '*', 5, 7, ConsoleColor.DarkBlue, ConsoleColor.DarkGreen),           
                new Button("A", '+', 5, 7, ConsoleColor.DarkGray, ConsoleColor.Red),
                new Button("S", '-', 5, 7, ConsoleColor.Magenta, ConsoleColor.Yellow),
                new Button("D", '=', 5, 7, ConsoleColor.DarkCyan, ConsoleColor.White)
            };
            buttons[0].PressedAKey += GetMyName;
            buttons[1].PressedAKey += GetARiddle;
            buttons[2].PressedAKey += GetAJoke;
            buttons[3].PressedAKey += GetASecondJoke;
            foreach (Button button in buttons)
            {
                button.PrintMe();
            }
            Console.WriteLine("Нажмите пробел для активации кнопок");
            if (Console.ReadLine() == " ")
            {
                Console.Clear();
                foreach (Button button in buttons)
                {
                    button.isPressedButton();
                }
            }
            Console.ReadKey();
        }
    }
}
