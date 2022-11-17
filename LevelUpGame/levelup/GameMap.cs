namespace levelup
{
    public class GameMap{
        public int numPositions;
        public Position startingPoition{get;set;}

        public void Init(){
            numPositions = 100;
            this.startingPoition = new Position(0,0);
        }    
    }
}