using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Sistema de Smartphones:");

 Iphone iphone = new Iphone("1", "iPhone 14", "123456789", 256);      
  Motorola motorola = new Motorola("2", "Moto G9", "987654321", 128);

  ConfigurarSmartphone(iphone);
  ConfigurarSmartphone(motorola);

  RealizarLigacao(iphone, motorola);

  Console.ReadLine();
}

private static void ConfigurarSmartphone(Smartphone smartphone)
{
  smartphone.Ligar();

  Console.WriteLine($"Configurando {smartphone.Modelo}");  
  
  smartphone.InstalarAplicativo("WhatsApp");
  smartphone.InstalarAplicativo("Facebook");

  Console.WriteLine("Configuração concluída!");
  Console.WriteLine();
}

private static void RealizarLigacao(Smartphone smartphone1, Smartphone smartphone2)
{
  Console.WriteLine($"{smartphone1.Modelo} fazendo ligação...");
  smartphone1.LigarPara(smartphone2);

  Console.WriteLine($"Atendendo à ligação no {smartphone2.Modelo}");      
  smartphone2.AtenderLigacao();

  Console.WriteLine("Conversando...");

  Console.WriteLine("Finalizando ligação");      
  smartphone1.EncerrarLigacao();
}
}
}