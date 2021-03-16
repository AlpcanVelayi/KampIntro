using System;
using System.Collections.Generic;

namespace OOP3
{
    //Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); //Interfacelerde o interface'i İmplement eden classın referans numarasını tutabiliyor burada görüldüğü üzere
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() {fileLoggerService, smsLoggerService };
            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService>() {new DatabaseLoggerService(), new SmsLoggerService()  }); //burdaki gibi parantez içinde de newleyebilirsin ya da yukarıdaki gibi newleyip içine de yazabilirsin.
                                                                                       // Örnek : ILoggerService databaseLoggerService = new DatabaseLoggerService()
            basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers);                                                                           
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
