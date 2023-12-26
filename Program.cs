using DesafioPOO.Models;

// Realizando os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "123456", modelo: "N900", imei: "111111111111111", memoria: 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("NetStumbler");

Console.WriteLine("----------------------------------------------------------");

Console.WriteLine("Smartphone IPhone:");
Iphone iphone = new Iphone(numero: "654321", modelo: "14 Pro Max", imei: "222222222222222", memoria: 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Pythonista");