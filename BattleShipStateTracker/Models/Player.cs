using System;
using System.Collections.Generic;
using BattleShipStateTracker.Models.Boards;
using BattleShipStateTracker.Models.Ships;
using BattleShipStateTracker.Extensions;
using System.Linq;

namespace BattleShipStateTracker.Models
{
  public class Player
  {
    public string Name { get; set; }
    public TargetBoard TargetBoard { get; set; }
    public OceanBoard OceanBoard { get; set; }
    public List<Ship> Fleet { get; set; }

    public Player(string name)
    {
      Name = name;
      TargetBoard = new TargetBoard();
      OceanBoard = new OceanBoard();
      Fleet = new List<Ship>(){
          new Battleship(),
          new Carrier(),
          new Cruiser(),
          new Destroyer(),
          new Submarine()
        };
    }

    //Place all Ships with in the Ocean Board by validting if they are not out of range
    public void PlaceShips()
    {
      Random rand = new Random(Guid.NewGuid().GetHashCode());
      foreach (var ship in Fleet)
      {
        //Select a random row/column combination, then select a random orientation.
        //If none of the proposed cells are occupied, place the ship
        bool isOpen = true;
        while (isOpen)
        {
          //Next() has the second parameter be exclusive, while the first parameter is inclusive.
          var startcolumn = rand.Next(1, 11);
          var startrow = rand.Next(1, 11);
          int endrow = startrow, endcolumn = startcolumn;
          var orientation = rand.Next(1, 101) % 2; //0 for Horizontal

          List<int> cellNumbers = new List<int>();
          if (orientation == 0)
          {
            for (int i = 1; i < ship.Holes; i++)
            {
              endrow++;
            }
          }
          else
          {
            for (int i = 1; i < ship.Holes; i++)
            {
              endcolumn++;
            }
          }

          //We cannot place ships beyond the boundaries of the board
          if (endrow > 10 || endcolumn > 10)
          {
            isOpen = true;
            continue; //Restart the while loop to select a new random cell
          }

          //Check if specified cells are occupied
          var affectedCells = OceanBoard.Cells.Range(startrow, startcolumn, endrow, endcolumn);
          if (affectedCells.Any(x => x.IsOccupied))
          {
            isOpen = true;
            continue;
          }
          //Get the Coordinate of the Board where Ships are placed
          ship.ShipCoordinates = new List<Coordinates>();
          for (int i = startrow; i <= endrow; i++)
          {
            Console.WriteLine(Name + " says: \"" + ship.Name + " with " + ship.Holes + " Holes is placed at Row-" + i.ToString() + " and Column-" + startcolumn.ToString() + ".");
            ship.ShipCoordinates.Add(new Coordinates(i, startcolumn));
          }

          foreach (var cell in affectedCells)
          {
            cell.BattleShipType = ship.BattleShipType;
          }
          isOpen = false;
        }
      }
    }

    //Fire a shot by placing the 
    public Coordinates FireShot()
    {
      Coordinates coords;
      coords = RandomShot();
      Console.WriteLine(Name + " says: \"Firing shot at " + coords.Row.ToString() + ", " + coords.Column.ToString() + "\"");
      return coords;
    }

    // Choose Random coordinates 
    private Coordinates RandomShot()
    {
      var availableCells = TargetBoard.GetOpenRandomCells();
      Random rand = new Random(Guid.NewGuid().GetHashCode());
      var cellID = rand.Next(availableCells.Count);
      return availableCells[cellID];
    }

    // Once the Random coordinates are selected validate if it is Empty or Occupied
    // If Occupied then mark it as Hit else a Miss
    public ShotType ProcessShot(Coordinates coords)
    {
      var cell = OceanBoard.Cells.At(coords.Row, coords.Column);
      if (!cell.IsOccupied)
      {
        Console.WriteLine(Name + " says: \"Miss!\"");
        return ShotType.Miss;
      }
      var ship = Fleet.First(x => x.BattleShipType == cell.BattleShipType);
      ship.Hits++;
      Console.WriteLine(Name + " says: \"Hit!\"");
      return ShotType.Hit;
    }

  }
}