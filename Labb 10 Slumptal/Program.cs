using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_10_Slumptal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.3
            Random randomObjekt = new Random();

            int slumpTal1 = randomObjekt.Next(1, 11);
            int slumpTal2 = randomObjekt.Next(1, 11);

            if(slumpTal1 == slumpTal2)
            {
                Console.WriteLine("Båda slumptalen blev " + slumpTal1);
            }
            else if(slumpTal1 > slumpTal2)
            {
                Console.WriteLine(slumpTal1 + " är större än " + slumpTal2);
            }
            else
            {
                Console.WriteLine(slumpTal1 + " är mindre än " + slumpTal2);
            }
            



            //3.2
            //Random randomObjekt = new Random();

            //int slumpTal1 = randomObjekt.Next(1, 7);
            //int slumpTal2 = randomObjekt.Next(1, 7);


            //if (slumpTal1 == slumpTal2)
            //{
            //    Console.WriteLine("Ett par i " + slumpTal1);
            //}
            //else
            //{
            //    Console.WriteLine("Talen är " + slumpTal1 + " och " + slumpTal2);
            //}

            //Random randomObjekt = new Random();

            //int[] slumpTal = new int[100];

            //for (int i = 0; i < slumpTal.Length; i++)
            //{
            //    int argument1 = 1;
            //    int argument2 = 101;
            //    slumpTal[i] = randomObjekt.Next(argument1, argument2);
            //}

            //for (int i = 0; i < slumpTal.Length; i++)
            //{
            //    Console.WriteLine(slumpTal[i]);
            //}


            //int slumpTal1 = randomObjekt.Next(1, 101);
            //int slumpTal2 = randomObjekt.Next(1, 101);
            //int slumpTal3 = randomObjekt.Next(1, 101);
            //int slumpTal4 = randomObjekt.Next(1, 101);
            //int slumpTal5 = randomObjekt.Next(1, 101);

            //Console.WriteLine(slumpTal1);
            //Console.WriteLine(slumpTal2);
            //Console.WriteLine(slumpTal3);
            //Console.WriteLine(slumpTal4);
            //Console.WriteLine(slumpTal5);



            //Random randomObjekt = new Random();
            //int slumpTal = randomObjekt.Next(1, 11);

            //Console.Write("Gissa på ett tal mellan 1 och 10 ");
            //string indata = Console.ReadLine();
            //int gissatTal = Convert.ToInt32(indata);

            //if (gissatTal == slumpTal)
            //{
            //    Console.WriteLine("Rätt gissat");
            //}
            //else
            //{
            //    Console.WriteLine("Fel! Rätt tal är: " + slumpTal);
            //}

            Console.ReadLine();


        }
    }
}
