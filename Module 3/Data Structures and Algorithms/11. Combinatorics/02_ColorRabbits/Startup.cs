namespace ColorRabbits
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var askedRabbits = int.Parse(Console.ReadLine());
            var rabbitGroups = new Dictionary<int, int>();

            for (var i = 0; i < askedRabbits; i++)
            {
                var rabbitsPerGroup = int.Parse(Console.ReadLine()) + 1;
                if (rabbitGroups.ContainsKey(rabbitsPerGroup))
                {
                    rabbitGroups[rabbitsPerGroup]++;
                }
                else
                {
                    rabbitGroups.Add(rabbitsPerGroup, 1);
                }
            }

            long count = 0;

            foreach (var group in rabbitGroups)
            {
                if (group.Value % group.Key == 0)
                {
                    count += group.Value;
                }
                else
                {
                    count += ((group.Value / group.Key) + 1) * group.Key;
                }
            }

            Console.WriteLine(count);
        }
    }
}
