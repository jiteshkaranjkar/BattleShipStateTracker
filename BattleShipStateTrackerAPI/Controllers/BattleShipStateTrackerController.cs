using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BattleShipStateTrackerAPI.Models;
using BattleShipStateTrackerAPI.Models.Ships;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
      battleShipGame.secondPlayer.PlaceShips();
    }

    [HttpPost]
    public string Attack()
    {
      return battleShipGame.PlayRound();
    }
  }
}