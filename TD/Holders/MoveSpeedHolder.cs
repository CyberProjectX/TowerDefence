namespace TD.Holders
{
    public class MoveSpeedHolder
    {
        private float moveSpeed;

        public float MoveSpeed
        {
            get
            {
                return moveSpeed;
            }
            set
            {
                moveSpeed = value;
                if (moveSpeed < 0)
                {
                    moveSpeed = 0;
                }
            }
        }
    }
}