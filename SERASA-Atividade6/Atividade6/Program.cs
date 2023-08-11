using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Olá Seja Bem-Vindo(a) a Viagem da Camila");
            Console.WriteLine("Venha conferir diversas viagens\n\n");
           
            Console.WriteLine("Abaixo esta um dos melhores meses para viajar");
            int mes;

            Console.WriteLine("Escolha uma dessas opcções");

            Console.WriteLine("01-Janeiro");
            Console.WriteLine("03-Março");
            Console.WriteLine("08-Agosto");
            mes=int.Parse(Console.ReadLine());

           

            if(mes != 1 && mes != 3 && mes != 8)
            {
                Console.WriteLine("\n\nmês invalido");
                Main(null);
            }

            int diaDisponivel;
            Console.WriteLine("Os dias disponiveis são do dia 6 ao 21 ");
            Console.WriteLine("Escolha o melhor dia pra você");
            diaDisponivel= int.Parse(Console.ReadLine());

            if(diaDisponivel<=5 || diaDisponivel>=22)
            {
                Console.WriteLine("Dia inválido");
            }

            String periodo;
            Console.WriteLine("Qual o perido que deseja comprar a passagem");
            Console.WriteLine("Escolha uma dessas opções");
            Console.WriteLine("Tarde");
            Console.WriteLine("Manhã");
            Console.WriteLine("Noite");

            periodo = Console.ReadLine();


            Console.WriteLine("Sua passagem foi comprada com sucesso!");
            Console.WriteLine("--------------------------Recibo----------------------------");
            Console.WriteLine($" Sua viagem será no dia {diaDisponivel} no Mês {mes}, Periodo de compra {periodo}");



            Console.ReadKey();
        }
    }
}
