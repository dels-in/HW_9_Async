<h3>Делегаты, Event-ы, добавляем асинхронное выполнение</h3>

Цель:
<ul>
<li>работа с событиями</li>
<li>избегание блокировок через асинхронные вызовы</li>
</ul>

Описание/Пошаговая инструкция выполнения домашнего задания:
<ol>
<li>
Напишите класс ImageDownloader. В этом классе должен быть метод Download, который скачивает картинку из интернета. Для загрузки картинки можно использовать примерно такой код: https://dotnetfiddle.net/5oT1Hi
</li>
// Откуда будем качать
string remoteUri = "https://effigis.com/wp-content/uploads/2015/02/Iunctus_SPOT5_5m_8bit_RGB_DRA_torngat_mountains_national_park_8bits_1.jpg";
// Как назовем файл на диске
string fileName = "bigimage.jpg";
// Качаем картинку в текущую директорию
var myWebClient = new WebClient();
Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", fileName, remoteUri);
myWebClient.DownloadFile(remoteUri, fileName);
Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", fileName, remoteUri);
<li>
Создайте экземпляр этого класса и вызовите скачивание большой картинки, например, https://effigis.com/wp-content/uploads/2015/02/Iunctus_SPOT5_5m_8bit_RGB_DRA_torngat_mountains_national_park_8bits_1.jpg
В конце работы программы выведите в консоль "Нажмите любую клавишу для выхода" и ожидайте нажатия любой клавиши.
</li>
<li>
Добавьте события: в классе ImageDownloader в начале скачивания картинки и в конце скачивания картинки выкидывайте события (event) ImageStarted и ImageCompleted соответственно.
</li>
<li>
В основном коде программы подпишитесь на эти события, а в обработчиках их срабатываний выводите соответствующие уведомления в консоль: "Скачивание файла началось" и "Скачивание файла закончилось".
</li>
<li>
Сделайте метод ImageDownloader.Download асинхронным. Если Вы скачивали картинку с использованием WebClient.DownloadFile, то используйте теперь WebClient.DownloadFileTaskAsync - он возвращает Task.
</li>
<li>
  В конце работы программы выводите теперь текст "Нажмите клавишу A для выхода или любую другую клавишу для проверки статуса скачивания" и ожидайте нажатия любой клавиши. Если нажата клавиша "A" - выходите из программы. В противном случае выводите состояние загрузки картинки (True - загружена, False - нет). Проверить состояние можно через вызов Task.IsCompleted.
</li>
</ol>
Поздравляю! Ваша загрузка картинки работает асинхронно с основным потоком консоли.
