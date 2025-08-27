using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Comuns
{
    public enum TipoPlanoAulaEnum
    {
        [Description("Mensal")]
        Mensal = 1,

        [Description("Trimestral")]
        Trimestral = 2,

        [Description("Anual")]
        Anual = 3,
    }

    public enum TipoAulaEnum
    {
        [Description("Funcional")]
        Funcional = 1,

        [Description("Crossfit")]
        Croossfit = 2,

        [Description("Pilates")]
        Pilates = 3,

        [Description("Musculação")]
        Musculacao = 4
    }
}
