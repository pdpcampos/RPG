using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.scr.Entites
{
    public class Oponente : Heroi
    {

        public Oponente(string nome, int level, string tipoheroi, int hp) : base(nome, level, tipoheroi, hp)
        {
            this.nome = nome;
            this.level = level;
            this.tipoheroi = tipoheroi;
            this.hp = hp;
        }
        
        public override string Ataque()
        {
            return this.nome + "lançou magia";
        }

        public string Ataque(int bonus)
        {
            if (bonus > 6)
            {

                return this.nome + "Lancou magia com bonus de ataque de" + bonus;
            }
            else
            {
                return this.nome + "lançou magia com força fraca de bonus de " + bonus;
            }
        }
    }
}
