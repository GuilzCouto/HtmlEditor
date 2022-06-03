using System;
using System.IO;

namespace HtmlEditor
{
    public static class Open
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Modo Abrir Arquivos");
            Console.WriteLine("===================");
            Start();
        }

        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            };

            Console.WriteLine("");
            Console.ReadLine();
            Menu.Show();
        }
    }
}