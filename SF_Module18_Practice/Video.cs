using System;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace SF_Module18_Practice
{
    public class Video
    {
        YoutubeClient client { get; set; }
        public string url { get; set; }

        public Video(string url, YoutubeClient client)
        {
            this.url = url;
            this.client = client;
        }

        async public Task GetInfo()
        {
            try
            {
                var description = await client.Videos.GetAsync(url);

                var title = description.Title;
                var author = description.Author.Title;
                var duration = description.Duration;

                Console.WriteLine($"\nНазвание: {title}\n" 
                    + $"Автор: {author}\n"
                    + $"Длительность: {duration}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        async public Task Download()
        {
            try
            {
                Console.WriteLine("\nФайл будет скачан на рабочий стол ...\n");

                var description = await client.Videos.GetAsync(url);
                string fileneame = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\";
                fileneame += description.Title + ".mp4";

                await client.Videos.DownloadAsync(url, fileneame, builder => builder.SetPreset(ConversionPreset.UltraFast));

                Console.WriteLine("\nФайл успешно загружен! Выберите следующую команду меню \n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
