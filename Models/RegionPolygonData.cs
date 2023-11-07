namespace Decos.Fixi.Models
{
  /// <summary>
  /// RegionPolygonData
  /// </summary>
  public class RegionPolygonData
  {
    /// <summary>
    /// The short name of the region.
    /// </summary>
    public string ShortName { get; set; }

    /// <summary>
    /// The displayed name of the region.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// An integer that identifies the map layer on which the region is located.
    /// Higher values indicate more specific regions.
    /// </summary>
    public int Layer { get; set; }

    /// <summary>
    /// The approximate southernmost latitude of the region.
    /// </summary>
    public double? MinLatitude { get; set; }

    /// <summary>
    /// The approximate westernmost longitude of the region.
    /// </summary>
    public double? MinLongitude { get; set; }

    /// <summary>
    /// The approximate northernmost latitude of the region.
    /// </summary>
    public double? MaxLatitude { get; set; }

    /// <summary>
    /// The approximate easternmost longitude of the region.
    /// </summary>
    public double? MaxLongitude { get; set; }

    /// <summary>
    /// Gets or sets a polygon that represents the area covered by the region.
    /// </summary>
    public Polygon Polygon { get; set; }
  }
}