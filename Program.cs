using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new(numero: "999999999", modelo: "G11", imei: "123456789", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Discord");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new(numero: "999999999", modelo: "15 Pro", imei: "987654321", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
