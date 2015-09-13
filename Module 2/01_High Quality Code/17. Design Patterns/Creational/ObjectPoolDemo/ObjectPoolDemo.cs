namespace ObjectPoolDemo
{
    using System;

    public class ObjectPoolDemo
    {
        static void Main()
        {
            Pool pool = Pool.PoolInstance();

            var obj1 = pool.GetObject();
            Console.WriteLine("Client got object with ID " + obj1.ID);

            var obj2 = pool.GetObject();
            Console.WriteLine("Client got object with ID " + obj2.ID);

            pool.PrintPools();

            var obj3 = pool.GetObject();
            Console.WriteLine("Client got object with ID " + obj3.ID);

            var obj4 = pool.GetObject();
            Console.WriteLine("Client got object with ID " + obj4.ID);

            pool.PrintPools();

            pool.ReleaseObject(obj2);
            pool.ReleaseObject(obj4);
            Console.WriteLine("Client returned objects {0} and {1} back to pool", obj2.ID, obj4.ID);

            pool.PrintPools();

            var obj5 = pool.GetObject();
            Console.WriteLine("Client got object with ID " + obj5.ID);

            pool.PrintPools();

            pool.ReleaseObject(obj1);
            Console.WriteLine("Client returned objects {0} back to pool", obj1.ID);

            pool.PrintPools();

            // Creating another pool - singleton doesn't allow
            Console.WriteLine("---------Another pool creation attempt --------");
            Pool anotherPool = Pool.PoolInstance();

            anotherPool.PrintPools();

        }
    }
}
