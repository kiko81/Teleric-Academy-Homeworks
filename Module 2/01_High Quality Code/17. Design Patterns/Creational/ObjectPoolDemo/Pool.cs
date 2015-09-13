namespace ObjectPoolDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pool
    {
        private static Pool pool;
        private static List<PoolObject> available = new List<PoolObject>();
        private static List<PoolObject> inUse = new List<PoolObject>();
        private static int id;

        // Singleton protected constructor
        protected Pool()
        {
        }

        public static Pool PoolInstance()
        {
            if (pool == null)
            {
                pool = new Pool();
            }

            return pool;
        }

        public PoolObject GetObject()
        {
            lock (available)
            {
                if (available.Count != 0)
                {
                    PoolObject po = available[0];
                    inUse.Add(po);
                    available.RemoveAt(0);
                    return po;
                }
                else
                {
                    // Create new object when none available - no limit added
                    id++;
                    PoolObject po = new PoolObject(id);
                    inUse.Add(po);
                    return po;
                }
            }
        }

        public void ReleaseObject(PoolObject po)
        {
            lock (available)
            {
                available.Add(po);
                inUse.Remove(po);
            }
        }

        public void PrintPools()
        {
            Console.WriteLine("Object ID's available: " + string.Join(", ", available.Select(x => x.ID)));
            Console.WriteLine("Object ID's in use: " + string.Join(", ", inUse.Select(x => x.ID)));
        }
    }
}
