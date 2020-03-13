using System;
using Xunit;
using BattleShipStateTracker.Models;

namespace BattleShipStateTrackerTest
{
    public class PlayerTest
    {

        [Fact]
        public void CreatePlayer()
        {
            string name = "John";
            Player player = new Player(name);
            Assert.Equal(player.Name, name);
        }

        [Theory]
        [InlineData("Michael", 5)]
        [InlineData("JohnTrovolta", 5)]
        public void ValidatePlayerFleet(string name, int shipCount)
        {
            Player player = new Player(name);
            Assert.Equal(player.Name, name);
            Assert.Equal(player.Fleet.Count, shipCount);
        }
    }
}
