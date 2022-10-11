using System;

namespace eleiçãowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleições 2022");
            int qtdCant26 = 0;
            int qtdCant44 = 0;
            int qtdCant56 = 0;
            int qtdNullo = 0;
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("qual seu nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("vote em um candidato a seguir: ");
                Console.WriteLine("26 - João ");
                Console.WriteLine("44 - Maria");
                Console.WriteLine("56 - Tabet");
                Console.WriteLine("0 - Nulo");
                Console.WriteLine("Só digite o número");
                int meuVoto = Convert.ToInt32(Console.ReadLine());

                if (meuVoto == 26) { qtdCant26 = qtdCant26 + 1; }
                else if (meuVoto == 44) { qtdCant44 = qtdCant44 + 1; }
                else if (meuVoto == 56) { qtdCant56 = qtdCant56 + 1; }
           
                else qtdNullo = qtdNullo + 1;



                Console.WriteLine("Deseja continuar {sim / não}");
                 string resposta = Console.ReadLine();
                //if ( resposta == "sim") {continuar = true;} else {continuar = false};      
                if (resposta == "sim" ? continuar = true : continuar = false) ;


            }
        }  
    }
}
