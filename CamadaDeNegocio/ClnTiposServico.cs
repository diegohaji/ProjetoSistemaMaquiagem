using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoADados;
using System.Data;

namespace CamadaDeNegocio
{
    class ClnTiposServicos

    {
        private int cd_tipo_servico;
        private string desc_tipo_servico;
        
        public int Cd_Tipo_Servico
        {
            get { return this.cd_tipo_servico; }
            set { this.cd_tipo_servico = value; }
        }

        public string Desc_Tipo_Servico
        {
            get { return this.desc_tipo_servico; }
            set { this.desc_tipo_servico = value; }
        }

    }
}
