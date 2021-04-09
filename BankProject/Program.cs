using System;

namespace BankProject
{
    class Program: Akun
    {
        static void Main(string[] args)
        {
            int n;
            data show = new data();
            Akun bank = new Akun();
            show.load();
            Console.Clear();
            show.showintro();

            do
            {
                Console.Write("\n\n\t Main Menu");
                Console.Write("\n(1) Buat Akun Baru");
                Console.Write("\n(2) Penyetoran Saldo");
                Console.Write("\n(3) Penarikan Saldo");
                Console.Write("\n(4) Informasi Akun");
                Console.Write("\n(5) Edit Akun");
                Console.Write("\n(6) Keluar");
                Console.Write("\n\nPilih Salah Satu Opsi : ");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        {
                            Console.Clear();
                            show.load();
                            bank.buatkanAkun();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            show.load();
                            bank.setorNominal();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            show.load();
                            bank.tarikNominal();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            show.load();
                            bank.tampilkanAkun();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            show.load();
                            bank.mengubahAkun();
                            break;
                        }
                }
            } while (n != 6);
        }
    }
}
