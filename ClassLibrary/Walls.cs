using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    

    public class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight) 
        { 
            wallList = new List<Figure>();
            Figure HorlineUp = new HorizontallLine(0, mapWidth-2, 0, '-');
            Figure VerLineLeft = new VerticalLine(0, mapHeight-1, 0, '|');
            Figure HorlineDown = new HorizontallLine(0, mapWidth-2, mapHeight-1, '-');
            Figure VerLineRigth = new VerticalLine(0, mapHeight-1, mapWidth-2, '|');


            wallList.Add(HorlineUp);
            wallList.Add(VerLineLeft);
            wallList.Add(HorlineDown);
            wallList.Add(VerLineRigth);
        }

        public void Drow() 
        {
            foreach (Figure wall in wallList) 
                wall.Drow();

        }

        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
