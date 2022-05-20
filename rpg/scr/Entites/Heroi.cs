using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.scr.Entites
{
    public class Heroi
    {
        public Heroi(string nome, int level,string tipoheroi, int hp)
        {
            this.hp = hp;
            this.nome = nome;
            this.level = level;
            this.tipoheroi = tipoheroi;
        }

        public string nome;
        public int level;
        public string tipoheroi;
        public int hp;

        public override string ToString()
        {
            return this.nome + " " + this.level + " " + this.tipoheroi;
          }

        public virtual string Ataque()
        {
            return this.nome + "atacou com sua espada";
        }
    }
}
