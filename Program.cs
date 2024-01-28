using DesafioPOO.Models;
class Program
{
    
    static void Main()
    {

        Console.WriteLine("Nokia C30: Android ");
        Smartphone nokia = new Nokia(numero: "(81)99712-5678", modelo: "Modelo C30", imei: "1234", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Telegram");
        nokia.IncluirAplicativo();
        nokia.EnviarMensagem();


        Console.WriteLine("\n");
        Console.WriteLine("Iphone 12: iOS ");
        Smartphone iphone = new Iphone(numero: "(81)99876-5432", modelo: "12", imei: "5678", memoria: 128);
        iphone.AtenderLigacao();
        Thread.Sleep(3000);
        iphone.FinalizarChamada();
        iphone.InstalarAplicativo("Instagram");
        iphone.AdicionarAplicativo();
        iphone.ReceberMensagem();

        Console.WriteLine("\n");
      
  }
}    