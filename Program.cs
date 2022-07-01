using System;
using herancas.Funcionario;
using herancas.Cartoes;

internal class Program
{
    static void Main(string[] args)
    {
        Secretaria Jorge = new Secretaria(3, 10, 1000.0, 1, "Jorge");
        Console.WriteLine($"A secretaria de id {Jorge.id} e código {Jorge.codigoFuncionario} de nome {Jorge.nome} recebe um salário de R${Jorge.valorSalario}");

        const double taxa = 0.02;
        CartaoVA va = new CartaoVA("mastercard", 100.0, taxa);
        Console.WriteLine($"Taxa do cartão: {va.VerificarValorTaxaCartao()}"); 
        
        // upcasting
        Cartao cartao = va;
        if (cartao is CartaoVA)
        {
            CartaoVA cartaoDowncasting = (CartaoVA)cartao;
            Console.WriteLine("Downcasting de Cartão para CartãoVA completo");
        }
        else
        {
            Console.WriteLine("Downcasting inválido");
        }
    }
}