public override void InstalarAplicativo(string nomeApp) 
{
  Console.WriteLine($"Instalando aplicativo: {nomeApp} via AppStore no Iphone");
  
  // Simula requisição HTTP para App Store
  SimularRequisicaoAppStore();
}

private void SimularRequisicaoAppStore()
{
  Console.WriteLine("Fazendo requisição para a App Store...");
  
  // Simular tempo para conexão e download
  System.Threading.Thread.Sleep(3000);  

  Console.WriteLine("Aplicativo instalado com sucesso!");
}

public void AbrirApp(string nomeApp)
{
  Console.WriteLine($"Abrindo aplicativo {nomeApp} no Iphone");

  // Simular tempo para abrir app
  System.Threading.Thread.Sleep(1000);
  
  Console.WriteLine("App aberto!");
}
