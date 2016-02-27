using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            int[,] a = new int[30, 30];
            int[] min = new int[10];
            int[] max = new int[10];
            Console.Write("Enter the no. of Rows of your game:  ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Enter the no. of columns of your game:  ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= r; i++)
            {

                for (int j = 1; j <=c; j++)
                {
                    Console.Write("Enter the payoff at A[{0},{1}]: ",i,j);
                    a[i, j] = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                }



            }
            Console.WriteLine("NO of payoff are......");
            Console.WriteLine("\n");
            //displaying..........
            Console.ForegroundColor = ConsoleColor.Red;


            for (int i = 1; i <= r; i++)
            {

                for (int j = 1; j <=c ; j++)
                {
                    
                    Console.Write("\t\t"+a[i,j]+"  ");

                }

                Console.WriteLine("\n");
            }

            //min form rows
            //int temp = 0;
            
            int []b=new int[10];
            for (int i = 1; i <=r; i++)
            {
                
                for (int j = 1; j <= c; j++)
			{

                b[j] = a[i, j];
            
			}

                min[i] = Program.min(b,c);
            }


            for (int i = 1; i <=r ; i++)
            {
                for (int j = 1; j <=c; j++)
                {
                    b[j] = a[j, i];
                }

                max[i] = Program.max(b, c);
            }
            
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Minimum of Rows Are:");

            for (int i = 1; i <= r; i++)
            {
                Console.Write(min[i]+",\t");
            }
            Console.WriteLine();
            Console.WriteLine("Maximum of columns Are:");

            for (int i = 1; i <= c; i++)
            {
                Console.Write(max[i] + ",\t");
            }
            Console.WriteLine();
            int minimax = Program.max(min,r);
            int maximin = Program.min(max,c);
            Console.WriteLine("\nminimax is: " + minimax);
            Console.WriteLine("\nmaximin is: " + maximin);
            if (maximin==minimax)
            {
                Console.WriteLine("\nSaddle point is: " + minimax);
            }
            else
            {
                if (maximin > minimax)
                {
                    Console.WriteLine("sadde point lies between {0} and {1}", minimax, maximin);
                    Console.WriteLine("{0} <= v <= {1}",minimax,maximin);
                }
                else
                {
                    Console.WriteLine("sadde point lies between {0} and {1}", maximin, minimax);
                    Console.WriteLine("{0} <= v <= {1}", maximin,minimax);

                }
            }


          
            Console.ReadLine();
        }

        public static int max(int[]x,int size)
        {
            int temp = x[1];
            for (int i = 2; i <=size; i++)
            {
                if (temp<=x[i])
                {
                    temp = x[i];
                }

            }

            return temp;

        }

        public static int min(int[] x, int size)
        {
            int temp = x[1];
            for (int i = 2; i <= size; i++)
            {
                if (temp >= x[i])
                {
                    temp = x[i];
                }

            }

            return temp;

        }



    }
}
