using System;
namespace Modul4_Kelompok8_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
        awal:
            Percobaan2 objek = new Percobaan2();
            objek.intro(8, "Yusuf Hawasy", "Samuel Imanta G");
            string pilihan;
            char lagi = 'Y';
            int kode_ujian, TPS1, TPS2, TPS3, TPS4;
            int fisika, matematika, biologi, kimia;
            int sejarah, ekonomi, geografi, sosiologi;
            float nilai_utbk_saintek, nilai_utbk_soshum, TPS, saintek, soshum;
            Console.WriteLine("Kode ujian pilihan UTBK = ");
            Console.WriteLine("001 = SAINTEK");
            Console.WriteLine("002 = SOSHUM");
            Console.Write("Masukan kode ujian pilihanmu = ");
            pilihan = Console.ReadLine();
            int.TryParse(pilihan, out kode_ujian);
            switch (kode_ujian)
            {
                case 1:
                    Console.Write("Masukkan nilai UTBK Saintek anda (dalam skala 0-1000!) = \n");
                    Console.Write("Masukkan nilai TPS 1 anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out TPS1);
                    Console.Write("Masukkan nilai TPS 2 anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out TPS2);
                    Console.Write("Masukkan nilai TPS 3 anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out TPS3);
                    Console.Write("Masukkan nilai TPS 4 anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out TPS4);
                    Console.Write("Masukkan nilai matematika anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out matematika);
                    Console.Write("Masukkan nilai fisika anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out fisika);
                    Console.Write("Masukkan nilai kimia anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out kimia);
                    Console.Write("Masukkan nilai biologi anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out biologi);
                    TPS = 3 * (TPS1 + TPS2 + TPS3 +TPS4) / 4;
                    saintek = 7 * (matematika + fisika + kimia + biologi) / 4;
                    nilai_utbk_saintek = (TPS + saintek) / 10;
                    if (nilai_utbk_saintek >= 1001 || nilai_utbk_saintek < 0)
                    {
                        Console.WriteLine("Maaf nilai anda tidak valid");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    else if (nilai_utbk_saintek >= 900)
                    {
                        Console.WriteLine("Selamat anda bisa masuk di Kampus J di jurusan saintek!!!");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    else if (nilai_utbk_saintek >= 800)
                    {
                        Console.WriteLine("Selamat anda bisa masuk di Kampus E di jurusan saintek!!!");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    else if (nilai_utbk_saintek >= 700)
                    {
                        Console.WriteLine("Selamat anda bisa masuk di Kampus M di jurusan saintek!!!");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    else if (nilai_utbk_saintek >= 600)
                    {
                        Console.WriteLine("Selamat anda bisa masuk di Kampus B di jurusan saintek!!!");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    else if (nilai_utbk_saintek >= 500)
                    {
                        Console.WriteLine("Selamat anda bisa masuk di Kampus U di jurusan saintek!!!");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    else if (nilai_utbk_saintek >= 400)
                    {
                        Console.WriteLine("Selamat anda bisa masuk di Kampus T di jurusan saintek!!!");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Maaf anda tidak diterima di Kampus manapun di jurusan saintek");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    break;
                case 2:
                    Console.Write("Masukkan nilai UTBK Soshum anda (dalam skala 0-1000!) = \n");
                    Console.Write("Masukkan nilai TPS 1 anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out TPS1);
                    Console.Write("Masukkan nilai TPS 2 anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out TPS2);
                    Console.Write("Masukkan nilai TPS 3 anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out TPS3);
                    Console.Write("Masukkan nilai TPS 4 anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out TPS4);
                    Console.Write("Masukkan nilai sejarah anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out sejarah);
                    Console.Write("Masukkan nilai ekonomi anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out ekonomi);
                    Console.Write("Masukkan nilai geografi anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out geografi);
                    Console.Write("Masukkan nilai sosiologi anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out sosiologi);
                    Console.Write("Masukkan nilai matematika soshum anda = ");
                    pilihan = Console.ReadLine();
                    int.TryParse(pilihan, out matematika);
                    TPS = 3 * (TPS1 + TPS2 + TPS3 + TPS4) / 4;
                    soshum = 7 * (ekonomi + sejarah + geografi + sosiologi + matematika) / 5;
                    nilai_utbk_soshum = (TPS + soshum) / 10;
                    if (nilai_utbk_soshum >= 1001 || nilai_utbk_soshum < 0)
                    {
                        Console.WriteLine("Maaf nilai anda tidak valid");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    else if (nilai_utbk_soshum >= 900)
                    {
                        Console.WriteLine("Selamat anda bisa masuk di Kampus J di jurusan soshum!!!");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    else if (nilai_utbk_soshum >= 800)
                    {
                        Console.WriteLine("Selamat anda bisa masuk di Kampus E di jurusan soshum!!!");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    else if (nilai_utbk_soshum >= 700)
                    {
                        Console.WriteLine("Selamat anda bisa masuk di Kampus M di jurusan soshum!!!");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    else if (nilai_utbk_soshum >= 600)
                    {
                        Console.WriteLine("Selamat anda bisa masuk di Kampus B di jurusan soshum!!!");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    else if (nilai_utbk_soshum >= 500)
                    {
                        Console.WriteLine("Selamat anda bisa masuk di Kampus U di jurusan soshum!!!");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    else if (nilai_utbk_soshum >= 400)
                    {
                        Console.WriteLine("Selamat anda bisa masuk di Kampus T di jurusan soshum!!!");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Maaf anda tidak diterima di Kampus manapun di jurusan soshum");
                        Console.WriteLine("Anda Ingin Mengulangi Lagi (Y/N)?");
                        pilihan = Console.ReadLine();
                        char.TryParse(pilihan, out lagi);
                        if (lagi == 'y' || lagi == 'Y')
                        {
                            Console.ReadLine();
                            goto awal;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Kode ujian yang dimasukkan salah!");
                    pilihan = Console.ReadLine();
                    char.TryParse(pilihan, out lagi);
                    if (lagi == 'y' || lagi == 'Y')
                    {
                        Console.ReadLine();
                        goto awal;
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}