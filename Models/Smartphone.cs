namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        private string NumeroR { get; set; }
        
        private string Modelo { get; set; }

        private string IMEI { get; set; }
        private int Memoria { get; set; }        
        public Smartphone(string numero, string numeroR, string modelo, string imei, int memoria)
        {
            Numero = numero;
            NumeroR = numeroR;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando {Numero}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação {NumeroR}...");
            
        }

        public abstract void InstalarAplicativo(string nomeApp);

    }
}