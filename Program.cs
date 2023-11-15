using System.Net.Sockets;
using System.Text;

using var tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
try{

    await tcpClient.ConnectAsync("192.168.220.139",1777);
    while(true)
    {
        System.Console.WriteLine("Введите команду для сервера");
        string command = Console.ReadLine() + '\n';

        byte[] requestData = Convert.ToByte;

        await tcpClient.SendAsync(requestData);

        Console.WriteLine("Сообщение отправлено");

        byte[] data = new byte[512];

        int bytes = await tcpClient.ReceiveAsync(data);

        string time = Encoding.UTF8.GetString(data, 0, bytes);

        Console.WriteLine($"Текущее время: (time)");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}