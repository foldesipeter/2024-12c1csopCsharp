using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoszam
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            //string adoszam;
            //do
            //{
               //Console.WriteLine("Adj megy egy 10 hosszu szamot!");
                //adoszam = Console.ReadLine();

                //if (adoszam.Length != 10 || !long.TryParse(adoszam, out _)) {
                    //{
                        //Console.WriteLine("Hibás bevitel! Pontosan 10 számjegybol allo szamot adj meg!");
                    //}
                //}
                //while (adoszam.Length != 10 || long.TryParse(adoszam, out _)) {
                    //Console.WriteLine($"Megadott szám: {adoszam}");
                //}
            //}
            


            string adoszam = "8347566259";
            int szam0 = 0;    
            int szam1 = 0;    
            int szam2 = 0;    
            int szam3 = 0;    
            int szam4 = 0;    
            int szam5 = 0;    
            int szam6 = 0;    
            int szam7 = 0;    
            int szam8 = 0;    
            int szam9 = 0;


            if (adoszam.Length != 10)
            {
                Console.WriteLine("Nem jó számot adtál meg!");
            }


            szam0 = Convert.ToInt32(Convert.ToString(adoszam[0]));
            szam1 = Convert.ToInt32(Convert.ToString(adoszam[1]));
            szam2 = Convert.ToInt32(Convert.ToString(adoszam[2]));
            szam3 = Convert.ToInt32(Convert.ToString(adoszam[3]));
            szam4 = Convert.ToInt32(Convert.ToString(adoszam[4]));
            szam5 = Convert.ToInt32(Convert.ToString(adoszam[5]));
            szam6 = Convert.ToInt32(Convert.ToString(adoszam[6]));
            szam7 = Convert.ToInt32(Convert.ToString(adoszam[7]));
            szam8 = Convert.ToInt32(Convert.ToString(adoszam[8]));
            szam9 = Convert.ToInt32(Convert.ToString(adoszam[9]));

            int sz1 = szam0 * 1;
            int sz2 = szam1 * 2;
            int sz3 = szam2 * 3;
            int sz4 = szam3 * 4;
            int sz5 = szam4 * 5;
            int sz6 = szam5 * 6;
            int sz7 = szam6 * 7;
            int sz8 = szam7 * 8;
            int sz9 = szam8 * 9;

            int szorz = sz1 + sz2 + sz3 + sz4 + sz5 + sz6 + sz7 + sz8 + sz9;
            int osszeg = szorz % 11;
            
            if (osszeg == szam9)
            {
                Console.WriteLine("Jó az adószámod");
            }
            else 
            {
                Console.WriteLine("Nem jó az adószámod");
            }
            Console.ReadKey();

        





        }
    }
}
