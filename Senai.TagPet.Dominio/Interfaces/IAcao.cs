using System;
using System.Collections.Generic;

namespace Senai.TagPet.Dominio.Interfaces
{
    public interface IAcao
    {   
         
        List<string> Consultar(string Texto);
        List<string> Listar();
    }
}