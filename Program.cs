using System;
namespace AA
{
    class AA
    {
        static void Main()
        {
            for (int i = 0; i < 5;)
            {
                int n;
                int l;
                Console.WriteLine("Enter  num1 ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter  num2");
                int z = int.Parse(Console.ReadLine());
                if (z > x && x > 0 && z > 0)
                   
                {
                    
                    while (x<=z)
                    {
                        int y = x - 2;
                        n = 0;
                        for(int j=2; j<x; j++)
                        {
                            if (!(x%j==0))
                            {
                                n += 1;

                            }
                            
                        }
                        if (n == y)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine(x);
                        }



                        ++x;
                    }
                }
                else
                    Console.WriteLine("incrroct input\n" +
                        "Please ensure that:\n" +
                        "1/num1 and num2 are positive \n" +
                        "2/num2 is bigger than num1\n");
            }
        }
    }
}