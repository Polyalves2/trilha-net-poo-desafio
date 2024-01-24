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
            Console.WriteLine($"Ligando para Iphone 12 ({81}) {99876}-{5432}");
        }

        public void AtenderLigacao()
        {
            Console.WriteLine($"Atendendo chamada de Nokia C30 ({81}) {99712}-{5678}");
        }
        
        public void FinalizarChamada()
        {
             Console.WriteLine($"Chamada finalizada. Duração: {6} minutos e {30} segundos.");
        }

        public void AplicativoInstalado()
        {
            Console.WriteLine($"Aplicativo instalado com sucesso!");
        }
        public void InstalouAplicativo()
        {
            Console.WriteLine($"Seu aplicativo foi instalado.");
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}