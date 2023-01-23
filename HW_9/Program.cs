using HW_9;

var image = new ImageDownloader();

image.ImageStarted += HandleStarted;
image.ImageCompleted += HandleCompleted;

image.Download();

var task = image.DownloadAsync();

Console.WriteLine("Нажмите любую клавишу для выхода");
Console.ReadKey();

void HandleStarted()
{
    Console.WriteLine("Скачивание файла началось");
}

void HandleCompleted()
{
    Console.WriteLine("Скачивание файла закончилось");
}