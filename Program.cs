using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testevalidação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char Genero, Validacao;
            bool Status = false;



            do
            {
                Console.WriteLine("Entre com o Genero M [Masculino] F [Feminino] ");
                Validacao = Convert.ToChar(Console.ReadKey(true).KeyChar);

                if (Validacao == 'M' || Validacao == 'm' || Validacao == 'F' || Validacao == 'f')
                {
                    Genero = Validacao;
                }
                else 
                {
                    Console.WriteLine("Valor invalido recomece!");
                    Status = true;
                }

                Genero = Validacao;

                if (Genero == 'M' || Genero == 'm')
                {
                    Console.WriteLine("Voce é homi");
                    Status = false;

                }
                else if (Genero == 'F' || Genero == 'f')
                {
                    Console.WriteLine("Você é Mulher");
                    Status = false;

                }


            } while (Status == true);

            Console.ReadKey();
        }
        
   
    }
}
