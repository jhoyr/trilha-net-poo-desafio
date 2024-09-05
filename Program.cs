using DesafioPOO.Models;

Console.WriteLine("Smartphone iPhone:");
// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone(numero: "27999995555", modelo: "15 Pro", imei: "12354659887", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("27999995555", "15 Pro", "12354659887", 256);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
