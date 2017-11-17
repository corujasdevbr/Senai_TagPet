namespace Senai.TagPet.Dominio.Classes
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public Animal Animal { get; set; }

        public Cliente()
        {
            Endereco = new Endereco();
            Animal = new Animal();
        }

        public Cliente(string Nome, string Email, string Telefone, Endereco Endereco, Animal Animal)
        {
            this.Nome = Nome;
            this.Email = Email;
            this.Telefone = Telefone;
            this.Endereco = Endereco;
            this.Animal = Animal;
        }
    }
}