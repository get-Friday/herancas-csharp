using System;
using herancas.Funcionario;

internal class Program
{
    static void Main(string[] args)
    {
        Secretaria Jorge = new Secretaria(3, 10, 1000.0, 1, "Jorge");
        Console.WriteLine($"O funcionário de id {Jorge.id} e código {Jorge.codigoFuncionario} de nome {Jorge.nome} recebe um salário de R${Jorge.valorSalario}");
    }
}