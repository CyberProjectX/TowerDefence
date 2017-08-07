namespace TD.Holders
{
    public class AttackDistanceHolder
    {
        private float attackDistance;

        public float AttackDistance
        {
            get
            {
                return attackDistance;
            }
            set
            {
                attackDistance = value;

                if (attackDistance < 0)
                {
                    attackDistance = 0;
                }
            }
        }
    }
}