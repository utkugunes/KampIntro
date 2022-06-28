// See https://aka.ms/new-console-template for more information


using OOP3;
using System.Collections.Generic;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

IKrediManager tasitKrediManager = new TasitKrediManager();

IKrediManager konutKrediManager = new KonutKrediManager();


BasvuruManager basvuruManager = new BasvuruManager();

// basvuruManager.BasvuruYap(tasitKrediManager);

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager };

basvuruManager.KrediOnBilgilendirmeYap(krediler);






