using biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUnit
{
    public class BibliotecaTest
    {
        [Fact]
        public void AdicionarLivro()
        {
            // Arrange
            var livro = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien");

            // Act
            Biblioteca.AdicionarLivro(livro);
            var livros = Biblioteca.ObterLivros();

            // Assert
            Assert.Contains(livro, livros);
        }
    }
}
