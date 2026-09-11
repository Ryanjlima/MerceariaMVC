using MerceariaMVC.Models;
using Xunit;

public class ClienteTests
{
    // TESTE 1
    [Fact]
    public void ClienteMenorDe18AnosDeveSerInvalido()
    {
        var cliente = new Cliente
        {
            Nome = "Lucas",
            Email = "lucas@email.com",
            Idade = 17,
            Ativo = true
        };

        var resultado = cliente.Validar();

        Assert.False(resultado);
    }

    // TESTE 2
    [Fact]
    public void ClienteComEmailInvalidoDeveSerInvalido()
    {
        var cliente = new Cliente
        {
            Nome = "Lucas",
            Email = "email-invalido",
            Idade = 20,
            Ativo = true
        };

        var resultado = cliente.Validar();

        Assert.False(resultado);
    }

    // TESTE 3
    [Fact]
    public void ClienteSemNomeDeveSerInvalido()
    {
        var cliente = new Cliente
        {
            Nome = "",
            Email = "lucas@email.com",
            Idade = 20,
            Ativo = true
        };

        var resultado = cliente.Validar();

        Assert.False(resultado);
    }

    // TESTE 4
    [Fact]
    public void ClienteInativoNaoPodeComprar()
    {
        var cliente = new Cliente
        {
            Nome = "Lucas",
            Email = "lucas@email.com",
            Idade = 20,
            Ativo = false
        };

        var resultado = cliente.PodeComprar();

        Assert.False(resultado);
    }

    // TESTE 5
    [Fact]
    public void ClienteAtivoEMaiorDeIdadePodeComprar()
    {
        var cliente = new Cliente
        {
            Nome = "Lucas",
            Email = "lucas@email.com",
            Idade = 20,
            Ativo = true
        };

        var resultado = cliente.PodeComprar();

        Assert.True(resultado);
    }

    // TESTE EXTRA 1
    [Fact]
    public void ClienteCom18AnosPodeComprar()
    {
        var cliente = new Cliente
        {
            Nome = "Lucas",
            Email = "lucas@email.com",
            Idade = 18,
            Ativo = true
        };

        var resultado = cliente.PodeComprar();

        Assert.True(resultado);
    }

    // TESTE EXTRA 2
    [Fact]
    public void ClienteComNomeApenasEspacosDeveSerInvalido()
    {
        var cliente = new Cliente
        {
            Nome = "   ",
            Email = "lucas@email.com",
            Idade = 20,
            Ativo = true
        };

        var resultado = cliente.Validar();

        Assert.False(resultado);
    }
}
