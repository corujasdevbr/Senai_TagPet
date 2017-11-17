using System;
using System.Collections.Generic;

namespace Senai.TagPet.Dominio.Interfaces
{
    public interface IAcao
    {
         bool Cadastrar();
         List<string> Consultar(string Texto);
         List<string> Consultar(DateTime Data);
    }
}