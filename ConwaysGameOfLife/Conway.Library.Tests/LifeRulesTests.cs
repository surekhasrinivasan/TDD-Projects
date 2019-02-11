using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway.Library.Tests
{
    // Any live cell with fewer than two live neighbors dies.
    // Any live cell with two or three live neighbors lives 
    // Any live cell with more than three live neighbors dies. 
    // Any dead cell with exactly three live neighbors becomes a live cell. 
    
    [TestFixture]
    public class LifeRulesTests
    {
        [Test]
        public void LiveCell_FewerThan2LiveNeighbors_Dies(
           [Values(0, 1)] int liveNeighbors)
        {
            var currentState = CellState.Alive;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Dead, newState);
        }
    }
}
