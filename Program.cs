using System;
using herancas.Funcionario;
using herancas.Cartoes;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        // FUNCIONARIO
        Secretaria Jorge = new Secretaria(3, 10, 1000.0, 1, "Jorge");
        Console.WriteLine("Funcionário: ");
        Console.WriteLine($"A secretaria de id {Jorge.id} e código {Jorge.codigoFuncionario} de nome {Jorge.nome} recebe um salário de R${Jorge.valorSalario}");

        // CARTÕES 
        Console.WriteLine("\nCartões: ");
        const double taxa = 0.02;
        CartaoVA va = new CartaoVA("mastercard", 100.0, taxa);
        Console.WriteLine($"Taxa do cartão VA: {va.VerificarValorTaxaCartao()}"); 
        
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

        // TRATAMENTO EXCEÇÕES
        Console.WriteLine("\nTratamento exceções: ");
        Empregado Maria = new Empregado(1, "Maria"); // null pra gritar exception

        try
        {
            ValidarEmpregado(Maria);
            MostrarEmpregado(Maria);
        }
        catch (Exception err)
        {
            Console.WriteLine(err.Message);
        }

        static void MostrarEmpregado(Empregado obj)
        {
            if (obj == null)
            {
                throw new NullReferenceException("Empregado está nulo. Informe valores");
            }
            Console.WriteLine(
                $"Nome do empregado: {obj.nome}" +
                $"\nId do empregado: {obj.id}"
                );
        }
        static void ValidarEmpregado(Empregado obj)
        {
            Regex regexLetras = new Regex("^[a-zA-Z]+$");
            Regex regexNumeros = new Regex("^[0-9]+$");

            if (!regexLetras.IsMatch(obj.nome) || !regexNumeros.IsMatch($"{obj.id}"))
            {
                throw new Exception();
            }
        }
    }
}