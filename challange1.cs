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
            Console.WriteLine("Masukkan Nomor :");
			string nomor1 = Console.ReadLine();
			bool gg = Convert.ToInt32(nomor1) % 2 == 0;
			string hasil = "";
			if (gg == true){
				hasil = "Genap";
			}
			else{
				hasil = "Ganjil";
			}
			Console.WriteLine("Nomornya adalah " + nomor1 + " dan itu sebuah Nomor " + hasil);
			Console.ReadLine();
        }
    }
}