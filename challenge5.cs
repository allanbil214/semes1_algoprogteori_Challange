using System;
using System.Collections.Generic;
using System.Linq;

namespace allan_challenge1
{
	//5210411383_ALLAN BIL FAQIH
    public class challenge1_odd_even
    {
		//Challange 1 | Code for ODD or EVEN Number
        public static void Main(string[] args)
        {
			Console.WriteLine("Masukkan Sesuatu:");
			string tulisan = Console.ReadLine();
			bool apakah = tulisan.Any(char.IsDigit);
			if (apakah == true){
				Console.WriteLine(tulisan + " Ada nomornya");
			}
			else{
				Console.WriteLine(tulisan + " Tidak ada nomornya");				
			}
			Console.ReadLine();
        }
    }
}