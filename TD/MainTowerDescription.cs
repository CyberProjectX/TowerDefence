namespace TD
{
    public class MainTowerDescription : TowerDescription
    {
        public MainTowerDescription(TowerSettings settings) : base(settings)
        {
        }

        public new float AttackRate
        {
            get { return base.AttackRate; }
        }
        public new float Damage
        {
            get { return base.Damage; }
        }

        public new float AttackDistance
        {
            get { return base.AttackDistance; }
        }

        public new float CritRate
        {
            get { return base.CritRate; }
        }

        public new float CritMultiplier
        {
            get { return base.CritMultiplier; }
        }
    }
}