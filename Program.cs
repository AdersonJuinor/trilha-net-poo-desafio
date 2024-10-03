using DesafioPOO.Models;

Smartphone ipho = new Iphone(numero: "48988123456", modelo: "18.9", imei: "01011001", memoria: 500);
Smartphone nok = new Nokia(numero: "48988756753", modelo: "5.1", imei: "101010101", memoria: 260);


Console.WriteLine("                                 NOKIA                                      ");
nok.Ligar();
//Abaixo esta as informações do celular que vai receber a ligação
Console.WriteLine("------------------------");
Console.WriteLine("|Numero: " + ipho.Numero +"   |");
Console.WriteLine("|----------------------|");
Console.WriteLine("|Modelo: " + ipho.Modelo +"          |");
Console.WriteLine("|----------------------|");
Console.WriteLine("|IMEI: " + ipho.IMEI +"        |");
Console.WriteLine("|----------------------|");
Console.WriteLine("|Memoria: " + ipho.Memoria +"          |");
Console.WriteLine("------------------------");
nok.InstalarAplicativo("WhatsAPP");

Console.WriteLine("");

Console.WriteLine("                                  IPHONE                                      ");
ipho.ReceberLigacao();
//Abaixo esta as informações do celular que esta ligando
Console.WriteLine("------------------------");
Console.WriteLine("|Numero: " + nok.Numero +"   |");
Console.WriteLine("|----------------------|");
Console.WriteLine("|Modelo: " + nok.Modelo +"           |");
Console.WriteLine("|----------------------|");
Console.WriteLine("|IMEI: " + nok.IMEI + "       |");
Console.WriteLine("|----------------------|");
Console.WriteLine("|Memoria: " + nok.Memoria +"          |");
Console.WriteLine("------------------------");
ipho.InstalarAplicativo("Telegram");