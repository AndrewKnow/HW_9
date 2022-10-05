using System;

namespace ДЗ_9
{
    class Program
    {
        static void Main(string[] args)
        {

            ImageDownloader imageDownloader = new ImageDownloader();

            imageDownloader.Begin += ImageDownloader_Begin;
            imageDownloader.Finish += ImageDownloader_Finish;

            // imageDownloader.Download();
            var result = imageDownloader.DownloadAsync();

            // Console.WriteLine("Нажмите любую клавишу для выхода");

            Console.WriteLine(@"Нажмите клавишу ""A"" (русская, верх. регистр) для выхода или любую другую клавишу для проверки статуса скачивания");

            // Console.ReadLine();

            while (true)
            {

                var key = Console.ReadKey();
                switch (key.KeyChar)
                {
                    case 'А':
                        return;
                    default:
                        

                        if (result.IsCompleted == true)
                        {
                            Console.WriteLine(result.IsCompleted.ToString());
                        }
                        else
                        {
                            Console.WriteLine(result.IsCompleted.ToString());
                        }

                        break;

                }
            }

        }

        private static void ImageDownloader_Begin()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Скачивание файла началось");
            Console.WriteLine("--------------------------");
        }

        private static void ImageDownloader_Finish()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Скачивание файла закончилось");
            Console.WriteLine("----------------------------");
        }
    }
}
