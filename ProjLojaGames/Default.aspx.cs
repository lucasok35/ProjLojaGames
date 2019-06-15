using Dados;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjLojaGames
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReloadGrid();

            if (!IsPostBack)
            {
                LoadCboPlataforma();
                LoadCboCategoria();
            };

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo()
            {
                Titulo = txtTitulo.Text,
                Fabricante = txtFabricante.Text,
                FaixaEtaria = txtFaixaEtaria.Text,
                plataforma = new Plataforma() { IdPlataforma = Convert.ToInt32(cboPlataforma.SelectedValue.ToString())},
                categoria = new Categoria() { IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue.ToString())}
            };

            if(new JogoDB().Insert(jogo))
            {
                lblMsg.Text = "Registro Inserido!";
                lblMsg.ForeColor = Color.Blue;
                ReloadGrid();
            }
            else
            {
                lblMsg.Text = "Erro ao Inserir Registro!";
                lblMsg.ForeColor = Color.Red;
            }
        }

        private void ReloadGrid()
        {
            gvDados.DataSource = new JogoDB().All();
            gvDados.DataBind();
        }

        private void LoadCboPlataforma()
        {
            cboPlataforma.DataSource = new PlataformaDB().All();
            cboPlataforma.DataTextField = "Descricao";
            cboPlataforma.DataValueField = "IdPlataforma";
            cboPlataforma.DataBind();
        }

        private void LoadCboCategoria()
        {
            cboCategoria.DataSource = new CategoriaDB().All();
            cboCategoria.DataTextField = "Descricao";
            cboCategoria.DataValueField = "IdCategoria";
            cboCategoria.DataBind();
        }
    }
}