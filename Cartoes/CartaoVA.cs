using System;

namespace herancas.Cartoes;
public class CartaoVA : Cartao
{
	public CartaoVA(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
	{
	}
    public override double VerificarValorTaxaCartao()
    {
        const double taxaVA = 0.04;
        return base.saldo * taxaVA;
    }
}
