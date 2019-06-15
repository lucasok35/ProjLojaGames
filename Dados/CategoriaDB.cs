using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Dados
{
    public class CategoriaDB
    {
        private Conexao conexao;

        public List<Categoria> All()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT IdCategoria, Descricao FROM TB_CATEGORIA";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Categoria> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listCategoria = new List<Categoria>();

            while (retorno.Read())
            {
                var item = new Categoria()
                {
                    IdCategoria = Convert.ToInt32(retorno["IdCategoria"]),
                    Descricao = retorno["Descricao"].ToString()
                };

                listCategoria.Add(item);

            }

            return listCategoria;
        }
    }

}
