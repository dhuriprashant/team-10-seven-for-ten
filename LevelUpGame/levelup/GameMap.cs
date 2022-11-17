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
    }
}