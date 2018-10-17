using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //作者:林紘毅
    //日期:107/10/17
    //專案:秒數轉換器

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("請輸入秒數:");
                int sec = int.Parse(Console.ReadLine());

                if (sec >= 86400)
                {
                    Console.WriteLine(sec.ToString() + "秒 = " + (sec / 86400.0).ToString() + "日");
                }
                else if (sec >= 3600)
                {
                    Console.WriteLine(sec.ToString() + "秒 = " + (sec / 3600.0).ToString() + "小時");
                }
                else if (sec >= 60)
                {
                    Console.WriteLine(sec.ToString() + "秒 = " + (sec / 60.0).ToString() + "分");
                }
                else if (sec > 0)
                {
                    Console.WriteLine(sec.ToString() + "秒 = " + sec.ToString() + "秒");
                }
                else
                {
                    Console.WriteLine("請輸入正整數");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
