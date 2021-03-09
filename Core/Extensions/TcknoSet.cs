using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Extensions
{
   public class TcknoSet
    {
        private readonly Random _random = new Random();

        public string  SetSingId()
        {
            int[] TcArr = new int[11];
           
            for (int i = 0; i < 9; i++)
            {
                if (i==0)
                {
                    TcArr[i]=_random.Next(1, 9);
                }
                else
                {
                    TcArr[i]=_random.Next(0, 9);
                }
            }
            Thread.Sleep(1000);
            TcArr[9] = Calc10Number(TcArr);
            Thread.Sleep(1000);
            TcArr[10]= TcArr.Sum() % 10;

            return string.Join(string.Empty, TcArr); ;
        }

        /// <summary>
        ///  SingleId'nin 10.nuncu değerini hesaplıyoruz.
        /// </summary>
        /// <returns></returns>
        private int Calc10Number(int[] arr)
        {
            List<int> oddValue = new List<int>(); //tek
            List<int> evenValue = new List<int>(); //cift


            for (int i = 0; i < arr.Length; i++)
            {
                //index değerlerinde çift olan index aslında bizim tek olan değerlerimiz oluyor
                if (i % 2 == 0)
                {
                    oddValue.Add(arr[i]);
                    //toplamının 7 katı alınacak
                }
                else
                {
                    evenValue.Add(arr[i]);
                    // toplamları
                    
                }
            }

            return  ((oddValue.Sum()*7)-evenValue.Sum())%10;
        }
    }
}
