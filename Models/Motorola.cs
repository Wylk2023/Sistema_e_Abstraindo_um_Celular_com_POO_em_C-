namespace DesafioPOO.Models
{
public class Motorola : Smartphone
{
public Motorola(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
{
}

public override void InstalarAplicativo(string nomeApp)
{
  Console.WriteLine($"Instalando aplicativo: {nomeApp} via PlayStore no Motorola");

  SimularRequisicaoPlayStore();
}

private void SimularRequisicaoPlayStore()
{
  Console.WriteLine("Fazendo requisição para o Google Play Store...");
  
  System.Threading.Thread.Sleep(2000);

  Console.WriteLine("Aplicativo instalado com sucesso!");
}

public void AbrirApp(string nomeApp)
{
  Console.WriteLine($"Abrindo aplicativo {nomeApp} no Motorola");

  System.Threading.Thread.Sleep(1000);

  Console.WriteLine("App aberto!");
}

public void AbrirGoogleAssistente()
{
  Console.WriteLine("Invocando o Google Assistente...");

  System.Threading.Thread.Sleep(2000);

  Console.WriteLine("Olá, em que posso ajudar?");
}
}
}