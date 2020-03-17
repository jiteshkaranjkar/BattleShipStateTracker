using System.Collections.Generic;
using System.Linq;
using BattleShipStateTrackerAPI.Extensions;
using BattleShipStateTrackerAPI.Models.Boards;

namespace BattleShipStateTrackerAPI.Models.Boards
{

  //This is the 10*10 Target board where the Red/White Pegs get placed notifying Hit/Miss
  public class TargetBoard : Board
  {
    public TargetBoard()
    {
      BoardType = BoardType.TargetBoard;
      Cells = new List<Cell>();
    }


    // Get Cells at random
    public List<Coordinates> GetOpenRandomCells()
    {
      return Cells.Where(x => x.BattleShipType == BattleShipType.Empty && x.IsRandomAvailable).Select(x => x.Coordinates).ToList();
    }
  }
}