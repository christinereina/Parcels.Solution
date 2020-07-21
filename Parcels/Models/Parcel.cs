namespace Parcels.Models
{
  public class Parcel
  {
    private int Length { get; set; }
    private int Width { get; set; }
    private int Height { get; set; }
    private int Weight {get; set; }

    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
    }

    public int Volume()
    {
      return Length * Width * Height;
    }

    public int CostToShip()
    {
      int dimensionalWeight = Volume()/139;
      if (Weight > dimensionalWeight)
      {
        return Weight * 0.5;
      }
      else
      {
        return (dimensionalWeight * 0.5);
      }
    }
  }
}