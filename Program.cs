using System;

namespace Automation3CardGame
{
    class Program
    {
        private const int x = 2;
        private const int y = 2;
        private static readonly int[,] sampleArr = new int[2, 2] { { 1, 2 }, { 0, 3 } };

        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2] { { 0, 3 }, { 2, 1 } };

            
            int cons = EvaluatePosition(arr);
            Console.WriteLine(cons);

            //var conss = FindPos(arr,3);
            //Console.WriteLine(conss.X);
            //Console.WriteLine(conss.Y);
        }

        static void go(int[,] arr)
        {
            Pos bestSwap = new Pos(0, 0);

       
        }

      
        static int EvaluatePosition(int [,] arr)
        {
            int val = 0;
            for(var i=0;i<x;i++)
            {
                for(var j=0;j<y;j++)
                {
                    if (arr[i, j] == 0) continue;
                    var initialPos = FindPos(sampleArr, arr[i, j]);
                    int xDifference = initialPos.X - i;
                    int yDifference = initialPos.Y - j;
                    if (xDifference < 0) xDifference *= -1;
                    if (yDifference < 0) yDifference *= -1;
                    val += xDifference;
                    val += yDifference;
                }
            }
            return val;
        }

        static Pos FindPos(int[,] arr,int val)
        {
            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    if (arr[i, j] == val) return new Pos(i, j);
                }
            }
            return null;
        }

        static void Print(int[,] arr)
        {
            for (var i=0;i<x;i++)
            {
                for(var j=0;j<y;j++)
                    Console.Write(arr[i,j] + " ");
                Console.WriteLine();
            }
        }
    }
}
