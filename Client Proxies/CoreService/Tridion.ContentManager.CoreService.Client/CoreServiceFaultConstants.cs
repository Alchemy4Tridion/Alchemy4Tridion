using System;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	public class CoreServiceFaultConstants
	{
		public class Exceptions
		{
			public const string AccessTokenExpiredExceptionName = "ExpiredAccessTokenException";

			public const string InvalidAccessTokenExceptionName = "InvalidAccessTokenException";

			public const string ValidationExceptionName = "ValidationException";
		}

		public class TcmErrorCodes
		{
			public const string InvalidURL = "InvalidURL";

			public const string ItemIsCheckedOutByOtherUser = "ItemIsCheckedOutByOtherUser";

			public const string PermissionDenied = "PermissionDenied";

			public const string UniquenessConflict = "UniquenessConflict";

			public const string FeatureNotSupported = "FeatureNotSupported";

			public const string InvalidPropertyChange = "InvalidPropertyChange";

			public const string AccessDenied = "AccessDenied";

			public const string AssertFailed = "AssertFailed";

			public const string CannotPasteHere = "CannotPasteHere";

			public const string CircularLinkDetected = "CircularLinkDetected";

			public const string Conversion = "Conversion";

			public const string DirectoryCannotBeEmpty = "DirectoryCannotBeEmpty";

			public const string DuplicateFieldNames = "DuplicateFieldNames";

			public const string ElementNotFound = "ElementNotFound";

			public const string EventFailed = "EventFailed";

			public const string FieldDoesNotExist = "FieldDoesNotExist";

			public const string FileNotFound = "FileNotFound";

			public const string InvalidAction = "InvalidAction";

			public const string InvalidAssignment = "InvalidAssignment";

			public const string InvalidBlueprint = "InvalidBlueprint";

			public const string InvalidCharacters = "InvalidCharacters";

			public const string InvalidCodePage = "InvalidCodePage";

			public const string InvalidComponentPresentation = "InvalidComponentPresentation";

			public const string InvalidDateFormat = "InvalidDateFormat";

			public const string InvalidDestination = "InvalidDestination";

			public const string InvalidFtpRequest = "InvalidFtpRequest";

			public const string InvalidGroupMembership = "InvalidGroupMembership";

			public const string InvalidInclude = "InvalidInclude";

			public const string InvalidIndex = "InvalidIndex";

			public const string InvalidInheritanceRoot = "InvalidInheritanceRoot";

			public const string InvalidNamespace = "InvalidNamespace";

			public const string InvalidNumberFormat = "InvalidNumberFormat";

			public const string InvalidParameter = "InvalidParameter";

			public const string InvalidPath = "InvalidPath";

			public const string InvalidPermissions = "InvalidPermissions";

			public const string InvalidProtocol = "InvalidProtocol";

			public const string InvalidSchema = "InvalidSchema";

			public const string InvalidSchemaPurpose = "InvalidSchemaPurpose";

			public const string InvalidSearchFolderConfiguration = "InvalidSearchFolderConfiguration";

			public const string InvalidTargetGroupLink = "InvalidTargetGroupLink";

			public const string InvalidTrusteeScope = "InvalidTrusteeScope";

			public const string InvalidURI = "InvalidURI";

			public const string InvalidVersion = "InvalidVersion";

			public const string InvalidXML = "InvalidXML";

			public const string InvalidXSD = "InvalidXSD";

			public const string ItemAlreadyExists = "ItemAlreadyExists";

			public const string ItemDoesNotExist = "ItemDoesNotExist";

			public const string ItemIsBlueprintParent = "ItemIsBlueprintParent";

			public const string ItemIsCheckedOut = "ItemIsCheckedOut";

			public const string ItemIsInUse = "ItemIsInUse";

			public const string ItemIsInWorkflow = "ItemIsInWorkflow";

			public const string ItemIsLocalized = "ItemIsLocalized";

			public const string ItemIsNotCheckedOut = "ItemIsNotCheckedOut";

			public const string ItemIsNotLocalized = "ItemIsNotLocalized";

			public const string ItemIsPublished = "ItemIsPublished";

			public const string ItemIsShared = "ItemIsShared";

			public const string MissingAttribute = "MissingAttribute";

			public const string MissingElementOrType = "MissingElementOrType";

			public const string MixedLanguages = "MixedLanguages";

			public const string NoMultimedia = "NoMultimedia";

			public const string NoPrivileges = "NoPrivileges";

			public const string NoScriptEndMarker = "NoScriptEndMarker";

			public const string NumericalOperandRequired = "NumericalOperandRequired";

			public const string RecursiveCallDetected = "RecursiveCallDetected";

			public const string ReservedFileExtension = "ReservedFileExtension";

			public const string RootOrgItemAlreadyExists = "RootOrgItemAlreadyExists";

			public const string SchemaDoesNotExist = "SchemaDoesNotExist";

			public const string SQLException = "SQLException";

			public const string TrusteeIsPredefined = "TrusteeIsPredefined";

			public const string TypeMismatch = "TypeMismatch";

			public const string UnableToDownload = "UnableToDownload";

			public const string UnableToOpenInternetConnection = "UnableToOpenInternetConnection";

			public const string UnableToTransform = "UnableToTransform";

			public const string UnexpectedElement = "UnexpectedElement";

			public const string UnexpectedFieldType = "UnexpectedFieldType";

			public const string UnexpectedFileExtension = "UnexpectedFileExtension";

			public const string UnexpectedItemType = "UnexpectedItemType";

			public const string UnexpectedListType = "UnexpectedListType";

			public const string UnexpectedMultimediaType = "UnexpectedMultimediaType";

			public const string UnexpectedRootElement = "UnexpectedRootElement";

			public const string UnsupportedTargetLanguage = "UnsupportedTargetLanguage";

			public const string VersionDoesNotExist = "VersionDoesNotExist";

			public const string WrongApprovalStatus = "WrongApprovalStatus";

			public const string IncorrectConfiguration = "IncorrectConfiguration";

			public const string CachingNotActive = "CachingNotActive";

			public const string InvalidActivityState = "InvalidActivityState";

			public const string InvalidActivityType = "InvalidActivityType";

			public const string InvalidNextActivity = "InvalidNextActivity";

			public const string ADOConnectionError = "ADOConnectionError";

			public const string FeatureNotImplemented = "FeatureNotImplemented";

			public const string GeneralError = "GeneralError";

			public const string UnsupportedFileSize = "UnsupportedFileSize";

			public const string PublishInProgress = "PublishInProgress";

			public const string LicenseViolation = "LicenseViolation";

			public const string InvalidLicense = "InvalidLicense";

			public const string LicensedProductNotFound = "LicensedProductNotFound";

			public const string UnableToRenderPage = "UnableToRenderPage";

			public const string UnableToRenderComponent = "UnableToRenderComponent";

			public const string ItemIsInUseNoWhereUsed = "ItemIsInUseNoWhereUsed";

			public const string UnableToExecuteEvent = "UnableToExecuteEvent";

			public const string UnableToDeleteRootSgOfParent = "UnableToDeleteRootSgOfParent";

			public const string SearchError = "SearchError";

			public const string UnknownCacheLevel = "UnknownCacheLevel";

			public const string UnknownCacheLifetime = "UnknownCacheLifetime";

			public const string TooManyResults = "TooManyResults";

			public const string GeneralTypeRegistrationError = "GeneralTypeRegistrationError";

			public const string UnknownPublicationTypeId = "UnknownPublicationTypeId";

			public const string UnknownPublicationTypeName = "UnknownPublicationTypeName";

			public const string MissingTypeRegistryConfigurationError = "MissingTypeRegistryConfigurationError";

			public const string InvalidSchemaFieldValue = "InvalidSchemaFieldValue";

			public const string InvalidPropertyValue = "InvalidPropertyValue";

			public const string InvalidContextRepository = "InvalidContextRepository";

			public const string ItemIsLockedByOtherUser = "ItemIsLockedByOtherUser";

			public const string ItemIsNotLocked = "ItemIsNotLocked";

			public const string ItemIsLocked = "ItemIsLocked";

			public const string NotImplemented = "NotImplemented";

			public const string DeleteFailed = "DeleteFailed";

			public const string PublicationParentsChangeDenied = "PublicationParentsChangeDenied";

			public const string ItemCanBeCheckedInByWorkflow = "ItemCanBeCheckedInByWorkflow";

			public const string WorkflowNotSupported = "WorkflowNotSupported";

			public const string InvalidState = "InvalidState";

			public const string InvalidWorkflowType = "InvalidWorkflowType";

			public const string InvalidOwner = "InvalidOwner";

			public const string ItemIsReserved = "ItemIsReserved";

			public const string ClassificationConstraintViolation = "ClassificationConstraintViolation";

			public const string LocationConstraintViolation = "LocationConstraintViolation";

			public const string OccurenceConstraintViolation = "OccurenceConstraintViolation";

			public const string TypeConstraintViolation = "TypeConstraintViolation";

			public const string UnexpectedRegion = "UnexpectedRegion";

			public const string MissingRegion = "MissingRegion";

			public const string InvalidRegion = "InvalidRegion";

			public const string FileInUse = "FileInUse";

			public const string InvalidMapping = "InvalidMapping";

			public const string ItemModificationDetected = "ItemModificationDetected";

			public const string MissingDependency = "MissingDependency";

			public const string ProcessAborted = "ProcessAborted";

			public const string ImportExportException = "ImportExportException";

			public const string Timeout = "Timeout";

			public const string ProblemDiscovered = "ProblemDiscovered";

			public const string TopologyManagerException = "TopologyManagerException";

			public const string CdEnvironmentDoesNotHaveDeployerCapability = "CdEnvironmentDoesNotHaveDeployerCapability";

			public const string CdEnvironmentDoesNotHavePreviewWebServiceCapability = "CdEnvironmentDoesNotHavePreviewWebServiceCapability";

			public const string AuthenticationFailureInCdDiscoveryService = "AuthenticationFailureInCdDiscoveryService";

			public const string CommunicationErrorWithCdDiscoveryService = "CommunicationErrorWithCdDiscoveryService";

			public const string AuthenticationFailureInTopologyManager = "AuthenticationFailureInTopologyManager";

			public const string CommunicationErrorWithTopologyManager = "CommunicationErrorWithTopologyManager";

			public const string NoMappingFoundInTopologyManager = "NoMappingFoundInTopologyManager";

			public const string ItemHasPublishedItems = "ItemHasPublishedItems";

			public const string AccessTokenExpired = "AccessTokenExpired";

			public const string AccessTokenEmptySignature = "AccessTokenEmptySignature";

			public const string AccessTokenInvalidSignature = "AccessTokenInvalidSignature";

			public const string CdEnvironmentIsOffline = "CdEnvironmentIsOffline";

			public const string ItemIsNotLocalInPublication = "ItemIsNotLocalInPublication";

			public const string OrgItemIsNotLocalInPublication = "OrgItemIsNotLocalInPublication";

			public const string PromoteDestinationIsInvalid = "PromoteDestinationIsInvalid";

			public const string PromoteValidationFailed = "PromoteValidationFailed";

			public const string DemoteDestinationIsInvalid = "DemoteDestinationIsInvalid";

			public const string DemoteValidationFailed = "DemoteValidationFailed";

			public const string ValidationWarning = "ValidationWarning";

			public const string ValidationError = "ValidationError";

			public const string MismatchExpectedValueInDb = "MismatchExpectedValueInDb";

			public const string LocalizeValidationFailed = "LocalizeValidationFailed";

			public const string UnLocalizeValidationFailed = "UnLocalizeValidationFailed";

			public const string MoveValidationFailed = "MoveValidationFailed";

			public const string UnknownVFType = "UnknownVFType";

			public const string ClassNotRegistered = "ClassNotRegistered";

			public const string InvalidFilterCondition = "InvalidFilterCondition";

			public const string InvalidConditionType = "InvalidConditionType";

			public const string InvalidConditionOperator = "InvalidConditionOperator";

			public const string GeneralTemplateTypeError = "GeneralTemplateTypeError";

			public const string UnknownTemplateTypeName = "UnknownTemplateTypeName";
		}
	}
}
