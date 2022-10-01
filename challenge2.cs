using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace allan_challenge1
{
	//5210411383_ALLAN BIL FAQIH
    public class challenge1_odd_even
    {
		//Challange 1 | Code for ODD or EVEN Number
        public static void Main(string[] args)
        {
			int qq = 0;
			Console.Write("OUTPUT : Hai ");
			qq = display(5,9);
			Console.Write(qq);
			Console.ReadLine();
        }
		public static int display(int aa, int bb){
			int pp = 3;
			for (int i = aa; i <= bb; i++){
				pp = pp + i;
			}
			return pp;
		}
    }
}