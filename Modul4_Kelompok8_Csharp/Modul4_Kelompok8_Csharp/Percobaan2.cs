using System;
namespace Modul4_Kelompok8_Csharp
{
    class Percobaan2
    {
        public void intro(int kelompok, string nama1, string nama2)
        {
            Console.WriteLine("\t\t HELLO GAES SELAMAT DATANG DI PROGRAM \n");
            Console.WriteLine("\t\t ==================================");
            Console.WriteLine("\t\t|                                  |");
            Console.WriteLine("\t\t|         RATIONALIST UTBK         |");
            Console.WriteLine("\t\t|                                  |");
            Console.WriteLine("\t\t ==================================");
            Console.WriteLine("\n\nProgram ini dibuat oleh Kelompok {0} yang beranggotakan : \n1.   {1} \n2.   {2}", kelompok, nama1, nama2);
            Console.WriteLine("\n\n");
        }
    }
}
