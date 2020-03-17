using System;
using System.Threading.Tasks;
using BattleShipStateTrackerAPI.Models.Boards;

namespace BattleShipStateTrackerAPI.Models
{
  public class Game
  {
    public Player firstPlayer { get; set; }
    public Player secondPlayer { get; set; }


    public Game()
    {
      firstPlayer = new Player("Player One");
      secondPlayer = new Player("Player Two");
    }


    public string Attack(Coordinates coordinates)
    {
      //Player 1 fires a shot and validates if the shot is hit/miss
      //var coordinates = secondPlayer.FireShot();
      return firstPlayer.ProcessShot(coordinates).ToString();
    }
  }
}
