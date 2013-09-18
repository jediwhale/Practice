namespace GameOfLife
{
    public class Cell
    {
        public Cell(bool isAlive)
        {
            this.isAlive = isAlive;
        }
        
        public Cell NextCell(int neighbourCount) {
            if (isAlive && neighbourCount > 1) {
                return new Cell(true);
            }
            return new Cell(false);
        }
        
        public bool IsAlive() { return isAlive; }
        
        readonly bool isAlive;
    }
}
