using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.scr.Entites
{
    class Conciliador : Heroi
    {
        public Conciliador (String nome, int level, String tipoheroi, int hp) : base( nome, level, tipoheroi, hp)
        {
            this.nome = nome;
            this.level = level;
            this.tipoheroi = tipoheroi;
            this.hp = hp;
        }

        public override string paz()
        {
            return this.nome + "lançou para cessar a guerra";
        }

    }
}
