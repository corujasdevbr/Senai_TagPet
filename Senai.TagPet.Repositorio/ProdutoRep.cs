using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Senai.TagPet.Dominio.Classes;
using Senai.TagPet.Dominio.Interfaces;

namespace Senai.TagPet.Repositorio
{
    /// <summary>
    /// Classe com os metodos do Produto
    /// </summary>
    public class ProdutoRep : Produto, IAcao
    {
        /// <summary>
        /// Cadastra um novo produto
        /// </summary>
        /// <param name="produto">Parametro de entrada do tipo Produto</param>
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

        /// <summary>
        /// Consulta um produto pelo código
        /// </summary>
        /// <param name="Texto">Parametro que contem o código do produto</param>
        /// <returns>Retorna uma lista de string</returns>
        public List<string> Consultar(string Texto)
        {
            List<string> resultado = null;
            
            StreamReader ler = null;
            try{
                ler = new StreamReader("produto.csv",Encoding.Default);
                string linha = "";
                while((linha=ler.ReadLine())!=null){
                    string[] dados = linha.Split(';');
                    if(dados[0].ToUpper()==Texto.ToUpper()){
                        if(resultado == null)
                            resultado = new List<string>();

                        resultado.Add(linha);
                    }
                }
            }
            catch(Exception ex){
                throw new Exception("Erro ao tentar ler o arquivo. "+ex.Message);
            }   
            finally{
                ler.Close();
            }
            return resultado;
        }

        /// <summary>
        /// Retorna todos os produtos cadastrados
        /// </summary>
        /// <returns>Retorna uma lista de strings com os produtos</returns>
        public List<string> Listar()
        {
            List<string> resultado = null;
            
            StreamReader ler = null;
            try{
                ler = new StreamReader("produto.csv",Encoding.Default);
                string linha = "";
                while((linha=ler.ReadLine())!=null){
                    if(resultado == null)
                        resultado = new List<string>();

                    resultado.Add(linha);
                }
            }
            catch(Exception ex){
                throw new Exception("Erro ao tentar ler o arquivo. "+ex.Message);
            }   
            finally{
                ler.Close();
            }
            return resultado;
        }
    }
}