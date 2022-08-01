using System;
using System.Text;
using SF_Module18_Practice.Commands;
using YoutubeExplode;

namespace SF_Module18_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YoutubeMaster youtubeMaster = new YoutubeMaster();
            var client = new YoutubeClient();
            string url = null;
            var exit = false;

            Console.WriteLine("\t\t --- C O N S O L E   Y O U T U B E   D O W N L O A D E R ---");

            while (true)
            {
                exit = false;
                Console.Write("\n<< введите адрес видео >>\n");
                url = Console.ReadLine();

                if (url == "0")
                    break;

                var newVideo = new Video(url, client);

                Console.WriteLine("\n1 - информация \n2 - загрузка \n3 - выбрать другое видео \n0 - выход\n");

                while (!exit)
                {
                    string input = Console.ReadLine();

                    int choice = 0;

                    var check = int.TryParse(input, out choice);

                    if (choice == 1)
                        youtubeMaster.SetCommand(new GetInfoCommand(newVideo));
                    if (choice == 2)
                        youtubeMaster.SetCommand(new DownloadCommand(newVideo));
                    if (choice == 3)
                        exit = true;
                    if (choice == 0)
                        Environment.Exit(0);
                    if (check && (choice == 1 | choice == 2))
                        youtubeMaster.Execute();
                }
            }

            Console.ReadKey();
        }
    }
}
