using System.Collections.Generic;

namespace BattleShipStateTrackerAPI.Models.Boards
{
  //This is the 10*10 Game board where the ships would be placed
  public class OceanBoard : Board
  {
    public OceanBoard()
    {
      BoardType = BoardType.OceanBoard;
      Cells = new List<Cell>();
    }
  }
}