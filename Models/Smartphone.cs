namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Implementando o constructor
        public string Numero { get; set; }
        private string Modelo;
        private string Imei;
        private int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // Passando os parâmetros do construtor para as propriedades
            this.Numero = numero;
            this.Modelo = modelo;
            this.Imei = imei;
            this.Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}