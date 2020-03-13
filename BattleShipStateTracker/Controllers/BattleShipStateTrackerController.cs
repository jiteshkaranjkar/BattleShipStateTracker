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
    private readonly ILogger<BattleShipTrackerController> _logger;

    public BattleShipTrackerController(ILogger<BattleShipTrackerController> logger)
    {
      _logger = logger;

    }

    // GET: api/ships
    [HttpGet]
    public void PlaceShipsAndFire()
    {
      Game battleShipGame = new Game();
      battleShipGame.PlayRound();
    }
  }
}