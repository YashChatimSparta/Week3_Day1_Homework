using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsX
{

    class Movement
    {
        public int positionX = 0;
        public int positionY = 0;

        public Movement() { }

        public int moveRight()
        {
            positionX = positionX + 10;
            return positionX;
        }

        public int moveLeft()
        {
            positionX = positionX - 10;
            return positionX;
        }

        public int jump()
        {
            positionY = positionY + 10;
            return positionY;
        }

        public int duck()
        {
            positionY = positionY - 10;
            return positionY;
        }

    }
}
