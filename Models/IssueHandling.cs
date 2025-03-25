using System;

namespace Decos.Fixi.Models
{
  /// <summary>
  /// Represents the options that the handler must process to handle the issue.
  /// </summary>
  public enum IssueHandling
  {
    /// <summary>
    /// No photo and no comment.
    /// </summary>
    WithoutPhotoOrComment = 0,

    /// <summary>
    /// Either a photo or a comment is present.
    /// </summary>
    WithPhotoOrComment = 1,

    /// <summary>
    /// Only a photo is present.
    /// </summary>
    WithPhoto = 2,

    /// <summary>
    /// Only a comment is present.
    /// </summary>
    WithComment = 3,

    /// <summary>
    /// Both a photo and a comment are present.
    /// </summary>
    WithPhotoAndComment = 4
  }
}