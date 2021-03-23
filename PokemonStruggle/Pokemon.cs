using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    class Pokemon
    {
        /// <summary>
        /// Jméno bojovníka
        /// </summary>
        protected string name;
        /// <summary>
        /// Život v HP
        /// </summary>
        protected int life;
        /// <summary>
        /// Maximální zdraví
        /// </summary>
        protected int maxLife;
        /// <summary>
        /// Útok v HP
        /// </summary>
        protected int attack;
        /// <summary>
        /// Obrana v HP
        /// </summary>
        protected int defense;
        /// <summary>
        /// Instance hrací kostky
        /// </summary>
        protected Cube cube;
        /// <summary>
        /// Instance zpráva
        /// </summary>
        private string message;

        public Pokemon(string name, int life, int attack, int defense, Cube cube)
        {
            this.name = name;
            this.life = life;
            this.maxLife = life;
            this.attack = attack;
            this.defense = defense;
            this.cube = cube;
        }

        public bool Alive()
        {
            return (life > 0);
        }

        protected string GraphicPointer(int actual, int maximal)
        {
            string s = "[";
            int total = 20;
            double quantity = Math.Round(((double)actual / maximal) * total);
            if ((quantity == 0) && (Alive()))
                quantity = 1;
            for (int i = 0; i < quantity; i++)
                s += "#";
            s = s.PadRight(total + 1);
            s += "]";
            return s;
        }

        public string GraphicLife()
        {
            return GraphicPointer(life, maxLife);
        }


        public virtual void Offensive(Pokemon rival)
        {
            int hit = attack + cube.Toss();
            SetMessage(String.Format($"{name} útočí s úderem za {hit} hp"));
            rival.DefendYourself(hit);
        }

        public void DefendYourself(int hit)
        {
            int hurt = hit - (defense + cube.Toss());
            if (hurt > 0)
            {
                life -= hurt;
                message = String.Format($"{name} utrpěl poěkození {hurt}");
                if (life <= 0)
                {
                    life = 0;
                    message += " a zemřel";
                }
            }
            else
                message = String.Format($"{name} odrazil útok");
                SetMessage(message);

        }
    
        protected void SetMessage(string message)
        {
            this.message = message;
        }

        public string ReturnLastMessage()
        {
            return message;
        }

        public override string ToString ()
        {
            return name;
        }















    }
}
