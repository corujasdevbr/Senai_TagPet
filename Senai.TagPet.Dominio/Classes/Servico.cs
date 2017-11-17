using Senai.TagPet.Dominio.Classes.Pai;

namespace Senai.TagPet.Dominio.Classes
{
    public class Servico : BaseProdutoServico
    {
        public string Duracao { get; set; }
        public string Responsavel { get; set; }

        public Servico()
        {
            
        }

        public Servico(string Duracao, string Responsavel, string Nome, decimal Preco)
        {
            this.Duracao = Duracao;
            this.Responsavel = Responsavel;
            this.Nome = Nome;
            this.Preco = Preco;
        }
    }
}