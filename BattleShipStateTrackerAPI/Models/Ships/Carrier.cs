
namespace BattleShipStateTrackerAPI.Models.Ships
{
  public class Carrier : Ship
  {
    public Carrier()
    {
      Name = "Carrier";
      BattleShipType = BattleShipType.Carrier;
      Holes = 5;
      Hits = 0;
    }
  }
}