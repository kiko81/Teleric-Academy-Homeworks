namespace ObjectPoolDemo
{
    public class PoolObject
    {
        public PoolObject(int id)
        {
            this.ID = id;
        }

        public int ID { get; private set; }
    }
}