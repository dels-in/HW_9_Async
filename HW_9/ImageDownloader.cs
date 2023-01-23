using System.Net;

namespace HW_9;

public class ImageDownloader
{
    public event Action ImageStarted;
    public event Action ImageCompleted;


    public void Download()
    {
        ImageStarted?.Invoke();

        string remoteUri = "https://bfoto.ru/oboi/oboi_priroda_1920x1200.jpg";

        string fileName = "bigImage.jpg";

        var myWebClient = new WebClient();
        Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", fileName, remoteUri);
        myWebClient.DownloadFile(remoteUri, fileName);
        Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", fileName, remoteUri);

        Console.ReadKey();

        ImageCompleted?.Invoke();
    }

    public Task DownloadAsync()
    {
        ImageStarted?.Invoke();

        var key = Console.ReadKey();
        
        string remoteUri = "https://bfoto.ru/oboi/oboi_priroda_1920x1200.jpg";

        string fileName = "bigImage.jpg";

        var myWebClient = new WebClient();
        Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", fileName, remoteUri);
        var task = myWebClient.DownloadFileTaskAsync(remoteUri, fileName);
        Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", fileName, remoteUri);

        ImageCompleted?.Invoke();
        
        switch (key.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine(task.IsCompleted);
                break;
            default:
                return task;
        }

        return task;
    }
}