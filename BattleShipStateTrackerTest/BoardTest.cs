using Xunit;
using BattleShipStateTrackerAPI.Models;
using BattleShipStateTrackerAPI.Models.Boards;
using BattleShipStateTrackerAPI.Extensions;

namespace BattleShipStateTrackerTest
{
    public class BoardTest
    {

        [Fact]
        public void CreateOceanBoard_validateBoardTypeCreated()
        {
            BoardType ocean = BoardType.OceanBoard;
            OceanBoard oceanBoard = new OceanBoard();
            Assert.Equal(oceanBoard.BoardType, ocean);
        }

        [Fact]
        public void CreateTargetBoard_validateBoardTypeCreated()
        {
            BoardType target = BoardType.TargetBoard;
            TargetBoard targetBoard = new TargetBoard();
            Assert.Equal(targetBoard.BoardType, target);
        }

        [Fact]
        public void DrawBoard_returnsCellCount()
        {
            OceanBoard oceanBoard = new OceanBoard();
            oceanBoard.DrawBoard();
            int cellCount = 100;
            Assert.Equal(oceanBoard.Cells.Count, cellCount);
        }
    }
}
