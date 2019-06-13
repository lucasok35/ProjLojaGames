using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Jogo
    {
        #region Propriedades

        public int IdJogo { get; set; }
        public string Titulo { get; set; }
        public string Fabricante { get; set; }
        public string FaixaEtaria { get; set; }
        public Plataforma plataforma { get; set; }
        public Categoria categoria { get; set; }

        #endregion


    }
}
