using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankProject
{
    class Akun
    {
        private int noAkun;
        public int noUser
        {
            get { return noAkun; }
            set { noAkun = value; }
        }

        protected string nama;
        protected internal string tipe;
        internal int deposit;
        private void buat_akun()
        {
            Console.Write("\n\nMasukkan Nomor Akun : ");
            noUser = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Nama pemilik Akun : ");
            nama = Console.ReadLine();
            Console.Write("Tipe Akun Pengguna (Checking/Saving) : ");
            tipe = Console.ReadLine();
            Console.Write("Masukkan Nominal Saldo (Rp) : ");
            deposit = int.Parse(Console.ReadLine());
            Console.Write("\nAkun Sudah Jadi!");
        }
        public void buatkanAkun()
        {
            buat_akun();
        }
        protected void tampilan_Akun()
        {
            Console.Write("\n\nNomor Akun : ", noUser);
            Console.Write("Nama Pemilik Akun : ", nama);
            Console.Write("Tipe Akun : ", tipe);
            Console.Write("Saldo (Rp) : ", deposit);
        }
        public void tampilkanAkun()
        {
            tampilan_Akun();
        }
        internal void edit_akun()
        {
            Console.Write("\n\nNomor Akun : {0} ", noAkun);
            Console.Write("\nUbah Nama Pemilik Akun : ");
            nama = Console.ReadLine();
            Console.Write("Ubah Tipe Akun (Checking/Saving) : ");
            tipe = Console.ReadLine();
            Console.Write("Ubah Nominal Saldo (Rp) : ");
            deposit = int.Parse(Console.ReadLine());
        }
        public void mengubahAkun()
        {
            edit_akun();
        }
        public void setorNominal()
        {
            int x;
            Console.Write("\n\nMasukkan Nominal Penyetoran (Rp) : ");
            x = int.Parse(Console.ReadLine());
            deposit += x;
        }
        public void tarikNominal()
        {
            int x;
            Console.Write("\n\nMasukkan Nominal Penarikan (Rp) : ");
            x = int.Parse(Console.ReadLine());
            deposit -= x;
        }
        public int retNoAkun()
        {
            return noAkun;
        }
        public int retDeposit()
        {
            return deposit;
        }
        public string retTipe()
        {
            return tipe;
        }
    }
}
