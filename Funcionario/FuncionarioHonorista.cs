using System;

namespace herancas.Funcionario;
public class FuncionarioHonorista : Empregado
{
	public string cnpj { get; set; }
	public double taxa { get; set; }
	public FuncionarioHonorista(string cnpj, double taxa, int id, string nome) : base(id, nome)
	{
		this.cnpj = cnpj;
		this.taxa = taxa;
	}
	public void CalcularTaxas()
    {
        Console.WriteLine("Calculando taxas...");
    }
	public void EmitirNota()
    {
        Console.WriteLine("Emitindo nota...");
    }
}
