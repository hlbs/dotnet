using System;
using System.Collections.Generic;
namespace bootExemplo2
{
    public class pilha
    {
        static void Main()
        {
            Stack<string> nomeVariavel = new Stack<string>();
            nomeVariavel.Push("A");
            nomeVariavel.Push("B");
            nomeVariavel.Push("C");
            nomeVariavel.Push("D");
            Console.WriteLine("Exemplo de utilização de pilha, selecionando apenas os 2 últimos resultados da pilha");
            //Console.WriteLine(nomeVariavel.Pop());
            //Console.WriteLine(nomeVariavel.Pop());
            
            for(int i=2; i>0; i--){
                string valor = nomeVariavel.Pop();
                if(valor=="D"){
                    Console.WriteLine("D gosta de churros!");
                }
                else {
                    Console.WriteLine(valor + " Não gosta de churros!");
                }
            }

        }
    }
}

