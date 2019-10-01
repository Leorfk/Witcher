using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWitcher.Domain.Enums;

namespace TheWitcher.Domain.Models
{
    public class Monstro : InformacoesBasicas
    {
        public DateTime DataEncontro { get; set; }
        public EnumRacasMonstros Raca { get; set; }
        public List<EnumSinais> SinaisEficazes { get; set; }
        public decimal Recompensa { get; set; }
    }
}
