using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BattleShipStateTracker.Models;
using BattleShipStateTracker.Models.Ships;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BattleShipStateTracker.Controllers
{
  [ApiController]
  [Route("BattleShipTracker")]
  public class BattleShipTrackerController : ControllerBase
  {
    public Game battleShipGame;

    public BattleShipTrackerController()
    {

    }

    [HttpGet]
    public void PlaceShipsAndFire()
    {
      battleShipGame = new Game();
      battleShipGame.PlayRound();
    }
  }
}