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
