using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    struct data
    {
        private void intro()
        {
            Console.Write("Bank Management System");
            Console.Write("\n========================");
        }
        public void showintro()
        {
            intro();
        }
        internal void load()
        {
            Console.Write("Loading....");
            for(int i = 0; i < 2; i++)
            {
                Console.Write("\nPlease Wait...");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
