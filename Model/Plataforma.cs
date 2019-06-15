using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Plataforma
    {
        #region Propriedades

        public int IdPlataforma { get; set; }
        public string Descricao { get; set; }

        #endregion

        public override string ToString()
        {
            return this.Descricao;
        }
    }
}
