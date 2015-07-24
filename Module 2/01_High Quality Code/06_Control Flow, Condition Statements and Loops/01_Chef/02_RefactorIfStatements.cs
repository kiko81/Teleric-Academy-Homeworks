namespace Chef
{
    using System;

    class RefactorIfStatements
    {
        void firstStatement(Potato potato)
        {
            //Potato potato;
            ////... 
            //if (potato != null)
            //    if (!potato.HasNotBeenPeeled && !potato.IsRotten)
            //        Cook(potato);

            if (potato != null)
            {
                if (!(potato.HasNotBeenPeeled && potato.IsRotten))
                {
                    potato.Cook();
                }
            }
        }

        void secondStatement(int x, int y, int minX, int minY, int maxX, int maxY, bool shouldVisitCell)
        {
            //TASK
            //if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
            //{
            //   VisitCell();
            //}

            if (minX <= x && x <= maxX)
            {
                if (minY <= y && y <= maxY)
                {
                    if (shouldVisitCell)
                    {
                        VisitCell();
                    }
                }
            }
        }
        //for avoiding errors
        private void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}
