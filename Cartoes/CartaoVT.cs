using System;

namespace herancas.Cartoes;
public class CartaoVT : Cartao
{
	public CartaoVT(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
	{
	}
	public override double VerificarValorTaxaCartao()
	{
		const double taxaVT = 0.08;
		return base.saldo * taxaVT;
	}
}
