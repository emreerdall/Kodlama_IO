using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(134, "Tolga Demirer");
            Ogrenci.Add(158, "Ümit Özkan");
            Ogrenci.Add(115, "Kadir Aydemir");
            Ogrenci.Add(174, "Cemal Çiftçi");
            Console.WriteLine($"{Ogrenci.Count} adet öğrenci kaydı vardır.");
            Console.Write("Öğrenci No Giriniz:");

            int No = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Ogrenci[No]);
            }
            catch
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }

            Console.WriteLine("\n*************** My Dictionary ***************");

            MyDict<string, int> student = new MyDict<string, int>();
            student.Add("Emre", 85);
            student.Add("Hasan", 90);
            student.Add("Ayşe", 70);
            Console.WriteLine($"{student.Count} adet öğrenci kaydı vardır.");

            Console.Write("Öğrenci Adını Giriniz: ");
            string name = Console.ReadLine();

            try
            {
                Console.WriteLine($"Öğrencinin aldığı not {student.key(name)}");
            }
            catch
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }

            Console.ReadKey();
        }
    }
}
