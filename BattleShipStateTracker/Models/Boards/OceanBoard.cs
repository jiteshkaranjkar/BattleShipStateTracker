using System.Collections.Generic;

namespace BattleShipStateTracker.Models.Boards
{
  //This is the 10*10 Game board where the ships would be placed
  public class OceanBoard : Board
  {
    public OceanBoard()
    {
      BoardType = BoardType.OceanBoard;
      Cells = new List<Cell>();
      for (int x = 0; x < 10; x++)
      {
        for (int y = 0; y < 10; y++)
        {
          Cells.Add(new Cell(x, y));
        }
      }
    }
  }
}