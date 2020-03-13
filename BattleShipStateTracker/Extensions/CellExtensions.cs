using System.Collections.Generic;
using System.Linq;
using BattleShipStateTracker.Models;

namespace BattleShipStateTracker.Extensions
{
  public static class CellExtensions
  {
    public static List<Cell> Range(this List<Cell> cells, int startRow, int startColumn, int endRow, int endColumn)
    {
      return cells.Where(x => x.Coordinates.Row >= startRow
                                    && x.Coordinates.Column >= startColumn
                                    && x.Coordinates.Row <= endRow
                                    && x.Coordinates.Column <= endColumn).ToList();

    }

    public static Cell At(this List<Cell> cells, int row, int column)
    {
      return cells.Where(x => x.Coordinates.Row == row && x.Coordinates.Column == column).First();
    }
  }
}