
namespace BattleShipStateTracker.Models.Ships
{
  public class Battleship : Ship
  {
    public Battleship()
    {
      Name = "Battleship";
      BattleShipType = BattleShipType.Battleship;
      Holes = 4;
      Hits = 0;
    }
  }
}