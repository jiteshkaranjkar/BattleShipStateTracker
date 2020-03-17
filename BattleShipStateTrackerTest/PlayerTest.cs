using Xunit;
using BattleShipStateTrackerAPI.Models;
using BattleShipStateTrackerAPI.Models.Boards;

namespace BattleShipStateTrackerTest
{
  public class PlayerTest
  {

    [Theory]
    [InlineData("Michael")]
    [InlineData("JohnTrovolta")]
    public void CreatePlayer_ValidateName(string name)
    {
      Player player = new Player(name);
      Assert.Equal(player.Name, name);
    }

    [Theory]
    [InlineData("Player1", ShotType.Hit)]
    [InlineData("Player1", ShotType.Miss)]
    [InlineData("Player2", ShotType.Hit)]
    [InlineData("Player2", ShotType.Miss)]
    public void PlaceFleet_validateFireShot(string name, ShotType shotType)
    {
      Player player = new Player(name);
      player.PlaceShips();
      //Even though the coordinates are fixed but since the ships are placed randomly, hence they will never be at same place
      Coordinates coords = new Coordinates(4, 7);
      Assert.Equal(player.ProcessShot(coords), shotType);
    }
  }
}
