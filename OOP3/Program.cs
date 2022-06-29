// See https://aka.ms/new-console-template for more information



using OOP3;
using System.Collections.Generic;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService dataBaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();


List<ILoggerService> loggers = new List<ILoggerService>() { new FileLoggerService(), new SmsLoggerService() };

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers );

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager };

// basvuruManager.KrediOnBilgilendirmeYap(krediler);



