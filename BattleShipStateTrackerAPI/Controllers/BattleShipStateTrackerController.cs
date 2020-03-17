using System;
using BattleShipStateTrackerAPI.Models;
using BattleShipStateTrackerAPI.Models.Boards;
using Microsoft.AspNetCore.Mvc;

namespace BattleShipStateTrackerAPI.Controllers
{
  [ApiController]
  [Route("BattleShipTracker")]
  public class BattleShipTrackerController : ControllerBase
  {
    public Game battleShipGame;

    public BattleShipTrackerController()
    {
      battleShipGame = new Game();
    }

    [HttpGet]
    public void CreateBoard()
    {
      battleShipGame.firstPlayer.CreateBoard();
      battleShipGame.secondPlayer.CreateBoard();
    }

    [HttpPut]
    public void AddBattleshipsOnBoard()
    {
      battleShipGame.firstPlayer.PlaceShips();
    }

    [HttpPost]
    public string Attack(Coordinates coordinates)
    {
      Console.WriteLine(battleShipGame.firstPlayer.Name + " says: \"Firing shot at " + coordinates.Row.ToString() + ", " + coordinates.Column.ToString() + "\"");
      return battleShipGame.Attack(coordinates);
    }
  }
}