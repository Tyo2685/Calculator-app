using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Calculator
{
class Calculator
{
    static void Main(string[] args)
    {
	int a = 10;
	int b = 6;
	Console.WriteLine("Hasil Penambahan  {0} + {1} = {2}", a, b, penambahan(a,b));
	Console.WriteLine("Hasil Penambahan  {0} - {1} = {2}", a, b, pengurangan(a,b));
	Console.WriteLine("Tekan Apapun....");
        Console.ReadLine();
    }
   static int penambahan(int a, int b)
    {
        return a+b;
    }
    static int pengurangan(int a, int b)
    {
        return a-b;
    }
}
}