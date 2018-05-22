using System;

namespace Teste01
{
    internal class CarroBasico
    {
        public CarroBasico()
        {
            Cor = "neutra";
            Portas = 2;
            AirBag = false;
            motor = new Motor();
            motor.Potencia = "1.0";
        }

        public string Cor { get; set; }
        public int Portas { get; }
        public bool AirBag { get; set; }

        public Motor motor { get; set; }

        public void Ligar()
        {
            //abri o banco de dados
            try
            {
                Console.WriteLine("carro ligado");
                // tento acessar o banco de dados
                // passo2
                // ...
                throw new Exception("Sem gasolina.");
            }
            catch(Exception excessao)
            {
                Console.WriteLine("Ocorreu um erro ao ligar o carro. Erro: " + excessao.Message);
            }
            finally
            {
                //  fecho a conexao com o banco
            }
        }

        public string Ligar(bool somdomotor)
        {
            Ligar();
            if (somdomotor) Console.WriteLine("vrummmm");

            return "ligado";
        }
    }

    // carquenew@gmail.com
}