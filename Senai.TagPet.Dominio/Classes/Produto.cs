using System;
using Senai.TagPet.Dominio.Classes.Pai;

namespace Senai.TagPet.Dominio.Classes
{
    public class Produto : BaseProdutoServico
    {
        public DateTime DataValidade { get; set; }
        public string Estoque { get; set; }

        public Produto()
        {
            
        }

        public Produto(DateTime DataValidade, string Estoque, string Nome, decimal Preco)
        {
            this.DataValidade = DataValidade;
            this.Estoque = Estoque;
            this.Nome = Nome;
            this.Preco = Preco;
        }
    }
}