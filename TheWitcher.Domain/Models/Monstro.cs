using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWitcher.Domain.Enums;

namespace TheWitcher.Domain.Models
{
    public class Monstro
    {
        private int Id;
        private string Nome;
        private DateTime DataEncontro;
        private EnumRacasMonstros Raca;
        private decimal Recompensa;

        public int id
        {
            get
            {
                return Id;
            }
            set
            {
                this.Id = id;
            }
        }
    }
}
