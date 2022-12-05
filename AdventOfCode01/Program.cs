using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace AdventOfCode01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int max = 0;
            int sum = 0;
            string s = "";
            int elf = 1;
            int pamti = 0;
            var lineCount = File.ReadAllLines(@"C:\Users\Student\Desktop\patuljci.txt").Length;
            //    while (true)
            //    {
            //        sum = 0;
            //        for(i=1;i<=5;i++)
            //        {
            //            string s = Console.ReadLine();

            //            if (s == "")
            //            {

            //                break;
            //            }
            //            else
            //            {
            //                sum += Convert.ToInt32(s);
            //            }
            //            if (sum > max)
            //            {
            //                max = sum;
            //                pamti = i;
            //            }

            //            i++;
            //        }
            //        break;
            //    }
            //    Console.Write(sum);
            //    Console.ReadKey();
            //}
            while (true)
            {   
                foreach (string line in System.IO.File.ReadLines(@"C:\Users\Student\Desktop\patuljci.txt"))
                {

                    //while (line != "")
                    //{
                    //    sum += Convert.ToInt32(line);
                    //    if (sum > max)
                    //    {
                    //        max = sum;
                    //        pamti = elf;
                    //    }
                    //}

                    if (line != "")
                    {
                        sum += Convert.ToInt32(line);
                        if (sum > max)
                        {
                            max = sum;
                            pamti = elf;
                        }
                        Console.Write(line + "\t\t\t" + sum + "\n");
                        sum = 0;
                    }
                    

                    elf++;
                }
                break;
            }
        


        //for (int elf = 1; elf <=lineCount; elf++)
        //{
        //    sum = 0;
        //    while ((s = Console.ReadLine()) != "")
        //    {
        //        sum += Convert.ToInt32(s);
        //        if (sum > max)
        //        {
        //            max = sum;
        //            pamti = elf;
        //        }
        //    }
        //}
        Console.WriteLine("Vilenjak sa najvise kalorija za pojesti je: " + max.ToString());
            Console.ReadKey();
            
        }
    }
}
