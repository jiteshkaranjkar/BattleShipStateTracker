using System.Collections.Generic;
using System.Linq;

namespace BattleShipStateTracker.Models.Boards
{
  public abstract class Board
  {
    public BoardType BoardType { get; set; }
    public List<Cell> Cells { get; set; }
  }
}