using System;
using Xunit;
using BattleShipStateTrackerAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace BattleShipStateTrackerTest
{

  public class BattleShipTestsBase : IDisposable
  {
    public BattleShipTrackerController controller { get; set; }
    public BattleShipTestsBase()
    {
      controller = new BattleShipTrackerController();
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
    public void CheckPlayers_returnsTwoPlayers()
    {
      string playerOne = "Player One";
      Assert.Equal(controller.battleShipGame.firstPlayer.Name, playerOne);
      string playerTwo = "Player Two";
      Assert.Equal(controller.battleShipGame.secondPlayer.Name, playerTwo);
    }

    [Fact]
    public void CreateBoard_returnsTwoBoards()
    {
      controller.CreateBoard();
      BoardType ocean = BoardType.OceanBoard;
      BoardType target = BoardType.TargetBoard;
      Assert.Equal(controller.battleShipGame.firstPlayer.OceanBoard.BoardType, ocean);
      Assert.Equal(controller.battleShipGame.firstPlayer.TargetBoard.BoardType, target);
    }

    [Fact]
    public void AddBattleshipsOnBoard_returnsFleet()
    {
      int count = 5;
      Assert.Equal(controller.battleShipGame.firstPlayer.Fleet.Count, count);
      Assert.Equal(controller.battleShipGame.secondPlayer.Fleet.Count, count);
    }

  }
}