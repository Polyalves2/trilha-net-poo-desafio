using DesafioPOO.Models;
class Program
{
    
    static void Main()
    {
// TODO: Realizar os testes com as classes Nokia e Iphone
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "8191234-5678", modelo: "Modelo C30", imei: "1234", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Telegram");
        nokia.AplicativoInstalado();

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone: ");
        Smartphone iphone = new Iphone(numero: "8199876-5432", modelo: "14", imei: "5678", memoria: 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
        iphone.AplicativoInstalado();

        Console.WriteLine("\n");
    }
}    