using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia Lumia 920");
Smartphone nokia = new Nokia ("123456", "0000000",  "Modelo 1",  "11111111",  64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone 15  ");
Smartphone iphone = new Iphone ("252525", " 971125202",  "Modelo 2",  "22222222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");













// TODO: Realizar os testes com as classes Nokia e Iphone