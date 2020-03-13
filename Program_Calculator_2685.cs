using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace calculator
{
class Calculator{
    static void Main(string[] args)
    {
        Console.Title = "Calculator Tyo";
        Console.Write("1.Penjumlahan\n2.Pengurangan\n3.Perkalian\n4.Pembagian\n");
        Console.Write("Pilihan Anda = ");
        int pilihan = int.Parse(Console.ReadLine());
        
        Console.Write("Masukan Angka Pertama = ");
        int a = int.Parse(Console.ReadLine());
    
        Console.Write("Masukan Angka Kedua = ");
        int b = int.Parse(Console.ReadLine());


        Console.WriteLine();
        switch(pilihan){
            case 1:
            Console.WriteLine("Hasil Penambahan  {0} + {1} = {2}", a, b, penambahan(a,b));
	    break;
            
	    case 2:
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a,b));
            break;
	    
	    case 3:
            Console.WriteLine("Hasil Perkalian   {0} * {1} = {2}", a, b, perkalian(a,b));
            break;
	
	    case 4:
            Console.WriteLine("Hasil Pembagian   {0} / {1} = {2}", a, b, pembagian(a,b));
            break;
	    
	    default:
            Console.WriteLine("Maaf Tidak Ada Pilihan Lain");
            break;
		}
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
    
    static int perkalian(int a, int b)
    {
        return a*b;
    }
    
    static int pembagian(int a, int b)
    {
        return a/b;
    }

    }
    }
