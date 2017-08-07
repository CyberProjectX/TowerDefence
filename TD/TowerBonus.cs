namespace TD
{
    public class TowerBonus : TowerStats
    {
        private readonly MainTowerDescription mainDescription;
        private readonly ActualTowerDescription actualDescription;

        public TowerBonus(MainTowerDescription mainDescription, ActualTowerDescription actualDescription)
        {
            this.mainDescription = mainDescription;
            this.actualDescription = actualDescription;
        }

        public override float AttackRate
        {
            get
            {
                return base.AttackRate;
            }
            set
            {
                base.AttackRate = value;
                actualDescription.AttackRate = mainDescription.AttackRate + base.AttackRate;
            }
        }

        public override float Damage
        {
            get
            {
                return base.Damage;
            }
            set
            {
                base.Damage = value;
                actualDescription.Damage = mainDescription.Damage + base.Damage;
            }
        }

        public override float AttackDistance
        {
            get
            {
                return base.AttackDistance;
            }
            set
            {
                base.AttackDistance = value;
                actualDescription.AttackDistance = mainDescription.AttackDistance + base.AttackDistance;
            }
        }

        public override float CritRate
        {
            get
            {
                return base.CritRate;
            }
            set
            {
                base.CritRate = value;
                actualDescription.CritRate = mainDescription.CritRate + base.CritRate;
            }
        }

        public override float CritMultiplier
        {
            get
            {
                return base.CritMultiplier;
            }
            set
            {
                base.CritMultiplier = value;
                actualDescription.CritMultiplier = mainDescription.CritMultiplier + base.CritMultiplier;
            }
        }
    }
}