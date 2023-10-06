using DesafioPOO.Models;

Nokia nokia = new Nokia("11987871313", "Nokia tijolo", "fsfdsfdsf", 64);
Iphone iphone = new Iphone("11956764323", "Iphone de botão", "879kyt", 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine();

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");