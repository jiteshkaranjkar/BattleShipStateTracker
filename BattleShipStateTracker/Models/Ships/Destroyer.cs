
namespace BattleShipStateTracker.Models.Ships
{
  public class Destroyer : Ship
  {
    public Destroyer()
    {
      Name = "Destroyer";
      BattleShipType = BattleShipType.Destroyer;
      Holes = 2;
      Hits = 0;
    }
  }
}