using System;
using System.Collections.Generic;
using System.IO;
using Senai.TagPet.Dominio.Classes;
using Senai.TagPet.Dominio.Interfaces;

namespace Senai.TagPet.Repositorio
{
    public class ProdutoRep : Produto, IAcao
    {
        public void Cadastrar(Produto produto){
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("produto.csv", true);
                
                sw.WriteLine(produto.Codigo + ";" + produto.Nome+ ";" + produto.DataValidade + ";" + produto.Preco);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally{
                sw.Close();
            }
        }
        public List<string> Consultar(string Texto)
        {
            throw new NotImplementedException();
        }

        public List<string> Consultar(DateTime Data)
        {
            throw new NotImplementedException();
        }
    }
}