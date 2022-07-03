using System;

namespace herancas.Cartoes;
public class CartaoVR : Cartao
{
	public CartaoVR(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
	{
	}
	public override double VerificarValorTaxaCartao()
	{
		const double taxaVR = 0.06;
		return base.saldo * taxaVR;
	}
}
