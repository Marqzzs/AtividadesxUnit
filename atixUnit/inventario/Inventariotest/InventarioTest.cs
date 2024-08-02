using Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventariotest
{
    public class InventarioTest
    {
        [Fact]
        public void AdicionarProduto_NovoProduto_ProdutoAdicionado()
        {
            // Arrange
            string nome = "ProdutoA";
            int quantidade = 10;

            // Act
            Inventory.AdicionarProduto(nome, quantidade);

            // Assert
            Assert.Equal(quantidade, Inventory.ObterQuantidade(nome));
        }

        [Fact]
        public void AdicionarProduto_ProdutoExistente_QuantidadeIncrementada()
        {
            // Arrange
            string nome = "ProdutoA";
            int quantidadeInicial = 10;
            int quantidadeAdicionar = 5;
            Inventory.AdicionarProduto(nome, quantidadeInicial);

            // Act
            Inventory.AdicionarProduto(nome, quantidadeAdicionar);

            // Assert
            Assert.Equal(quantidadeInicial + quantidadeAdicionar, Inventory.ObterQuantidade(nome));
        }

        [Fact]
        public void ObterQuantidade_ProdutoNaoExistente_RetornaZero()
        {
            // Act
            int quantidade = Inventory.ObterQuantidade("ProdutoNaoExistente");

            // Assert
            Assert.Equal(0, quantidade);
        }
    }
}
