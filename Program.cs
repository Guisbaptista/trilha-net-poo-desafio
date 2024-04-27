using DesafioPOO.Models;

console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123123", modelo: "modelo 1", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

console.WriteLine("\n");

console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "123123", modelo: "modelo 1", imei: "11111111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("whatsapp");
