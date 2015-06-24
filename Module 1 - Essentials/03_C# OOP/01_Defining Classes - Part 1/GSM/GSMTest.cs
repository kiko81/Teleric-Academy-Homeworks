namespace GSM
{
    using System;

    class GSMTest 
    {
        public static Random r = new Random();

        private static string[] manifacturer = { "Sony", "Apple", "Nokia", "Samsung" };
        private static string[] model = { "Iphone", "Galaxy", "Xperia", "Lumia" };

        private static string owner = "any";


        public static GSM[] GenerateGSMs(int number)
        {
            GSM[] gsms = new GSM[number];
            for (int i = 0; i < number; i++)
            {
                gsms[i] = new GSM(manifacturer[r.Next(0, manifacturer.Length)], model[r.Next(0, model.Length)], r.Next(1, 1000), owner, new Battery(), new Display());
            }

            return gsms;
        }

        public static void PrintGSMsInfo(GSM[] gsms)
        {
            for (int i = 0; i < gsms.Length; i++)
            {
                Console.WriteLine("GSM {0}", gsms[i]);
                Console.WriteLine();
            }

            Console.WriteLine("IPhone info: {0}", GSM.Iphone4S);
        }
    }
}
