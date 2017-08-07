namespace TD.Holders
{
    public class HealthHolder
    {
        private int currentHealth;

        private int maxHealth;

        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }
            set
            {
                currentHealth = value;
                if (currentHealth < 0)
                {
                    currentHealth = 0;
                }

                if (currentHealth > MaxHealth)
                {
                    currentHealth = MaxHealth;
                }
            }
        }

        public int MaxHealth
        {
            get
            {
                return maxHealth;
            }
            set
            {
                maxHealth = value;

                if (maxHealth < 0)
                {
                    maxHealth = 0;
                }
            }
        }
    }
}