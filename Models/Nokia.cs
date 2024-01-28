namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {
       
    public Nokia(string numero, string sistemaOperacional, string modelo, string imei, int memoria)
        : base(numero, sistemaOperacional, modelo, imei, memoria)
    {
        
    }

    public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp}, Aguarde...");
        }


    }
} 