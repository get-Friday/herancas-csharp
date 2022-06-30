using System;

namespace herancas.Funcionario;
public class Empregado
{
	public int id { get; set; }
	public string nome { get; set; }
	public Empregado(int id, string nome)
	{
		this.id = id;
		this.nome = nome;
	}
	public void Trabalhar()
	{
        Console.WriteLine("Trabalhando...");
	}
	public void IrEmbora()
	{
        Console.WriteLine("Indo embora...");
	}
	public void TirarFolgar()
	{
        Console.WriteLine("Tirando folga...");
	}
}
