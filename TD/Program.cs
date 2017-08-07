using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.Holders;

namespace TD
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class EnemyInfo
    {

        public EnemyInfo(EnemySettings settings)
        {
            MainDescription = new EnemyDescription(settings);
            ActualDescription = new EnemyDescription(settings);
            Bonus = new EnemyBonus();
        }

        public EnemyDescription MainDescription
        {
            get;
            private set;
        }

        public EnemyDescription ActualDescription
        {
            get;
            private set;
        }

        public EnemyBonus Bonus
        {
            get;
            private set;
        }

        public EnemyInfo ApplyHit(HitInfo hit)
        {
            return this;
        }
    }



    public class EnemyDescription
    {
        private readonly ArmorHolder armorHolder;
        private readonly HealthHolder healthHolder;
        private readonly MoveSpeedHolder moveSpeedHolder;

        public EnemyDescription(EnemySettings settings)
        {
            armorHolder = new ArmorHolder();
            healthHolder = new HealthHolder();
            moveSpeedHolder = new MoveSpeedHolder();

            Armor = settings.Armor;
            MaxHealth = settings.Health;
            CurrentHealth = settings.Health;
            MoveSpeed = settings.MoveSpeed;
        }

        protected int Armor
        {
            get
            {
                return armorHolder.Armor;
            }
            set
            {
                armorHolder.Armor = value;
            }
        }

        protected int CurrentHealth
        {
            get
            {
                return healthHolder.CurrentHealth;
            }
            set
            {
                healthHolder.CurrentHealth = value;
            }
        }

        protected int MaxHealth
        {
            get
            {
                return healthHolder.MaxHealth;
            }
            set
            {
                healthHolder.MaxHealth = value;
            }
        }

        protected float MoveSpeed
        {
            get
            {
                return moveSpeedHolder.MoveSpeed;
            }
            set
            {
                moveSpeedHolder.MoveSpeed = value;
            }
        }
    }

    public class EnemyStats
    {
        public int Armor
        {
            get;
            set;
        }

        public int Health
        {
            get;
            set;
        }

        public float MoveSpeed
        {
            get;
            set;
        }
    }

    public class EnemyBonus : EnemyStats
    {
        
    }

    public class EnemySettings : EnemyStats
    {
        
    }

    public class HitInfo
    {
        public int Damage
        {
            get;
            set;
        }
    }
}
