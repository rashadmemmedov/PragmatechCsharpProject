﻿using System;

namespace Mini_login_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
             * Username ve password deye deyisenler teyin edin.
             *
             *  Username : admin
             *  Password : 6gH123
             *
             * Istifadeciden  username ve Password daxil etmesini isteyin.
             *
             * Daxil edilen username ve passwordun teyin edilen
             * deyisenlerin deyerine beraber olub olmamasini yoxlayin,
             *
             * Netice olaraq login emeliyyatinin ugurlu ve ya
             *
             *  daxil edilen username ve ya sifrenin dogru olmadigi mesajini verin.
             *
             * ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
             *  qeyd: eyni taski, if, ternary operator ve switch ile yazin
             *
             */
            #endregion
            #region
            while (true)
            {
                Console.WriteLine("Istifadeci adini daxil edin :");
                string userName = Console.ReadLine();
                Console.WriteLine("Sifrenizi  daxil edin :");
                string password = Console.ReadLine();
                bool True = userName == "admin" && password == "6gH123";
                switch (True)
                {
                    case true:
                        Console.WriteLine("welcome to Page again");
                    break;
                    default:
                        Console.WriteLine("istifadeci adi ve ya sifre dogru deyil");
                    break;
                }
            }
            #endregion
        }
    }
}
