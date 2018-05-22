using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste01
{
    internal class CarroSUV : CarroBasico
    {
        public CarroSUV()
        {
            AirBag = true;
            motor = new Motor();
            motor.Potencia = "3.0";
        }

        public bool multimidia { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Carro ligado e todos os computadores ligados.");
        }
    }
}
