using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] birlerBasamak = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] onlarBasamak = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };


            Console.WriteLine("Bir sayı giriniz = ");
            string strsayi = Console.ReadLine();

            int basamak = strsayi.Length;
            int intsayi = Convert.ToInt32(strsayi);

            int[] basamaklar = new int[(strsayi.Length)];

            for (int i = 0; i < basamak; i++)
            {
                basamaklar[i] = intsayi % 10;
                intsayi = intsayi / 10;

            }
        
            if (basamak > 6)
            {
                Console.Write(birlerBasamak[basamaklar[7]] + onlarBasamak[basamaklar[6]] + " yüz ");
            }
            if (basamak > 5)
            {
                Console.Write(birlerBasamak[basamaklar[5]] + " yüz ");
            }
            if (basamak > 4)
            {
                Console.Write(onlarBasamak[basamaklar[4]] + " ");
            }
            if (basamak > 3)
            {
                Console.Write(birlerBasamak[basamaklar[3]] + " bin ");
            }
            if (basamak > 2)
            {
                Console.Write(birlerBasamak[basamaklar[2]] + " yüz ");
            }
            if (basamak > 1)
            {
                Console.Write(onlarBasamak[basamaklar[1]] + " " );
            }
            if (basamak > 0)
            {
                Console.Write(birlerBasamak[basamaklar[0]] + " " );
            }





        }

    }
}

