using CPFValidation.Services;

namespace CPFValidationTests;

public class ValidacoesTest
{
private Validacoes _validacoes = new Validacoes();

    [Fact]
    public void RetornaCPFValido()
    {
        //Arrange
        var cpf = "123.456.789-09";

        //Act
        var resultado = _validacoes.ValidarCPF(cpf);

        //Assert
        Assert.True(resultado);
    }

    [Fact]
    public void RetornaCPFInvalido()
    {
        //Arrange
        var cpf = "155.282.467-60";

        //Act
        var resultado = _validacoes.ValidarCPF(cpf);

        //Assert
        Assert.False(resultado);
    }

    [Fact]
    public void RetornaCPFInvalidoQuandoTiverTodosNumerosIguais()
    {
        //Arrange
        var cpf = "111.111.111-11";

        //Act
        var resultado = _validacoes.ValidarCPF(cpf);

        //Assert
        Assert.False(resultado);
    }
}