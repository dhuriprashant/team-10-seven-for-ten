using System.Drawing;

namespace levelup{
    public class Position{

        public Point Coordinates {get;set;}

        public Position(int xCoordinates, int yCoordinates){
            this.Coordinates = new Point(xCoordinates,yCoordinates);
        }

    }
}