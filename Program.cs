using System.Net.Sockets;

using var tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
try{

    await tcpClient.ConnectAsync("192.168.220.139",1777);
    while(true)
    {
        byte[] imageData = File.ReadAllBytes("Изображения/3232332.jpg");

        Console.WriteLine("Введите команду для сервера");
        string command = Console.ReadLine() + '\n';

        byte[] requestData = File.ReadAllBytes("Изображения/3232332.jpg");

        await tcpClient.SendAsync(requestData, SocketFlags.None);

        Console.WriteLine("Сообщение отправлено");

        byte[] Data = new byte[512];
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}