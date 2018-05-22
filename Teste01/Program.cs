using System;
using System.Threading;

namespace Teste01
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime hoje = DateTime.Now;
            string texto = string.Empty;
            int numero = 0;
            bool condicao = true;
            double decimais = 0.10;

            string[] nomes = { "Flavio", "Carlos", "Eduardo" };

            //for (int i = 0; i < nomes.Length; i += 2)
            //{
            //    Console.WriteLine(nomes[i]);
            //}

            //foreach (string nome in nomes)
            //{
            //    Console.WriteLine(nome);
            //}

            //int i = 0;
            //while (i < nomes.Length)
            //{
            //    Console.WriteLine(nomes[i]);
            //    i++;
            //    break;
            //}


            //for (int hora = 0; hora < 24; hora++)
            //{
            //    for (int minuto = 0; minuto < 60; minuto++)
            //    {
            //        for (int segundo = 0; segundo < 60; segundo++)
            //        {
            //            Console.WriteLine(hora.ToString() + ":" + minuto.ToString() + ":" + segundo.ToString());
            //            Thread.Sleep(1000);
            //        }
            //    }
            //}

            CarroBasico meucarro = new CarroBasico();
            meucarro.Cor = "Preto";
            //meucarro.Portas = 4;
            meucarro.AirBag = true;
            meucarro.motor.Potencia = "2.0";

            CarroBasico carro2 = new CarroBasico();
            carro2.Cor = "branco";
            //carro2.Portas = 2;
            carro2.AirBag = false;
            string retorno = carro2.Ligar(true);

            CarroSUV suv = new CarroSUV();
            suv.Ligar();

            Console.WriteLine(meucarro.Cor);
            Console.WriteLine(carro2.Cor);

            Console.Read();

            //string nome = string.Empty;
            //nome = Console.ReadLine();
            //Console.Write(nome);

            //if (numero == 1 || condicao)
            //{
            //    Console.Write("verdadeiro");
            //    if(condicao)
            //    {
            //        Console.Write("verdadeiro");
            //    }
            //}
            //else
            //{
            //    Console.Write("falso");
            //}

            //switch (condicao)
            //{
            //    case true:
            //        Console.Write("verdadeiro");
            //        break;
            //    case false:
            //        Console.Write("falso");
            //        break;
            //    default:
            //        Console.Write("nao sei");
            //        break;
            //}
        }
    }
}
