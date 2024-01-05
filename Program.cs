using DesafioPOO.Models;
class Program
{
    
    static void Main()
    {
// TODO: Realizar os testes com as classes Nokia e Iphone
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "123456789", modelo: "Modelo C30", imei: "1234", memoria: 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Telegram");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone: ");
        Smartphone iphone = new Iphone(numero: "987654321", modelo: "14", imei: "5678", memoria: 128);
        iphone.ReceberLigacao();
        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");

        Console.WriteLine("\n");
    }
}    