using BattleShipStateTrackerAPI.Models.Boards;

namespace BattleShipStateTrackerAPI.Models
{
    public class Cell
  {
    public BattleShipType BattleShipType { get; set; }
    public ShotType ShotType { get; set; }
    public Coordinates Coordinates { get; set; }
    public Cell(int row, int column)
    {
      Coordinates = new Coordinates(row, column);
      BattleShipType = BattleShipType.Empty;
    }

    public bool IsOccupied
    {
      get
      {
        return BattleShipType != BattleShipType.Empty;
      }
    }

    public bool IsRandomAvailable
    {
      get
      {
        return (Coordinates.Row % 2 == 0 && Coordinates.Column % 2 == 0)
            || (Coordinates.Row % 2 == 1 && Coordinates.Column % 2 == 1);
      }
    }

  }
}