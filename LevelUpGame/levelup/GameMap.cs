using System.Drawing;

namespace levelup
{
    public class GameMap{
        public int numPositions;
        public List<Position> positions = new List<Position>();
        public Position startingPoition{get;set;}

        public void Init(){
            numPositions = 100;
            this.startingPoition = new Position(0,0);
        }    

        public List<Position> getPositions(){
            return new List<Position>();
        }

        public int getTotalPositions(){
            return this.numPositions;
        }
        public bool isPositionValid (Point positionCoordinates){
            if (positionCoordinates.X > this.numPositions-1 && positionCoordinates.X < 0){
                return false;
            }

            return false;

        }
    }
}