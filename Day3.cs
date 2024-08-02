using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class arrays
    {
        static void Main2(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] result=new int[2, 2];
            for (int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.WriteLine("position is:"+"a"+"["+i+","+j+"]");  
                    a[i,j]= Convert.ToInt16(Console.ReadLine());
                }
                
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("position is:" + "b" + "[" + i + "," + j + "]");
                    b[i, j] = Convert.ToInt16(Console.ReadLine());
                }

            }
            Console.WriteLine("a matrix is" +"\n");
            for(int i = 0;i < 2; i++)
            {
                  
                for (int j = 0; j <2; j++)

                {
                    Console.Write(a[i, j]+"\t");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("b matrix is" + "\n");
            for (int i = 0; i < 2; i++)
            {
                
                for (int j = 0; j < 2; j++)

                {
                    Console.Write(b[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("a+b matrix is result" + "\n");
            {
                for(int i = 0;i< 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        result[i, j] = a[i, j] + b[i, j];
                        //Console.Write(result[i, j]+" ");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < 2; i++)
                {
                    
                    for (int j = 0; j < 2; j++)

                    {
                        Console.Write(result[i, j] + "\t");

                    }
                    Console.WriteLine();
                }

            }

        }
            
    }
}
