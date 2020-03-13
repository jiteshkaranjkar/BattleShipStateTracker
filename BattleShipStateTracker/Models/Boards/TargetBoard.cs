using System.Collections.Generic;
using System.Linq;
using BattleShipStateTracker.Extensions;

namespace BattleShipStateTracker.Models.Boards
{

  //This is the 10*10 Target board where the Red/White Pegs get placed notifying Hit/Miss
  public class TargetBoard : Board
  {
    public TargetBoard()
    {
      BoardType = BoardType.TargetBoard;
      Cells = new List<Cell>();
      for (int x = 0; x < 10; x++)
      {
        for (int y = 0; y < 10; y++)
        {
          Cells.Add(new Cell(x, y));
        }
      }
    }


    // Get Cells at random
    public List<Coordinates> GetOpenRandomCells()
    {
      return Cells.Where(x => x.BattleShipType == BattleShipType.Empty && x.IsRandomAvailable).Select(x => x.Coordinates).ToList();
    }
  }
}