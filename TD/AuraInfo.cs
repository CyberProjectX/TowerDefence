using System;

namespace TD
{
    public class AuraInfo
    {
        public AuraInfo(AuraSettings settings)
        {
            Id = Guid.NewGuid();
            AttackRate = settings.AttackRate;
            Damage = settings.Damage;
            AttackDistance = settings.AttackDistance;
            CritRate = settings.CritRate;
            CritMultiplier = settings.CritMultiplier;
        }

        public Guid Id
        {
            get;
            private set;
        }

        public float AttackRate
        {
            get;
            private set;
        }

        public float Damage
        {
            get;
            private set;
        }

        public float AttackDistance
        {
            get;
            private set;
        }

        public float CritRate
        {
            get;
            private set;
        }

        public float CritMultiplier
        {
            get;
            private set;
        }
    }
}