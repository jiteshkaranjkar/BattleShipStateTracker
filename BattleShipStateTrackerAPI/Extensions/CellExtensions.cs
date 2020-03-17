using System.Collections.Generic;
using System.Linq;
using BattleShipStateTrackerAPI.Models;
using BattleShipStateTrackerAPI.Models.Boards;

namespace BattleShipStateTrackerAPI.Extensions
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

    public static Board DrawBoard(this Board board)
    {
      for (int x = 0; x < 10; x++)
      {
        for (int y = 0; y < 10; y++)
        {
          board.Cells.Add(new Cell(x, y));
        }
      }
      return board;
    }
  }
}