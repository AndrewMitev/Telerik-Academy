namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Logic.Battles;


    public class AddAttackWhenSkip : Specialty
    {
        private readonly int attackToAdd;

        public AddAttackWhenSkip(int tempAttackToAdd)
        {
            if (tempAttackToAdd < 1 || tempAttackToAdd > 10)
            {
                throw new ArgumentOutOfRangeException("attackToAdd", "attackToAdd should be between 1 and 10, inclusive");
            }

            this.attackToAdd = tempAttackToAdd;
        }

        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack += this.attackToAdd;
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.GetType().Name, this.attackToAdd);
        }
    }
}
