using System;

namespace herancas.Funcionario;
public class Secretaria : SalarioEmpregado
{
	public int qtdAnosEmpresa { get; set; }
	public Secretaria(int qtdAnosEmpresa, int codigoFuncionario, double valorSalario, int id, string nome) : base(codigoFuncionario, valorSalario, id, nome) 
	{
		this.qtdAnosEmpresa = qtdAnosEmpresa;
	}
	public void AtenderCliente()
    {
        Console.WriteLine("Cliente sendo atendido");
    }
	public void RealizarLigações()
    {
        Console.WriteLine("Realizando ligações");
    }
}
