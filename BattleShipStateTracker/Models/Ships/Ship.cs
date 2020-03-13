using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BattleShipStateTracker.Models.Boards;

namespace BattleShipStateTracker.Models.Ships
{
  public abstract class Ship
  {
    [Required]
    [Display(Name = "Ship Name")]
    public string Name { get; set; }

    public BattleShipType BattleShipType { get; set; }

    public int Holes { get; set; }

    public int Hits { get; set; }

    public int Miss
    {
      get
      {
        return Hits;
      }
    }

    public bool IsSunk
    {
      get
      {
        return Hits >= Holes;
      }
    }

    public List<Coordinates> ShipCoordinates { get; set; }
  }
}
