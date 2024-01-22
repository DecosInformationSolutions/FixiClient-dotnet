﻿using System;

namespace Decos.Fixi.Models
{
  /// <summary>
  /// Represents the modifiable properties of a region.
  /// </summary>
  public class ReportRegionData
  {
    /// <summary>
    /// Gets or sets an integer that identifies the map layer on which the region
    /// is located. Higher values indicate smaller, more specific regions.
    /// </summary>
    public int? Layer { get; set; }

    /// <summary>
    /// Gets or sets the approximate northernmost latitude of the region.
    /// </summary>
    public double? MaxLatitude { get; set; }

    /// <summary>
    /// Gets or sets the approximate easternmost longitude of the region.
    /// </summary>
    public double? MaxLongitude { get; set; }

    /// <summary>
    /// Gets or sets the approximate southernmost latitude of the region.
    /// </summary>
    public double? MinLatitude { get; set; }

    /// <summary>
    /// Gets or sets the approximate westernmost longitude of the region.
    /// </summary>
    public double? MinLongitude { get; set; }

    /// <summary>
    /// Gets or sets a name for the region.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the short name of the organization that owns the region, or
    /// a null reference if the region is not owned by a customer.
    /// </summary>
    public string OrganizationName { get; set; }

    /// <summary>
    /// Gets or sets a polygon that represents the area covered by the region.
    /// </summary>
    public Polygon Polygon { get; set; }
  }
}
