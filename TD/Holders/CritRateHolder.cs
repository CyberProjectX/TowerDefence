namespace TD.Holders
{
    public class CritRateHolder
    {
        private float critRate;

        public float CritRate
        {
            get
            {
                return critRate;
            }
            set
            {
                critRate = value;
                if (critRate < 0)
                {
                    critRate = 0;
                }

                if (critRate > 1)
                {
                    critRate = 1;
                }
            }
        }
    }
}