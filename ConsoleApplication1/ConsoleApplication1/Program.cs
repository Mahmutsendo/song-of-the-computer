using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamWriter yaz = new StreamWriter("song.txt");


            int fr, zaman;

            do
            {
                Console.Write("entr the frecuncy of the deep: ");
                fr = Convert.ToInt32(Console.ReadLine());
                if (fr == -1)
                    break;
                Console.Write("Enter the pirod of the deep: ");
                zaman = Convert.ToInt32(Console.ReadLine());

                yaz.WriteLine(fr + " " + zaman);
                Console.Beep(fr, zaman);

            } while (fr != -1);


            yaz.Flush();
            yaz.Close();
            Console.Write("out of loop ");
            Console.ReadLine();
        }
    }
}
