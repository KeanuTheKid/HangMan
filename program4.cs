using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 1000;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    for (int f = 0; f < 1000; f++)
                    {
                        if (i+j+f==d)
                        {
                            if (i <j && j<f)
                            {
                                if (i*i+j*j==f*f)
                                {
                                    a = i;
                                    b = j;
                                    c = f;
                                    break;
                                }
                                
                            }
                        }
                    }
                }
            }
            Console.WriteLine(a*b*c);
            Console.WriteLine(a + "," + b + "," + c);
            /* finding pethagorian tripplets. a^2+b^2=c^2 and a<b<c and a+b+c=1000*/
        }
    }
}
