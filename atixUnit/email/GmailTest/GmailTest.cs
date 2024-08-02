using Gmail;
using Xunit;

namespace GmailTest
{
    public class GmailTest
    {
        [Theory]
        [InlineData("email@dominio.com", true)]
        [InlineData("email@dominio", false)]
        [InlineData("email.com", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("email@dominio.com.br", true)]
        public void EmailTest(string email, bool resultadoEsperado)
        {
            // Act
            var resultado = Email.ValidarEmail(email);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
