using System;

namespace Senai.TagPet.Dominio.Classes
{
    public class Animal
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Castrado { get; set; }
        public string CodigoTagPet { get; set; }
    }
}