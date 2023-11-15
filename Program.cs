using System;
using System.Net.Sockets;
using System.Text;

using var tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
try{

    await tcpClient.ConnectAsync("192.168.220.139",1777);
    while(true)
    {
        System.Console.WriteLine("Введите команду для сервера");
        string command = Console.ReadLine() + '\n';

        byte[] imageData = File.ReadAllBytes("img/forVS.jpg");

        byte[] requestData = File.ReadAllBytes("img/forVS.jpg");

        await tcpClient.SendAsync(requestData, SocketFlags.None);

        Console.WriteLine("Сообщение отправлено");

        byte[] data = new byte[512];
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}