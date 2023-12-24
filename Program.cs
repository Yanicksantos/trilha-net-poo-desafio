using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");

Smartphone smartphoneNokia = new Nokia (numero:"279815357637", modelo:"Nokia 8.3 5G", imei:"111112244424", memoria:128);

smartphoneNokia.Ligar();
smartphoneNokia.InstalarAplicativo("Discord");
smartphoneNokia.ReceberLigacao ();
Console.WriteLine($"Detalhes do smartphone: {smartphoneNokia}");

Console.WriteLine("\n\nSmartphone Iphone: ");

Smartphone smartphoneIphone = new Nokia (numero:"279815357637", modelo:"iPhone 13 mini", imei:"2222112244424", memoria:64);

smartphoneIphone.Ligar();
smartphoneIphone.InstalarAplicativo("Instagram");
smartphoneIphone.ReceberLigacao ();
Console.WriteLine($"Detalhes do smartphone: {smartphoneIphone}");