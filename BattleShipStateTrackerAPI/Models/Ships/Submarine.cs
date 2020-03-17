namespace BattleShipStateTrackerAPI.Models.Ships
{
  public class Submarine : Ship
  {
    public Submarine()
    {
      Name = "Submarine";
      BattleShipType = BattleShipType.Submarine;
      Holes = 3;
      Hits = 0;
    }
  }
}