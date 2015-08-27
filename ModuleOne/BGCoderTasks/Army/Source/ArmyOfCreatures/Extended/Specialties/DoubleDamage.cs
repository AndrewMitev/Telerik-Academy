﻿namespace ArmyOfCreatures.Extended.Specialties
{
    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Logic.Battles;
    using System;

    public class DoubleDamage : Specialty
    {
        private int rounds;

        public DoubleDamage(int tempRounds)
        {
            if (rounds < 0 || rounds > 10)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0 and less than 11");
            }

            this.rounds = tempRounds;
        }

        public override decimal ChangeDamageWhenAttacking(ICreaturesInBattle attackerWithSpecialty, 
            ICreaturesInBattle defender,
            decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            if (this.rounds <= 0)
            {
                // Effect expires after fixed number of rounds
                return currentDamage;
            }

            this.rounds--;

            return currentDamage * 2;
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.GetType().Name, this.rounds);
        }
    }
}
