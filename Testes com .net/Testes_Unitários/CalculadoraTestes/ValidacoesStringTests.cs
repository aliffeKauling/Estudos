using Xunit;
using Calculadora.Services;

namespace CalculadoraTestes
{
public class ValidacoesStringTests
{
    private ValidacoesString _validacoes;

    public ValidacoesStringTests(){
        _validacoes = new ValidacoesString();
    }

    [Fact]
    public void DeveContar3CaracteresEmOlaERetornar3()
    {
        // Given
        string texto = "Ola";
        // When
        int resultado = _validacoes.ContarCaracteres(texto);
        // Then
        Assert.Equal(3, resultado);
    }

}

}

