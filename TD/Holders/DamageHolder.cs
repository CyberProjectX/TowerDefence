namespace TD.Holders
{
    public class DamageHolder
    {
        private float damage;

        public float Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;

                if (damage < 0)
                {
                    damage = 0;
                }
            }
        }
    }
}