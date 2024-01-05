namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; }
        private string IMEI { get; }
        private int Memoria { get; } 
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando para Iphone ...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo chamada de Nokia ...");
        }
        public void AplicativoInstalado()
        {
            Console.WriteLine($"Seu aplicativo foi instalado.");
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}