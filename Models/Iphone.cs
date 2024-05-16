using System.ComponentModel;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone

    {
        public Iphone(string numero, string numeroR, string modelo, string imei, int memoria) : base(numero, numeroR, modelo, imei, memoria)
        {

        }


        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp}...");
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso!");
        }

    }
}