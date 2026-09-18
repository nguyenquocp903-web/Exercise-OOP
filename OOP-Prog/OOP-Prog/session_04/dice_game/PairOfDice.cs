using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Prog.session_04.dice_game
{
    public class HeartOfDice
    {
        private Die die1;
        private Die die2;
        private Die die3;

        public HeartOfDice()
        {
            die1 = new Die();
            die2 = new Die();
            die3 = new Die();
        }

        public void Roll()
        {
            die1.roll();
            die2.roll();
            die3.roll();
        }
        /// <summary>
        /// Get the total points of the pair of dice
        /// </summary>
        /// <returns></returns>
        public int GetPoints()
        {
            return die1.Face + die2.Face + die3.Face;
        }

        public bool IsBothOne()
        {
            return die1.Face == 1 && die2.Face == 1 && die3.Face == 1   ;
        }

        public bool IsBothNine()
        {
            return die1.Face == 9 && die2.Face == 9 && die3.Face == 9;
        }

        public override string ToString()
        {
            return $"[{die1}, {die2}, {die3}]";
        }
    }
}
