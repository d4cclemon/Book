using ConsoleApp.Constants;
using ConsoleApp.Services;
using System;

namespace ConsoleApp
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("入力してください");
            try
            {
                Sample1();
            }
            catch(Exception ex)
            {
                Console.WriteLine("エラーが発生しました。内容をご確認ください。");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.ReadKey();
                Console.WriteLine("プログラムを終了します。");
            }

        }

        private static void Sample1()
        {
            var param = Console.ReadLine().Split();

            int num1, num2;
            int.TryParse(param[0], out num1);
            int.TryParse(param[2], out num2);

            Console.WriteLine($"結果：{GetResult(num1, num2, param[1])}");
            return;
        }

        private static int GetResult(int num1, int num2, string symbol)
        {
            switch (symbol)
            {
                case Constant.plus:
                    return Calculator.Addition(num1, num2);
                case Constant.minus:
                    return Calculator.Subtraction(num1, num2);
                case Constant.asterisk:
                    return Calculator.Multiplication(num1, num2);
                case Constant.slash:
                    return Calculator.Divition(num1, num2);
                default:
                    return -1;
            }
        }
    }
}
