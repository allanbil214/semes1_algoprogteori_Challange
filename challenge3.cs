using System;
using System.Collections.Generic;

namespace allan_challenge1
{
	//5210411383_ALLAN BIL FAQIH
    public class challenge1_odd_even
    {
		//Challange 1 | Code for ODD or EVEN Number
        public static void Main(string[] args)
        {
			Console.WriteLine("Pilih Aritmatika :");
            Console.WriteLine("Tekan 1 untuk +");  
            Console.WriteLine("Tekan 2 untuk -");  
            Console.WriteLine("Tekan 3 untuk X");  
            Console.WriteLine("Tekan 4 untuk /");  
			string aritmatika = Console.ReadLine();
			Console.WriteLine("Masukkan Nomor Pertama:");
			string nomor1 = Console.ReadLine();
			Console.WriteLine("Masukkan Nomor Kedua:");
			string nomor2 = Console.ReadLine();
			int hasil = 0;
			if (aritmatika == "1") {
				hasil = Convert.ToInt32(nomor1) + Convert.ToInt32(nomor2);
				Console.WriteLine("Hasilnya : " + hasil);
			}
			else if (aritmatika == "2") {
				hasil = Convert.ToInt32(nomor1) - Convert.ToInt32(nomor2);
			Console.WriteLine("Hasilnya : " + hasil);
			}
			else if (aritmatika == "3") {
				hasil = Convert.ToInt32(nomor1) * Convert.ToInt32(nomor2);
			Console.WriteLine("Hasilnya : " + hasil);
			}
			else if (aritmatika == "4") {
				hasil = Convert.ToInt32(nomor1) / Convert.ToInt32(nomor2);
			Console.WriteLine("Hasilnya : " + Convert.ToDouble(hasil));
			}			
			Console.ReadLine();
        }
    }
}