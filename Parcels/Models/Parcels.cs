using System.Collections.Generic;

namespace ParcelSolution.Models
{
  public class Parcels
  {
    public int Length { get; set; }
    public int Depth { get; set; }
    public int Width { get; set; }
    public int Volume { get; set; }
    public int Weight { get; set; }

    private static List<Parcels> _instances = new List<Parcels> { };


    public Parcels(int length, int depth, int width, int weight)
    {
      Length = length; // in feet
      Depth = depth; // in feet
      Width = width; // in feet
      Volume = Length * Width * Depth; // in feet
      Weight = weight; // in pounds
      _instances.Add(this);
    }

    public static List<Parcels> GetAll()
    {
      return _instances;
    }

    public string CostToShip()
    {
      int cost = (Volume * 20) + (Weight * 20);
      string totalCost = cost.ToString();
      return totalCost;
    }
  }
}