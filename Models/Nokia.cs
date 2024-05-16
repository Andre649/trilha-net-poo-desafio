using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone

    {
        public Nokia(string numero, string numeroR, string modelo, string imei, int memoria) : base(numero, numeroR, modelo, imei, memoria)
        {
             // TODO: Passar os parâmetros do construtor para as propriedades
        }
          
     
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp}...");
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso!");
        }

    }
}