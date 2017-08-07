namespace TD.Holders
{
    public class AttackRateHolder
    {
        private float attackRate;

        public float AttackRate
        {
            get
            {
                return attackRate;
            }
            set
            {
                attackRate = value;

                if (attackRate < 0)
                {
                    attackRate = 0;
                }
            }
        }
    }
}