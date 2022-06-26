using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Test_1
{
    internal class Program
    {//print pyramid using numbers
        static void Main(string[] args)
        {
            //User input
            Console.Write("Enter Number of rows: ");
            string r=Console.ReadLine();
            //convert the string to integer
            int rows = int.Parse(r);
            string c = "0";
            //Assign
            int count = int.Parse(c); 
            int count1 = int.Parse(c); 
            int k= int.Parse(c);

            for (int i = 1; i <= rows; ++i) { 
                for(int j = 1; j <= rows-i; ++j)
                {
                    Console.Write(" ");
                    ++count;
                }
                while (k != 2 * i - 1)
                {
                    if (count <= rows - 1)
                    {
                        Console.Write(i + k + " ");
                        ++count;
                    }
                    else
                    {
                        ++count1;
                        Console.Write(i + k - 2 * count1 + " ");
                    }
                    ++k;
                }
                count1 = count = k = 0;
                Console.Write("\n");
            }
        }
    }
}
