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
            //Deklaracija promenljivih
            int sum = 0;
            int max1 = 0;
            int max2 = 0;
            int max3 = 0;
            //Petlja koja se krece kroz svaku liniju fajla
            foreach (string line in System.IO.File.ReadLines(@"C:\Users\MV\Desktop\patuljci.txt"))
            {
                if (line != "")
                {
                    sum += int.Parse(line);
                }

                if (line == "")
                {
                    
                    if(sum>max3)
                    {
                        if (max3 > max2)
                        {
                            if(max2>max1)
                            { max1 = max2; }
                            max2 = max3;
                        }
                        max3 = sum;
                    }
                    sum = 0;
                }
            }   
            Console.WriteLine(max1+max2+max3);
            Console.ReadKey();
        }
    }
}
