using System;

namespace herancas.Cartoes;
public class Cartao
{
    public string bandeira { get; set; }
    public double saldo { get; set; }
    public double valorTaxa { get; set; }
    public Cartao(string bandeira, double saldo, double valorTaxa)
    {
        this.bandeira = bandeira;
        this.saldo = saldo;
        this.valorTaxa = valorTaxa;
	}
    public virtual double VerificarValorTaxaCartao()
    { 
        return saldo * valorTaxa;
    }
}
