namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; }
        private string IMEI { get; }
        private int Memoria { get; } 


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando para Iphone12 ({81}) {99876}-{5432}");
        }

        public void AtenderLigacao()
        {
            Console.WriteLine($"Atendendo chamada de NokiaC30 ({81}) {99712}-{5678}");
        }
        
        public void FinalizarChamada()
        {
             Console.WriteLine($"Chamada finalizada no horário {DateTime.Now.ToString("HH:mm:ss")}");
        }
        public void AplicativoInstalado()
        {
            Console.WriteLine($"Aplicativo instalado com sucesso!");
        }
        public void InstalouAplicativo()
        {
            Console.WriteLine($"Seu aplicativo foi instalado.");
        }

        public void MensagemEnviada()
        {
            Console.WriteLine($"Enviando mensagem: Olá,tudo bem?");
            Console.WriteLine($"Mensagem enviada!");
        }
        
        public void RecebidaMensagem()
        {
           Console.WriteLine($"Recebendo mensagem: Olá,tudo bem?");
           Console.WriteLine($"Mensagem recebida com sucesso!");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}