namespace CohesionAndCoupling
{
    using System;

    public static class CoordinateUtils
    {

        public static double Width { get; set; }
        public static double Height { get; set; }
        public static double Depth { get; set; }

        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + 
                                        (y2 - y1) * (y2 - y1));

            return distance;
        }

        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + 
                                        (y2 - y1) * (y2 - y1) + 
                                        (z2 - z1) * (z2 - z1));

            return distance;
        }

        
    }
}
