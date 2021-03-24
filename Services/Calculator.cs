using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Services
{
    public static class Calculator
    {
        //====================
        //  足し算
        //====================
        public static int Addition(int Number1, int Number2)
        {
            return Number1 + Number2;
        }

        //====================
        //  引き算
        //====================
        public static int Subtraction(int Number1, int Number2)
        {
            return Number1 - Number2;
        }

        //====================
        //  掛け算
        //====================
        public static int Multiplication(int Number1, int Number2)
        {
            return Number1 * Number2;
        }

        //====================
        //  割り算
        //====================
        public static int Divition(int Number1, int Number2)
        {
            return Number1 / Number2;
        }
    }
}
