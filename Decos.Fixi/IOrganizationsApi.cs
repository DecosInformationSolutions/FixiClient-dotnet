using System;
using System.Threading;
using System.Threading.Tasks;
using Decos.Fixi.Models;
using Refit;

namespace Decos.Fixi
{
  /// <summary>
  /// Defines the methods available in the Fixi organizations API.
  /// </summary>
  public interface IOrganizationsApi
  {
    /// <summary>
    /// Returns a list of organizations, ordered by name.
    /// </summary>
    /// <param name="page">An optional non-zero positive integer indicating the number of the page to retrieve.</param>
    /// <param name="count">An optional non-zero positive integer indicating the number of results to return per page.</param>
    /// <param name="country">An optional country parameter to filter results</param>
    /// <param name="searchText">An optional filter to search organizations by name.</param>
    /// <param name="paidCustomerFilter">An optional filter to get paid/ non paid customers.</param>
    /// <param name="reportRegionsFilter">An optional filter to get Report Regions customers.</param>
    /// <param name="categoryPredictionFilter">An optional filter to get Category Prediction customers.</param>
    /// <param name="requiredHandlingFilter">An optional filter to get Required Handling customers.</param>
    /// <param name="issueHandlingFilter">An optional filter to get Required Handling customers.</param>
    /// <param name="anonymousReportFilter">An optional filter to get Anonymous Report customers.</param>
    /// <param name="publicCommentsForCitizenFilter">An optional filter to get Public Comments for Citizen customers.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [Get("/organizations/listAdmin")]
    Task<ListPage<Organization>> FindAsync(
        int page = 1,
        int count = 20,
        string country = null,
        string searchText = null,
        PaidCustomerFilter paidCustomerFilter = PaidCustomerFilter.SelectPaidFilter,
        BooleanFilter reportRegionsFilter = BooleanFilter.NoSelection,
        BooleanFilter categoryPredictionFilter = BooleanFilter.NoSelection,
        BooleanFilter requiredHandlingFilter = BooleanFilter.NoSelection,
        IssueHandling issueHandlingFilter = IssueHandling.WithoutPhotoOrComment,
        BooleanFilter anonymousReportFilter = BooleanFilter.NoSelection,
        BooleanFilter publicCommentsForCitizenFilter = BooleanFilter.NoSelection,
        CancellationToken cancellationToken = default(CancellationToken));

    /// <summary>
    /// Returns the organization with the specified identifier.
    /// </summary>
    /// <param name="id">The short name of the organization to find.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [Get("/organizations/{id}")]
    Task<Organization> FindByIdAsync(
        string id,
        CancellationToken cancellationToken = default(CancellationToken));

    /// <summary>
    /// Creates a new organization.
    /// </summary>
    /// <param name="data">The organization data.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [Post("/organizations")]
    Task<Organization> PostAsync(
        Organization data,
        CancellationToken cancellationToken = default(CancellationToken));

    /// <summary>
    /// Updates an existing organization.
    /// </summary>
    /// <param name="id">The short name of the organization to update.</param>
    /// <param name="data">The modified organization data.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [Patch("/organizations/{id}")]
    Task<Organization> UpdateAsync(
        string id,
        Organization data,
        CancellationToken cancellationToken = default(CancellationToken));
  }
}

public enum PaidCustomerFilter
{
  SelectPaidFilter = 0,
  Paying = 1,
  NonPaying = 2,
}

public enum BooleanFilter
{
  NoSelection = 0,
  True = 1,
  False = 2
}

public enum IssueHandling
{
  WithoutPhotoOrComment = 0,
  WithPhotoOrComment = 1,
  WithPhoto = 2,
  WithComment = 3,
  WithPhotoAndComment = 4
}