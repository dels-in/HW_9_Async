using HW_9;

var image = new ImageDownloader();

image.ImageStarted += HandleStarted;
image.ImageCompleted += HandleCompleted;

var task = image.DownloadAsync();
image.Download();

while (true)
{
    var key = Console.ReadKey();
    switch (key.Key)
    {
        case ConsoleKey.A:
            Console.WriteLine($"\n{task.IsCompleted}");
            break;
        default:
            return;
    }
}

void HandleStarted()
{
    Console.WriteLine("Скачивание файла началось");
}

void HandleCompleted()
{
    Console.WriteLine("Скачивание файла закончилось");
}