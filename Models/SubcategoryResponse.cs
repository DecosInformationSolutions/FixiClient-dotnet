﻿namespace Decos.Fixi.Models
{
  /// <summary>
  /// Represents a category in the response.
  /// </summary>
  public class SubcategoryResponse : CategoryResponse
  {
    /// <summary>
    /// The short name of the main category.
    /// </summary>
    public string Parent { get; set; }
  }
}