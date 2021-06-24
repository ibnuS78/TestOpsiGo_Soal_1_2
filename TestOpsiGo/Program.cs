using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOpsiGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;

            Console.WriteLine("Angka Yang DI Test : " + n.ToString());

            for(int i = n; i >= 1; i--)
            {
                int x = i;
                string output = x.ToString();

                for (int j = x; j >= 1; j--)
                {
                    while (x <= n)
                    {
                        if(x+j <= n)
                        {
                            output += "," + j.ToString();
                        }

                        x += j;

                        if(x == n || j == n)
                        {
                            Console.WriteLine(output);
                            x += 1;
                        }
                    }
                    x = i;
                    output = x.ToString();
                    
                }

            }

            Console.ReadLine();
        }
    }
}
