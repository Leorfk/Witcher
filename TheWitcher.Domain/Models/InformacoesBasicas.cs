using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWitcher.Domain.Enums;

namespace TheWitcher.Domain.Models
{
    public class InformacoesBasicas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public EnumSexo Sexo { get; set; }
        public int Hp { get; set; }
        public int Atk { get; set; }
    }
}
