namespace TD.Holders
{
    public class CritMultiplierHolder
    {
        private float critMultiplier;

        public float CritMultiplier
        {
            get
            {
                return critMultiplier;
            }
            set
            {
                critMultiplier = value;
                if (critMultiplier < 1)
                {
                    critMultiplier = 1;
                }
            }
        }
    }
}