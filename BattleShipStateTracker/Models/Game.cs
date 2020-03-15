using System;
using System.Threading.Tasks;

namespace BattleShipStateTracker.Models
{
  public class Game
  {
    public Player firstPlayer { get; set; }
    public Player secondPlayer { get; set; }


    public Game()
    {
      firstPlayer = new Player("Player One");
      firstPlayer.PlaceShips();

      secondPlayer = new Player("Player Two");
    }


    public void PlayRound()
    {
      //Player 1 fires a shot and validates if the shot is hit/miss
      var coordinates = secondPlayer.FireShot();
      var result = firstPlayer.ProcessShot(coordinates);
    }
  }
}
