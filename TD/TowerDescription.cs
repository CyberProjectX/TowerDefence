using TD.Holders;

namespace TD
{
    public class TowerDescription
    {
        private readonly AttackRateHolder attackRateHolder;
        private readonly DamageHolder damageHolder;
        private readonly AttackDistanceHolder attackDistanceHolder;
        private readonly CritRateHolder critRateHolder;
        private readonly CritMultiplierHolder critMultiplierHolder;

        protected TowerDescription(TowerSettings settings)
        {
            attackRateHolder = new AttackRateHolder();
            damageHolder = new DamageHolder();
            attackDistanceHolder = new AttackDistanceHolder();
            critRateHolder = new CritRateHolder();
            critMultiplierHolder = new CritMultiplierHolder();

            AttackRate = settings.AttackRate;
            Damage = settings.Damage;
            AttackDistance = settings.AttackDistance;
            CritRate = settings.CritRate;
            CritMultiplier = settings.CritMultiplier;
        }

        protected float AttackRate
        {
            get
            {
                return attackRateHolder.AttackRate;
            }
            set
            {
                attackRateHolder.AttackRate = value;
            }
        }

        protected float Damage
        {
            get
            {
                return damageHolder.Damage;
            }
            set
            {
                damageHolder.Damage = value;
            }
        }

        protected float AttackDistance
        {
            get
            {
                return attackDistanceHolder.AttackDistance;
            }
            set
            {
                attackDistanceHolder.AttackDistance = value;
            }
        }

        protected float CritRate
        {
            get
            {
                return critRateHolder.CritRate;
            }
            set
            {
                critRateHolder.CritRate = value;
            }
        }

        protected float CritMultiplier
        {
            get
            {
                return critMultiplierHolder.CritMultiplier;
            }
            set
            {
                critMultiplierHolder.CritMultiplier = value;
            }
        }
    }
}