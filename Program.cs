using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Nokia A20 = new Nokia("81992041737", "Nokia-A20", "12345678910", 64);
A20.Ligar();
A20.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Iphone iphone11 = new Iphone("81997303830", "Iphone 11", "10987654321", 128);
iphone11.ReceberLigacao();
iphone11.InstalarAplicativo("iCloud");