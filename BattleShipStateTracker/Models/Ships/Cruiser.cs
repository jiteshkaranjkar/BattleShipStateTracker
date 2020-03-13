
namespace BattleShipStateTracker.Models.Ships
{
  public class Cruiser : Ship
  {
    public Cruiser()
    {
      Name = "Cruiser";
      BattleShipType = BattleShipType.Cruiser;
      Holes = 3;
      Hits = 0;
    }
  }
}