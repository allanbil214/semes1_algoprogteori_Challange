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
			Console.WriteLine("Pilih Kurs :");
            Console.WriteLine("Tekan 1 untuk $ (dollar)");  
            Console.WriteLine("Tekan 2 untuk € (euro)");  
            Console.WriteLine("Tekan 3 untuk Rp. (rupiah)");    
			string kurs = Console.ReadLine();
			Console.WriteLine("Masukkan Nomor Pertama:");
			string nomor1 = Console.ReadLine();
			if (kurs == "1") {
				Console.WriteLine("Yang Akan Dikonversikan : " + nomor1 + "$ (dollar)");
			}
			else if (kurs == "2") {
				Console.WriteLine("Yang Akan Dikonversikan : " + nomor1 + "€ (euro)");
			}
			else if (kurs == "3") {
				Console.WriteLine("Yang Akan Dikonversikan : " + "Rp." + nomor1 + " (rupiah)");
			}	
			Console.WriteLine("Pilih Konversi :");
            Console.WriteLine("Tekan 1 untuk $ (dollar)");  
            Console.WriteLine("Tekan 2 untuk E (euro)");  
            Console.WriteLine("Tekan 3 untuk Rp. (rupiah)");    
			string konversi = Console.ReadLine();
			if (konversi == "1" && kurs != "1") {
				Console.WriteLine("Yang Akan Dikonversikan : " + nomor1 + "$ (dollar)");
			}
			else if (konversi == "2" && kurs != "2") {
				Console.WriteLine("Yang Akan Dikonversikan : " + nomor1 + "€ (euro)");
			}
			else if (konversi == "3" && kurs != "3") {
				Console.WriteLine("Yang Akan Dikonversikan : " + "Rp." + nomor1 + " (rupiah)");
			}	
			else{
				Console.WriteLine("Tidak bisa Dikonversi karena Kurs sudah sama");
			}
			Console.ReadLine();
        }
    }
}