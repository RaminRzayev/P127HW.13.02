using System;

namespace P127.HW._13._02
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine(Sum(5,7,'-'));*/
            SevenNum(15);
        }
        #region Task1
        /* 1. Console app-da bir eded daxil olunur.Eger bu eded 7-ye bolunurse ekrana "7 ye bolunur" yazilsin.
         *  Eks halda daxil olunan edede en yaxin 7-ye bolunen eded ekranda yazilsin(Meselen: 17 yazilibsa ekrana  21 yox 14 cixsin)*/
        static void SevenNum(int x)
        {
            if (x%7==0)
            {
                Console.WriteLine("eded 7-e bolunur");
            }
            else
            {
                for (int i = 0; i < x; i++)
                {
                    int[] arr=new int[3];
                    int index = 0;
                    if (i%7==0)
                    { arr[index]=i;
                        index++;
                        int fin = arr.Length - 1;
                        foreach (var item in arr)
                        {
                            if (fin>item)
                            {
                                Console.WriteLine(fin);
                            }
                        }
                        
                    }
                }


            }
        }
       /* else hissesinde istedimki 7 e qaliqsiz bolunenleri bir arryin icerisine atim ve ordanda en boyuk olani goturum, amma nese alinmadi.
            ona gore birinci tapsiriq yarimciq qaldi.*/
        #endregion

        #region Task2
        /* 2. Console app-da 2 eded ve bir operator(+,-,*,/) daxil olunur.Secilen operatora uygun
            riyazi prosesin neticesini ekrana yazdiran bir algoritm yazin*/
        /*  static int Sum(int x, int y, char z)
          {
              if (z=='/')
              {
                  return x / y;
              }
              else if (z=='*')
              {
                  return x * y;
              }
              else if (z=='+')
              {
                  return x + y;
              }
              else
              {
                  return x - y;
              }


          }*/
        #endregion
    }
}
