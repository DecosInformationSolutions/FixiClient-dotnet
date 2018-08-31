﻿namespace Decos.Fixi
{
  /// <summary>
  /// Represents a category in the response.
  /// </summary>
  public class Subcategory : Category
  {
    /// <summary>
    /// The short name of the main category.
    /// </summary>
    public string Parent { get; set; }
  }
}