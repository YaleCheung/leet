using System;
using System.Collections.Generic;

namespace int2roman
{
    class Program
    {
        // look up table
        private Dictionary<int, string> _lut;
        public Program() 
        {
            _lut = new Dictionary<int, string>()
            {
                {1000, "M"}, {900, "CM"},
                {500, "D"} , {400, "CD"},
                {100, "C"} , {90, "XC"} ,
                {50,  "L"} , {40, "XL"} ,
                {10,  "X"} , {9,  "IX"} ,
                {5,   "V"} , {4,  "IV"} ,
                {1,   "I"}
            };
        }
        public string IntToRoman(int num) 
        {
            var ret = new string("");
            foreach(var item in _lut) 
            {
                while (num >= item.Key) 
                {
                    var reminder = num % item.Key;
                    var quotient = num / item.Key;
                    num -= item.Key;
                    ret += item.Value;
                }
            }
            return ret;
        }
        static void Main(string[] args)
        {
            var i = 1994;
           

            Console.WriteLine("{0}:  {1}", i, new Program().IntToRoman(i));

        }
    }
}
