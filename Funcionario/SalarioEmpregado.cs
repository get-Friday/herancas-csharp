using System;

namespace herancas.Funcionario;
public class SalarioEmpregado : Empregado
{
	public int codigoFuncionario { get; set; }
	public double valorSalario { get; set; }
	public SalarioEmpregado(int codigoFuncionario, double valorSalario, int id, string nome) : base(id, nome)
	{
		this.codigoFuncionario = codigoFuncionario;
		this.valorSalario = valorSalario;
	}
	public void CalcularFolhaPagamento()
    {
    }
}
