using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maslab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,M,K,result=0;
            int[] arr= new int[2]; int[,] seat;

            Console.Write("Введите число N рядов и M мест: ");
            arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            N = arr[0]; M = arr[1];
            seat = new int[N,M];

            arr = new int[M];
            for (int i = 0; i< N; i++) 
            {
                arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < M; j++) seat[i, j] = arr[j];
            }

            Console.Write("Введите число искомых К свободных мест подряд в ряду: ");
            K = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" --------------------------------------------------- ");


            for (int i=0;i<N;i++) 
            {
                int num = 0,maxnum=0; bool inrow = false;
                for (int j = 0; j < M; j++) 
                {
                    if (seat[i, j] == 0) { inrow = true; num++; }
                    else { inrow = false; maxnum = num; num = 0; }
                }
                if(inrow == true)maxnum = num;
                if (maxnum >= K && result==0) result = i+1;
            }

             Console.WriteLine("Первый подходящий ряд: {0}", result);
            

        }
    }
}
