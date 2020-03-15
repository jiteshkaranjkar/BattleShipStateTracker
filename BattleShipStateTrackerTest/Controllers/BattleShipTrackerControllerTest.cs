using System;
using Xunit;
using BattleShipStateTracker.Controllers;
using Microsoft.Extensions.Logging;

namespace BattleShipStateTrackerTest
{

  public class BattleShipTestsBase : IDisposable
  {
    public BattleShipTrackerController controller { get; set; }
    public BattleShipTestsBase()
    {
      controller = new BattleShipTrackerController();
      controller.PlaceShipsAndFire();
    }

    public void Dispose()
    {
      controller = null;
    }
  }

  public class BattleShipTrackerControllerTest : IClassFixture<BattleShipTestsBase>
  {
    BattleShipTrackerController controller { get; set; }
    public BattleShipTrackerControllerTest(BattleShipTestsBase data)
    {
      controller = data.controller;
    }

    [Fact]
    public void CheckPlayers()
    {
      string playerName = "Player One";
      Assert.Equal(controller.battleShipGame.firstPlayer.Name, playerName);
    }

    [Fact]
    public void CheckFleetCount()
    {
      int count = 5;
      Assert.Equal(controller.battleShipGame.firstPlayer.Fleet.Count, count);
    }

    [Fact]
    public void ValidateBoardCells()
    {
      int cellCount = 100;
      Assert.Equal(controller.battleShipGame.firstPlayer.OceanBoard.Cells.Count, cellCount);
      Assert.Equal(controller.battleShipGame.firstPlayer.TargetBoard.Cells.Count, cellCount);
    }
  }
}