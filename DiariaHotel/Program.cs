using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariaHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            //Entrada 1
            Console.WriteLine("Informe o valor da diária do hotel: ");
             double dh = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de adultos: ");
             double qa = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de criança: ");
             double qc = double.Parse(Console.ReadLine()); 
            //processamento 1
            double vdf = (dh * qc / 2) + dh * qa;
            //Saída 1
            Console.WriteLine("O valor da diária pra família é de " + vdf.ToString("C"));
             Console.WriteLine(" ");
            //Entrada 2
            Console.WriteLine("Informe quantos dias você quer ficar: ");
            //Processamento 2
            double d = double.Parse(Console.ReadLine());
            double vh = vdf * d;
            //Saída 2
            Console.WriteLine("O valor total da hospedagem, durante esses dias é de " + vh.ToString ("C"));
             Console.WriteLine(" ");
            //Entrada 3
            Console.WriteLine("Quantas vezes você quer parcelar?");
            //Processamneto 3
            double vp = double.Parse(Console.ReadLine());
             double vcp = vh / vp;
             Console.WriteLine(" ");
            //Saída 3
            Console.WriteLine("O valor de cada parcela é de " +vcp.ToString("C"));

            Console.ReadKey();  



        }
    }
}
