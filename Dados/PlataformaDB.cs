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
    public class PlataformaDB
    {
        private Conexao conexao;

        public List<Plataforma> All()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT IdPlataforma , Descricao FROM TB_PLATAFORMA";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Plataforma> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listPlataforma = new List<Plataforma>();

            while (retorno.Read())
            {
                var item = new Plataforma()
                {
                    IdPlataforma = Convert.ToInt32(retorno["IdPlataforma"]),
                    Descricao = retorno["Descricao"].ToString()
                };

                listPlataforma.Add(item);
            }

             return listPlataforma;
        }
    }
}
