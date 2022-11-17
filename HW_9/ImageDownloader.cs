using System.Net;

namespace HW_9;

public class ImageDownloader
{
    public event Action ImageStarted;
    public event Action ImageCompleted;


    public void Download()
    {
        ImageStarted?.Invoke();

        string remoteUri =
            "https://effigis.com/wp-content/uploads/2015/02/Iunctus_SPOT5_5m_8bit_RGB_DRA_torngat_mountains_national_park_8bits_1.jpg";

        string fileName = "bigImage.jpg";

        var myWebClient = new WebClient();
        Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", fileName, remoteUri);
        var task = myWebClient.DownloadFileTaskAsync(remoteUri, fileName);
        Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", fileName, remoteUri);
        
        var key = Console.ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.A:
                return;
            default:
                Console.WriteLine(task.IsCompleted);
                break;
        }

        ImageCompleted?.Invoke();
    }
}