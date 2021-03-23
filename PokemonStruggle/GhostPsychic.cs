using System;
using System.Collections.Generic;
using System.Text;

namespace Arena
{
    class GhostPsychic: Pokemon
    {
        private int mana;
        private int maxMana;
        private int magicAttack;

        public GhostPsychic(string name, int life, int attack, int defense, Cube cube, int mana, int magicAttack)
            :base(name, life, attack, defense, cube)
        {
            this.mana = mana;
            this.maxMana = mana;
            this.magicAttack = magicAttack;
        }
        public string GraphicMana()
        {
            return GraphicPointer(mana, maxMana);
        }

        public override void Offensive(Pokemon rival)
        {
            //mana neni naplněna

            if (mana < maxMana)
            {
                mana += 10;
            if (mana > maxMana)
                mana = maxMana;
            base.Offensive(rival);
                //    SetMessage(String.Format($"{name} útočí s úderem za {hit} HP"));
            }
            else // Magický útok pkmna
            {
                int hit = magicAttack + cube.Toss();
                SetMessage(String.Format($"{name} použil magický útok za {hit} hp"));
                rival.DefendYourself(hit);
                mana = 0;
            }
        }






    }

}

