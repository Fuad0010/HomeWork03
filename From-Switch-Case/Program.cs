using System;

namespace From_Switch_Case
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

            switch (Month)
            {
                case "Yanvar":
                case "Fevral":
                case "Dekabr":
                case "January":
                case "February":
                case "December":
                    Console.WriteLine("This month chapter is Winter.\n(Bu ayın fəsli Qışdır.)");
                    break;

                case "Mart":
                case "Aprel":
                case "May":
                case "March":
                case "April":
                    Console.WriteLine("This month chapter is Spring.\n(Bu ayın fəsli Yazdır.");
                    break;

                case "Iyun":
                case "Iyul":
                case "Avqust":
                case "June":
                case "July":
                case "August":
                    Console.WriteLine("This month chapter is Summer.\n(Bu ayın fəsli Yaydır.)");
                    break;

                case "Sentyabr":
                case "Oktyabr":
                case "Noyabr":
                case "September":
                case "October":
                case "November":
                    Console.WriteLine("This month chapter is Fall\n(Bu ayın fəsli payızdır.)");
                    break;

                default:
                    Console.WriteLine("This month does not exist.\n(Belə bir ay mövcud deyil.)");
                    break;

            }


        }
    }
}
