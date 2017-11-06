using System;
using ConsoleAppMail;

namespace ConsoleAppMail
{
    class Program
    {
        static void Main(string[] args)
        {
            MailClient mail = new MailClient();
            mail.SendEmail("domagoj.persic@vsmti.hr", "Proba", "Ovo nije u redu od tebe");
            Console.ReadKey();
        }
    }
}
