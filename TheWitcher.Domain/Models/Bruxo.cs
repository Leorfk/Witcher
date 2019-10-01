using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWitcher.Domain.Enums;

namespace TheWitcher.Domain.Models
{
    public class Bruxo : InformacoesBasicas
    {
        public string Titulo { get; set; }
        public EnumEscola Escola { get; set; }
        public EnumArmadura Armadura { get; set; }
    }
}
