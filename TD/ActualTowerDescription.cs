namespace TD
{
    public class ActualTowerDescription : TowerDescription
    {
        public ActualTowerDescription(TowerSettings settings) : base(settings)
        {
        }

        public new float AttackRate
        {
            get { return base.AttackRate; }
            set { base.AttackRate = value; }
        }

        public new float Damage
        {
            get { return base.Damage; }
            set { base.Damage = value; }
        }

        public new float AttackDistance
        {
            get { return base.AttackDistance; }
            set { base.AttackDistance = value; }
        }

        public new float CritRate
        {
            get { return base.CritRate; }
            set { base.CritRate = value; }
        }

        public new float CritMultiplier
        {
            get { return base.CritMultiplier; }
            set { base.CritMultiplier = value; }
        }
    }
}