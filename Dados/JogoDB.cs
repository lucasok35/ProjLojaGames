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
    public class JogoDB
    {
        private Conexao conexao;

        #region Métodos
            
        public bool Insert(Jogo jogo)
        {
            try
            {
                string sql = string.Format("insert into tb_jogo " +
                    "(titulo, fabricante, faixaetaria, idplataforma, idcategoria ) values " +
                    "('{0}', '{1}', '{2}', '{3}', '{4}')", jogo.Titulo, jogo.Fabricante, jogo.FaixaEtaria, jogo.plataforma.IdPlataforma,
                    jogo.categoria.IdCategoria);

                using (conexao = new Conexao())
                {
                    conexao.ExecutaComando(sql);
                }

                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Jogo> All()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT J.Idjogo, J.Titulo, J.Fabricante, J.FaixaEtaria, P.Descricao, C.Descricao " +
                    "FROM TB_JOGO J, TB_PLATAFORMA P, TB_CATEGORIA C WHERE" +
                    " J.IdPlataforma = P.IdPlataforma AND J.IdCategoria = C.IdCategoria ";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);

            }
        }

        private List<Jogo> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listJogo = new List<Jogo>();

            while (retorno.Read())
            {
                var item = new Jogo()
                {
                    IdJogo = Convert.ToInt32(retorno["IdJogo"]),
                    Titulo = retorno["Titulo"].ToString(),
                    Fabricante = retorno["Fabricante"].ToString(),
                    FaixaEtaria = retorno["FaixaEtaria"].ToString(),
                    plataforma = new Plataforma() { Descricao = retorno["Descricao"].ToString() },
                    categoria = new Categoria() { Descricao = retorno["Descricao"].ToString() }

                };

                listJogo.Add(item);
            }

            return listJogo;
        }

        #endregion Métodos
    }
}
