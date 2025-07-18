﻿using System;

namespace Decos.Fixi.Models
{
  /// <summary>
  /// Represents an organization using Fixi.
  /// </summary>
  public class Organization
  {
    /// <summary>
    /// Gets or sets an identifier of the case type to use when syncing with JOIN.
    /// </summary>
    public string CaseTypeIdentifier { get; set; }

    /// <summary>
    /// Gets or sets a URI to the BasicHttpEntityService to use when syncing with
    /// JOIN. HTTP, HTTPS and Service Bus Relay bindings are supported.
    /// </summary>
    public string ConnectEntityServiceUri { get; set; }

    /// <summary>
    /// Gets or sets the Connect system ID to use when syncing with JOIN.
    /// </summary>
    public string ConnectSystemID { get; set; }

    /// <summary>
    /// Gets or sets the Connect system password to use when syncing with JOIN.
    /// This property is write-only and will not be returned by the API.
    /// </summary>
    public string ConnectSystemPassword { get; set; }

    /// <summary>
    /// Gets or sets the IDP customer ID, or a null reference if the organization
    /// is not a customer.
    /// </summary>
    public Guid? CustomerID { get; set; }

    /// <summary>
    /// Gets or sets a value that describes whether the organization is a paid customer or not
    /// </summary>
    public bool IsPaidCustomer { get; set; }

    /// <summary>
    /// Gets or sets a value that describes whether the organization has report regions enabled or not
    /// </summary>
    public bool IsReportRegionsEnabled { get; set; }
    
    /// <summary>
    /// Gets or sets a value that describes whether the organization has auto category selection enabled or not
    /// </summary>
    public bool EnableCategoryPrediction { get; set; }

    /// <summary>
    /// Gets or sets the email address of the organization where replies should
    /// be sent to.
    /// </summary>
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the email address used for sending notifications.
    /// </summary>
    public string NotificationEmailAddress { get; set; }

    /// <summary>
    /// Type of the integration organization communicating.
    /// </summary>
    public IntegrationType IntegrationType { get; set; }

    /// <summary>
    /// Gets or sets an connect configuration id of the organization that is used to connect with join
    /// </summary>
    public string IntegrationConfiguration { get; set; }

    /// <summary>
    /// Gets or sets a ZSDMS configuration that is used to sync data with other applications.
    /// </summary>
    public ZsdmsConfiguration ZsdmsConfiguration { get; set; }

    /// <summary>
    /// Gets or sets the name of the organization.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets a short, URL-friendly name that uniquely identifies the organization.
    /// </summary>
    public string ShortName { get; set; }

    /// <summary>
    /// Get or set country name of the organization
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Get or set language preference of the organization
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// Gets or sets the URL to the website of the organization.
    /// </summary>
    public string WebsiteAddress { get; set; }

    /// <summary>
    /// Custom feedback URL for organization
    /// </summary>
    public string FeedBackUrl { get; set; }

    /// <summary>
    /// Gets or sets the email domains of the organization (',' seperated).
    /// </summary>
    public string EmailDomains { get; set; }

    /// <summary>
    /// Gets or sets a value that indicates whether issues reported for this
    /// organization should be public by default.
    /// </summary>
    public BooleanDefault DefaultVisibility { get; set; }

    /// <summary>
    /// Gets or sets a value that describes whether the organization supports 
    /// anonymous issue reports or not.
    /// </summary>
    public bool ToReportAnonymous { get; set; }

    /// <summary>
    ///  Gets or sets a value that describes whether the organization requires subcategory for handling issues
    /// </summary>
    public bool RequireSubCatForHandling { get; set; }
    
    /// <summary>
    ///  Gets or sets a value that determines whether the reporter's details are visible in the printed issue
    /// </summary>
    public bool ShowReporterDetailsInPrint { get; set; }

    /// <summary>
    /// Gets or sets a value that describes whether atleast one field in issue 
    /// handle screen is required while handling issue or not.
    /// </summary>
    public bool ToValidateIssueHandle { get; set; }

    /// <summary>
    /// Get or set the options that the handler must process to handle the issue.
    /// </summary>
    public IssueHandling IssueHandling { get; set; }

    /// <summary>
    /// Get or set the value that Show/Hide option for automatically handle issues after forwarding.
    /// </summary>
    public bool AllowAutoHandleOnForward { get; set; }

    /// <summary>
    ///  Gets or sets a value that determines customer specific host domain
    /// </summary>
    public string HostDomainUrl { get; set; }

    /// <summary>
    ///  Gets or sets a value that describes whether the organization allows public comments by citizen
    /// </summary>
    public bool AllowCitizenPublicComment { get; set; }

    /// <summary>
    /// Time zone id of the organization
    /// </summary>
    public string TimeZoneId { get; set; }
  }
}