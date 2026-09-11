using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerceariaMVC.Models;

namespace MerceariaMVCTests
{
    public class ProdutoTests
    {
        [Fact]
        public void Verificar_Preco_Invalido_se_ForMenorqueZero()
        {
            var produto = new Produto
            {
                Nome = "Pacote Salada",
                Preco = 0,
                Estoque = 500
        };
            var resultado = produto.Validacao();

            Assert.False(resultado);

        }

        [Fact]
        public void Estoque_Invalido_se_Valor_MenorqueZero()
        {
            var produto = new Produto
            {
                Nome = "Muçarela",
                Preco = 45,
                Estoque = -1
            };

            var resultado = produto.Validacao();

            Assert.False(resultado);
        }
        [Fact]

        public void Verificar_Nome_Nulo_ou_Vazio_Invalido()
        {
            var produto = new Produto
            {
                Nome = "",
                Preco = 50,
                Estoque = 45
            };
            var resultado = produto.Validacao();

            Assert.False(resultado);
        }
        [Fact]
        public void Verifica_PrecoMaiorqueZero_Estoque_MaiorqueZero_NomeProdutoExistente()
        {
            var produto = new Produto
            {
                Nome = "Proteína Isolada",
                Preco = 115,
                Estoque = 50
            };

            var resultado = produto.Validacao();

            Assert.True(resultado);
        }
    }
}
