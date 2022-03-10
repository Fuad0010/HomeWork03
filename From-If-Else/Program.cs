using System;

namespace From_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ay(month) adı daxil edilir. Çıxışa hansı fəsil olduğunu yazdırsın.(if,else muxtelif yollar ile yaza bilersiz)

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Please write month name: \n(Xahiş olunur ayın adını yazın:)\n");

            string Month = Convert.ToString(Console.ReadLine());

            Console.WriteLine("");
            
            if (Month == "January"  || Month == "Yanvar" ||
                Month == "February" || Month == "Fevral" ||
                Month == "December" || Month == "Dekabr")
            {
                Console.WriteLine("This month chapter is Winter.\n(Bu ayın fəsli Qışdır.)");
            }

            else if (Month == "March" || Month == "Mart" ||
                     Month == "April" || Month == "Aprel"||
                     Month == "May")
            {
                Console.WriteLine("This month chapter is Spring.\n(Bu ayın fəsli Yazdır.)");
            }

            else if (Month == "June"   || Month == "Iyun" ||
                     Month == "July"   || Month == "Iyul" ||
                     Month == "August" || Month == "Avqust")
            {
                Console.WriteLine("This month chapter is Summer.\n(Bu ayın fəsli Yaydır.)");
            }

            else if (Month == "September" || Month == "Sentyabr" ||
                     Month == "October"   || Month == "Oktyabr" ||
                     Month == "November"  || Month == "Noyabr")
            {
                Console.WriteLine("This month chapter is Fall\n(Bu ayın fəsli payızdır.)");
            }

            else
            {
                Console.WriteLine("This month does not exist.\n(Belə bir ay mövcud deyil.)");
            }


        }
    }
}
