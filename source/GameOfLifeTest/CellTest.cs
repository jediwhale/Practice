using NUnit.Framework;
using GameOfLife;

namespace GameOfLifeTest
{
    [TestFixture]
    public class CellTest
    {
        [Test]
        public void LiveCellWithLessThan2NeighboursDies()
        {
            var cell = new Cell(true);
            var nextCell = cell.NextCell(1);
            Assert.AreEqual(false, nextCell.IsAlive());
        }
        
        [Test]
        public void LiveCellWith2NeighboursLives()
        {
            var cell = new Cell(true);
            var nextCell = cell.NextCell(2);
            Assert.AreEqual(true, nextCell.IsAlive());
        }
    }
}
