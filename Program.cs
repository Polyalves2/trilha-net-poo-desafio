using DesafioPOO.Models;
class Program
{
    
    static void Main()
    {
// TODO: Realizar os testes com as classes Nokia e Iphone
        Console.WriteLine("Nokia C30: ");
        Smartphone nokia = new Nokia(numero: "(81)9712-5678", modelo: "Modelo C30", imei: "1234", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Telegram");
        nokia.AplicativoInstalado();


        Console.WriteLine("\n");
        Console.WriteLine("Iphone 12: ");
        Smartphone iphone = new Iphone(numero: "(81)9876-5432", modelo: "12", imei: "5678", memoria: 128);
        iphone.AtenderLigacao();
        Thread.Sleep(6*30);
        iphone.FinalizarChamada();
        iphone.InstalarAplicativo("Instagram");
        iphone.AplicativoInstalado();

        Console.WriteLine("\n");
      
  }
}    