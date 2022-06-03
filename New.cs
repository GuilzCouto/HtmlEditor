using System;
using System.IO;
using System.Text;
using System.Threading;

namespace HtmlEditor
{
    public static class New
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("===========");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("===========");
            Console.WriteLine("Deseja salvar o arquivo?");
            Console.WriteLine("s - Sim");
            Console.WriteLine("n - Não");

            var option = Console.ReadLine();

            switch (option)
            {
                case "s" : Save(file) ; break;
                case "n" : Delete() ; break;
                default: Show(); break;
            }
        }

        public static void Save(StringBuilder file)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();
            using (var html = new StreamWriter(path))
            {
                html.Write(file);
            };
            Console.WriteLine($"Arquivo {path} salvo com Sucesso!");
            Console.ReadLine();
            Menu.Show();
        }
                        
        public static void Delete()
        {
            Console.Clear();
            Console.WriteLine("Texto Apagado... Retornando ao Menu");
            Thread.Sleep(3000);;
            Menu.Show();
        }
    }
}