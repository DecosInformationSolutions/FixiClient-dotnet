﻿using System;

namespace Decos.Fixi
{
  /// <summary>
  /// Represents a region in a response.
  /// </summary>
  public class RegionResponse
  {
    /// <summary>
    /// Gets or sets the point in time the region was created.
    /// </summary>
    public DateTimeOffset? Created { get; set; }

    /// <summary>
    /// Gets or sets the name of the culture used in the region, e.g. en-US.
    /// </summary>
    public string Culture { get; set; }

    /// <summary>
    /// Gets or sets the contact email address for the region.
    /// </summary>
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets an integer that identifies the map layer on which the region
    /// is located. Higher values indicate more specific regions.
    /// </summary>
    public int Layer { get; set; }

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
    /// Gets or sets the point in time the region was last modified.
    /// </summary>
    public DateTimeOffset? Modified { get; set; }

    /// <summary>
    /// Gets or sets the displayed name of the region.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the short name of the organization that manages the region.
    /// </summary>
    public string Organization { get; set; }

    /// <summary>
    /// Gets or sets the displayed name of the organization that manages the region.
    /// </summary>
    public string OrganizationName { get; set; }

    /// <summary>
    /// Gets or sets the short name of the region.
    /// </summary>
    public string ShortName { get; set; }
  }
}