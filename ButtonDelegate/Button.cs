using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonDelegate
{
    public class Button
    {
        public event Action PressedAKey;

        public string Text { get; set; }
        public char Symbol { get; set; }
        public int Height { get; set; } //высота
        public int Width { get; set; }
        ConsoleColor MainColor { get; set; }
        ConsoleColor BgColor { get; set; }

        public Button(string text, char symbol, int height, int width, ConsoleColor mainColor, ConsoleColor bgColor)
        {
            Text = text;
            Symbol = symbol;
            Height = height;
            Width = width;
            MainColor = mainColor;
            BgColor = bgColor;
        }

        public void isPressedButton()
        {
            PrintMe();
            PressedAKey?.Invoke();
        }

        public void PrintMe()
        {
            for(int i = 0; i < this.Height; i++)
            {
                for(int j = 0; j < this.Width; j++)
                {
                    if ((i == 0 || i == Height - 1) || (j == 0 || j == Width - 1))
                    {
                        Console.ForegroundColor = MainColor;
                        Console.BackgroundColor = BgColor;
                        Console.Write(Symbol);
                    }
                    else if(j == Width /2 - Text.Length / 2 && i == Height / 2)
                    {
                        j += Text.Length - 1;
                        Console.Write(Text);
                    }
                    else
                        Console.Write(' ');                    
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }        
    }
}
