namespace DesafioPOO.Models
{
public abstract class Smartphone
{
public string Numero { get; set; }
public string Modelo { get; set; }
public string IMEI { get; set; }
public int Memoria { get; set; }


public Smartphone(string numero, string modelo, string imei, int memoria)
{
  Numero = numero;
  Modelo = modelo;  
  IMEI = imei;
  Memoria = memoria;
}

protected Smartphone(string numero) 
{
  Numero = numero;
}

public void Ligar()
{
  Console.WriteLine("Ligando...");
  SimularLigacao();
}

private void SimularLigacao()
{
  System.Threading.Thread.Sleep(1000);  
  Console.WriteLine("Pronto para usar!");
}

public void ReceberLigacao()
{
  Console.WriteLine("Recebendo ligação...");
  SimularAtendimento();
}

private void SimularAtendimento()
{
  System.Threading.Thread.Sleep(2000);
  Console.WriteLine("Ligação atendida!");
}

public abstract void InstalarAplicativo(string nomeApp);
}
}