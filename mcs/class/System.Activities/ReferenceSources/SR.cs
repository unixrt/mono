using System;
using System.Globalization;
using System.Resources;

namespace System.Activities
{
    internal class SR
    {
        private static ResourceManager resourceManager;

        private static CultureInfo resourceCulture;

        internal static string AbortingDueToDynamicUpdateFailure
        {
            get
            {
                return SR.ResourceManager.GetString("AbortingDueToDynamicUpdateFailure", SR.Culture);
            }
        }

        internal static string AbortingDueToInstanceTimeout
        {
            get
            {
                return SR.ResourceManager.GetString("AbortingDueToInstanceTimeout", SR.Culture);
            }
        }

        internal static string AbortingDueToLoadFailure
        {
            get
            {
                return SR.ResourceManager.GetString("AbortingDueToLoadFailure", SR.Culture);
            }
        }

        internal static string AbortingDueToVersionMismatch
        {
            get
            {
                return SR.ResourceManager.GetString("AbortingDueToVersionMismatch", SR.Culture);
            }
        }

        internal static string AbortInstanceOnTransactionFailureDoesNotMatch
        {
            get
            {
                return SR.ResourceManager.GetString("AbortInstanceOnTransactionFailureDoesNotMatch", SR.Culture);
            }
        }

        internal static string ActivityFailedToOpenBefore
        {
            get
            {
                return SR.ResourceManager.GetString("ActivityFailedToOpenBefore", SR.Culture);
            }
        }

        internal static string ActivityInstanceFixupFailed
        {
            get
            {
                return SR.ResourceManager.GetString("ActivityInstanceFixupFailed", SR.Culture);
            }
        }

        internal static string ActivityIsNotRoot
        {
            get
            {
                return SR.ResourceManager.GetString("ActivityIsNotRoot", SR.Culture);
            }
        }

        internal static string ActivityIsUncached
        {
            get
            {
                return SR.ResourceManager.GetString("ActivityIsUncached", SR.Culture);
            }
        }

        internal static string ActivityMapIsCorrupt
        {
            get
            {
                return SR.ResourceManager.GetString("ActivityMapIsCorrupt", SR.Culture);
            }
        }

        internal static string ActivityNotICompiledExpressionRoot
        {
            get
            {
                return SR.ResourceManager.GetString("ActivityNotICompiledExpressionRoot", SR.Culture);
            }
        }

        internal static string ActivityXamlServiceLineString
        {
            get
            {
                return SR.ResourceManager.GetString("ActivityXamlServiceLineString", SR.Culture);
            }
        }

        internal static string AddedIdleExpressionBlockDU
        {
            get
            {
                return SR.ResourceManager.GetString("AddedIdleExpressionBlockDU", SR.Culture);
            }
        }

        internal static string AECDisposed
        {
            get
            {
                return SR.ResourceManager.GetString("AECDisposed", SR.Culture);
            }
        }

        internal static string AECForPropertiesHasBeenDisposed
        {
            get
            {
                return SR.ResourceManager.GetString("AECForPropertiesHasBeenDisposed", SR.Culture);
            }
        }

        internal static string AlreadySetupNoPersist
        {
            get
            {
                return SR.ResourceManager.GetString("AlreadySetupNoPersist", SR.Culture);
            }
        }

        internal static string ArgumentMustbePropertyofWorkflowElement
        {
            get
            {
                return SR.ResourceManager.GetString("ArgumentMustbePropertyofWorkflowElement", SR.Culture);
            }
        }

        internal static string ArgumentNameRequired
        {
            get
            {
                return SR.ResourceManager.GetString("ArgumentNameRequired", SR.Culture);
            }
        }

        internal static string ArgumentTypeCannotBeNull
        {
            get
            {
                return SR.ResourceManager.GetString("ArgumentTypeCannotBeNull", SR.Culture);
            }
        }

        internal static string AssemblyReferenceIsImmutable
        {
            get
            {
                return SR.ResourceManager.GetString("AssemblyReferenceIsImmutable", SR.Culture);
            }
        }

        internal static string AsyncMethodsMustAllBeStaticOrInstance
        {
            get
            {
                return SR.ResourceManager.GetString("AsyncMethodsMustAllBeStaticOrInstance", SR.Culture);
            }
        }

        internal static string AsyncMethodsMustFromSameType
        {
            get
            {
                return SR.ResourceManager.GetString("AsyncMethodsMustFromSameType", SR.Culture);
            }
        }

        internal static string BadCopyToArray
        {
            get
            {
                return SR.ResourceManager.GetString("BadCopyToArray", SR.Culture);
            }
        }

        internal static string BadWorkflowIdentityFormat
        {
            get
            {
                return SR.ResourceManager.GetString("BadWorkflowIdentityFormat", SR.Culture);
            }
        }

        internal static string BeforeInitializeComponentXBTExtensionResourceNotFound
        {
            get
            {
                return SR.ResourceManager.GetString("BeforeInitializeComponentXBTExtensionResourceNotFound", SR.Culture);
            }
        }

        internal static string BeginExecuteMustNotReturnANullAsyncResult
        {
            get
            {
                return SR.ResourceManager.GetString("BeginExecuteMustNotReturnANullAsyncResult", SR.Culture);
            }
        }

        internal static string BeginExecuteMustUseProvidedStateAsAsyncResultState
        {
            get
            {
                return SR.ResourceManager.GetString("BeginExecuteMustUseProvidedStateAsAsyncResultState", SR.Culture);
            }
        }

        internal static string BlockedUpdateInsideActivityUpdateByUserError
        {
            get
            {
                return SR.ResourceManager.GetString("BlockedUpdateInsideActivityUpdateByUserError", SR.Culture);
            }
        }

        internal static string BlockedUpdateInsideActivityUpdateError
        {
            get
            {
                return SR.ResourceManager.GetString("BlockedUpdateInsideActivityUpdateError", SR.Culture);
            }
        }

        internal static string BookmarkNotFoundGeneric
        {
            get
            {
                return SR.ResourceManager.GetString("BookmarkNotFoundGeneric", SR.Culture);
            }
        }

        internal static string BookmarkScopeAlreadyInitialized
        {
            get
            {
                return SR.ResourceManager.GetString("BookmarkScopeAlreadyInitialized", SR.Culture);
            }
        }

        internal static string BookmarkScopeHasBookmarks
        {
            get
            {
                return SR.ResourceManager.GetString("BookmarkScopeHasBookmarks", SR.Culture);
            }
        }

        internal static string BookmarkScopeNotRegisteredForInitialize
        {
            get
            {
                return SR.ResourceManager.GetString("BookmarkScopeNotRegisteredForInitialize", SR.Culture);
            }
        }

        internal static string BookmarkScopeNotRegisteredForUnregister
        {
            get
            {
                return SR.ResourceManager.GetString("BookmarkScopeNotRegisteredForUnregister", SR.Culture);
            }
        }

        internal static string BookmarkScopesRequireKeys
        {
            get
            {
                return SR.ResourceManager.GetString("BookmarkScopesRequireKeys", SR.Culture);
            }
        }

        internal static string BookmarksOnlyResumableWhileIdle
        {
            get
            {
                return SR.ResourceManager.GetString("BookmarksOnlyResumableWhileIdle", SR.Culture);
            }
        }

        internal static string CannotAddHandlesUpdateError
        {
            get
            {
                return SR.ResourceManager.GetString("CannotAddHandlesUpdateError", SR.Culture);
            }
        }

        internal static string CannotAddOrRemoveWithChildren
        {
            get
            {
                return SR.ResourceManager.GetString("CannotAddOrRemoveWithChildren", SR.Culture);
            }
        }

        internal static string CannotCallAbortInstanceFromWorkflowThread
        {
            get
            {
                return SR.ResourceManager.GetString("CannotCallAbortInstanceFromWorkflowThread", SR.Culture);
            }
        }

        internal static string CannotChangeAbortInstanceFlagAfterPropertyRegistration
        {
            get
            {
                return SR.ResourceManager.GetString("CannotChangeAbortInstanceFlagAfterPropertyRegistration", SR.Culture);
            }
        }

        internal static string CannotChangeMatchesInImplementation
        {
            get
            {
                return SR.ResourceManager.GetString("CannotChangeMatchesInImplementation", SR.Culture);
            }
        }

        internal static string CannotCompleteRuntimeOwnedTransaction
        {
            get
            {
                return SR.ResourceManager.GetString("CannotCompleteRuntimeOwnedTransaction", SR.Culture);
            }
        }

        internal static string CannotCreateOwnerWithoutIdentity
        {
            get
            {
                return SR.ResourceManager.GetString("CannotCreateOwnerWithoutIdentity", SR.Culture);
            }
        }

        internal static string CannotEnlistMultipleTransactions
        {
            get
            {
                return SR.ResourceManager.GetString("CannotEnlistMultipleTransactions", SR.Culture);
            }
        }

        internal static string CanNotFindSymbolResolverInWorkflowInstanceExtensions
        {
            get
            {
                return SR.ResourceManager.GetString("CanNotFindSymbolResolverInWorkflowInstanceExtensions", SR.Culture);
            }
        }

        internal static string CannotGetValueOfOutArgument
        {
            get
            {
                return SR.ResourceManager.GetString("CannotGetValueOfOutArgument", SR.Culture);
            }
        }

        internal static string CannotInvokeOpenedActivity
        {
            get
            {
                return SR.ResourceManager.GetString("CannotInvokeOpenedActivity", SR.Culture);
            }
        }

        internal static string CannotModifyCatchAfterOpen
        {
            get
            {
                return SR.ResourceManager.GetString("CannotModifyCatchAfterOpen", SR.Culture);
            }
        }

        internal static string CannotMoveChildAcrossDifferentFlowNodeTypes
        {
            get
            {
                return SR.ResourceManager.GetString("CannotMoveChildAcrossDifferentFlowNodeTypes", SR.Culture);
            }
        }

        internal static string CannotPerformOperationFromHandlerThread
        {
            get
            {
                return SR.ResourceManager.GetString("CannotPerformOperationFromHandlerThread", SR.Culture);
            }
        }

        internal static string CannotPerformOperationOnHandle
        {
            get
            {
                return SR.ResourceManager.GetString("CannotPerformOperationOnHandle", SR.Culture);
            }
        }

        internal static string CannotPersistInsideIsolation
        {
            get
            {
                return SR.ResourceManager.GetString("CannotPersistInsideIsolation", SR.Culture);
            }
        }

        internal static string CannotPersistInsideNoPersist
        {
            get
            {
                return SR.ResourceManager.GetString("CannotPersistInsideNoPersist", SR.Culture);
            }
        }

        internal static string CannotPersistWhileDetached
        {
            get
            {
                return SR.ResourceManager.GetString("CannotPersistWhileDetached", SR.Culture);
            }
        }

        internal static string CannotResetPropertyInDataContext
        {
            get
            {
                return SR.ResourceManager.GetString("CannotResetPropertyInDataContext", SR.Culture);
            }
        }

        internal static string CannotSaveOriginalValueForActivity
        {
            get
            {
                return SR.ResourceManager.GetString("CannotSaveOriginalValueForActivity", SR.Culture);
            }
        }

        internal static string CannotSaveOriginalValuesForReferencedChildren
        {
            get
            {
                return SR.ResourceManager.GetString("CannotSaveOriginalValuesForReferencedChildren", SR.Culture);
            }
        }

        internal static string CannotScheduleChildrenWhileEnteringIsolation
        {
            get
            {
                return SR.ResourceManager.GetString("CannotScheduleChildrenWhileEnteringIsolation", SR.Culture);
            }
        }

        internal static string CannotSerializeVariableExpression
        {
            get
            {
                return SR.ResourceManager.GetString("CannotSerializeVariableExpression", SR.Culture);
            }
        }

        internal static string CannotSetRuntimeTransactionInNoPersist
        {
            get
            {
                return SR.ResourceManager.GetString("CannotSetRuntimeTransactionInNoPersist", SR.Culture);
            }
        }

        internal static string CannotSetupIsolationInsideIsolation
        {
            get
            {
                return SR.ResourceManager.GetString("CannotSetupIsolationInsideIsolation", SR.Culture);
            }
        }

        internal static string CannotSetupIsolationInsideNoPersist
        {
            get
            {
                return SR.ResourceManager.GetString("CannotSetupIsolationInsideNoPersist", SR.Culture);
            }
        }

        internal static string CannotSetupIsolationWithChildren
        {
            get
            {
                return SR.ResourceManager.GetString("CannotSetupIsolationWithChildren", SR.Culture);
            }
        }

        internal static string CannotSetValueOfInArgument
        {
            get
            {
                return SR.ResourceManager.GetString("CannotSetValueOfInArgument", SR.Culture);
            }
        }

        internal static string CannotSuppressAlreadyRegisteredHandle
        {
            get
            {
                return SR.ResourceManager.GetString("CannotSuppressAlreadyRegisteredHandle", SR.Culture);
            }
        }

        internal static string CannotUnregisterDefaultBookmarkScope
        {
            get
            {
                return SR.ResourceManager.GetString("CannotUnregisterDefaultBookmarkScope", SR.Culture);
            }
        }

        internal static string CannotUnregisterNullBookmarkScope
        {
            get
            {
                return SR.ResourceManager.GetString("CannotUnregisterNullBookmarkScope", SR.Culture);
            }
        }

        internal static string CannotUpdateEnvironmentInTheMiddleOfResolvingArguments
        {
            get
            {
                return SR.ResourceManager.GetString("CannotUpdateEnvironmentInTheMiddleOfResolvingArguments", SR.Culture);
            }
        }

        internal static string CannotUpdateEnvironmentInTheMiddleOfResolvingVariables
        {
            get
            {
                return SR.ResourceManager.GetString("CannotUpdateEnvironmentInTheMiddleOfResolvingVariables", SR.Culture);
            }
        }

        internal static string CannotUseInputsWithLoad
        {
            get
            {
                return SR.ResourceManager.GetString("CannotUseInputsWithLoad", SR.Culture);
            }
        }

        internal static string CannotWaitForIdleSynchronously
        {
            get
            {
                return SR.ResourceManager.GetString("CannotWaitForIdleSynchronously", SR.Culture);
            }
        }

        internal static string CanOnlyAbortDirectChildren
        {
            get
            {
                return SR.ResourceManager.GetString("CanOnlyAbortDirectChildren", SR.Culture);
            }
        }

        internal static string CanOnlyCancelDirectChildren
        {
            get
            {
                return SR.ResourceManager.GetString("CanOnlyCancelDirectChildren", SR.Culture);
            }
        }

        internal static string CantFindTimerExtension
        {
            get
            {
                return SR.ResourceManager.GetString("CantFindTimerExtension", SR.Culture);
            }
        }

        internal static string ChangeConditionalTransitionToUnconditionalBlockDU
        {
            get
            {
                return SR.ResourceManager.GetString("ChangeConditionalTransitionToUnconditionalBlockDU", SR.Culture);
            }
        }

        internal static string ChangeTransitionTypeDuringTransitioningBlockDU
        {
            get
            {
                return SR.ResourceManager.GetString("ChangeTransitionTypeDuringTransitioningBlockDU", SR.Culture);
            }
        }

        internal static string ChangingTriggerOrUseOriginalConditionActionBlockDU
        {
            get
            {
                return SR.ResourceManager.GetString("ChangingTriggerOrUseOriginalConditionActionBlockDU", SR.Culture);
            }
        }

        internal static string CompensableActivityAlreadyConfirmedOrCompensated
        {
            get
            {
                return SR.ResourceManager.GetString("CompensableActivityAlreadyConfirmedOrCompensated", SR.Culture);
            }
        }

        internal static string CompensableActivityInsideTransactionScopeActivity
        {
            get
            {
                return SR.ResourceManager.GetString("CompensableActivityInsideTransactionScopeActivity", SR.Culture);
            }
        }

        internal static string CompensateWithNoTargetConstraint
        {
            get
            {
                return SR.ResourceManager.GetString("CompensateWithNoTargetConstraint", SR.Culture);
            }
        }

        internal static string CompiledExpressionsIgnoringUnnamedVariable
        {
            get
            {
                return SR.ResourceManager.GetString("CompiledExpressionsIgnoringUnnamedVariable", SR.Culture);
            }
        }

        internal static string CompiledLocationReferenceGetLocation
        {
            get
            {
                return SR.ResourceManager.GetString("CompiledLocationReferenceGetLocation", SR.Culture);
            }
        }

        internal static string CompilerError
        {
            get
            {
                return SR.ResourceManager.GetString("CompilerError", SR.Culture);
            }
        }

        internal static string ConfirmWithNoTargetConstraint
        {
            get
            {
                return SR.ResourceManager.GetString("ConfirmWithNoTargetConstraint", SR.Culture);
            }
        }

        internal static string ConstVariableCannotBeSet
        {
            get
            {
                return SR.ResourceManager.GetString("ConstVariableCannotBeSet", SR.Culture);
            }
        }

        internal static string ControllerInvalidBeforeInitialize
        {
            get
            {
                return SR.ResourceManager.GetString("ControllerInvalidBeforeInitialize", SR.Culture);
            }
        }

        internal static string CopyToIndexOutOfRange
        {
            get
            {
                return SR.ResourceManager.GetString("CopyToIndexOutOfRange", SR.Culture);
            }
        }

        internal static string CopyToNotEnoughSpaceInArray
        {
            get
            {
                return SR.ResourceManager.GetString("CopyToNotEnoughSpaceInArray", SR.Culture);
            }
        }

        internal static string CopyToRankMustBeOne
        {
            get
            {
                return SR.ResourceManager.GetString("CopyToRankMustBeOne", SR.Culture);
            }
        }

        internal static string CreateBookmarkScopeFailed
        {
            get
            {
                return SR.ResourceManager.GetString("CreateBookmarkScopeFailed", SR.Culture);
            }
        }

        internal static string CSharpExpressionsMustBeCompiled
        {
            get
            {
                return SR.ResourceManager.GetString("CSharpExpressionsMustBeCompiled", SR.Culture);
            }
        }

        internal static CultureInfo Culture
        {
            get
            {
                return SR.resourceCulture;
            }
            set
            {
                SR.resourceCulture = value;
            }
        }

        internal static string DebugInfoNotSkipArgumentResolution
        {
            get
            {
                return SR.ResourceManager.GetString("DebugInfoNotSkipArgumentResolution", SR.Culture);
            }
        }

        internal static string DebugInfoTryGetValueFailed
        {
            get
            {
                return SR.ResourceManager.GetString("DebugInfoTryGetValueFailed", SR.Culture);
            }
        }

        internal static string DebugSymbolChecksumValueInvalid
        {
            get
            {
                return SR.ResourceManager.GetString("DebugSymbolChecksumValueInvalid", SR.Culture);
            }
        }

        internal static string DefaultAbortReason
        {
            get
            {
                return SR.ResourceManager.GetString("DefaultAbortReason", SR.Culture);
            }
        }

        internal static string DefaultCancelationRequiresCancelHasBeenRequested
        {
            get
            {
                return SR.ResourceManager.GetString("DefaultCancelationRequiresCancelHasBeenRequested", SR.Culture);
            }
        }

        internal static string DefaultInvalidWorkflowExceptionMessage
        {
            get
            {
                return SR.ResourceManager.GetString("DefaultInvalidWorkflowExceptionMessage", SR.Culture);
            }
        }

        internal static string DefaultWorkflowApplicationExceptionMessage
        {
            get
            {
                return SR.ResourceManager.GetString("DefaultWorkflowApplicationExceptionMessage", SR.Culture);
            }
        }

        internal static string DelegateArgumentChangeBlockDU
        {
            get
            {
                return SR.ResourceManager.GetString("DelegateArgumentChangeBlockDU", SR.Culture);
            }
        }

        internal static string DelegateArgumentMustBeSet
        {
            get
            {
                return SR.ResourceManager.GetString("DelegateArgumentMustBeSet", SR.Culture);
            }
        }

        internal static string DictionaryIsReadOnly
        {
            get
            {
                return SR.ResourceManager.GetString("DictionaryIsReadOnly", SR.Culture);
            }
        }

        internal static string DirectLambdaParameterReference
        {
            get
            {
                return SR.ResourceManager.GetString("DirectLambdaParameterReference", SR.Culture);
            }
        }

        internal static string DUActivityTypeMismatchRuntime
        {
            get
            {
                return SR.ResourceManager.GetString("DUActivityTypeMismatchRuntime", SR.Culture);
            }
        }

        internal static string DUDisallowIfCannotFindingMatchingCondition
        {
            get
            {
                return SR.ResourceManager.GetString("DUDisallowIfCannotFindingMatchingCondition", SR.Culture);
            }
        }

        internal static string DUTriggerOrConditionChangedDuringTransitioning
        {
            get
            {
                return SR.ResourceManager.GetString("DUTriggerOrConditionChangedDuringTransitioning", SR.Culture);
            }
        }

        internal static string EmptyGuidOnDeserializedInstance
        {
            get
            {
                return SR.ResourceManager.GetString("EmptyGuidOnDeserializedInstance", SR.Culture);
            }
        }

        internal static string EnlistedTransactionPropertiesRequireIsolationBlocks
        {
            get
            {
                return SR.ResourceManager.GetString("EnlistedTransactionPropertiesRequireIsolationBlocks", SR.Culture);
            }
        }

        internal static string EnumeratorNotStarted
        {
            get
            {
                return SR.ResourceManager.GetString("EnumeratorNotStarted", SR.Culture);
            }
        }

        internal static string EnvironmentDisposed
        {
            get
            {
                return SR.ResourceManager.GetString("EnvironmentDisposed", SR.Culture);
            }
        }

        internal static string ErrorsEncounteredWhileProcessingTree
        {
            get
            {
                return SR.ResourceManager.GetString("ErrorsEncounteredWhileProcessingTree", SR.Culture);
            }
        }

        internal static string ExclusiveHandleRegisterBookmarkScopeFailed
        {
            get
            {
                return SR.ResourceManager.GetString("ExclusiveHandleRegisterBookmarkScopeFailed", SR.Culture);
            }
        }

        internal static string ExclusiveHandleReinitializeFailed
        {
            get
            {
                return SR.ResourceManager.GetString("ExclusiveHandleReinitializeFailed", SR.Culture);
            }
        }

        internal static string ExpressionRequiredForConversion
        {
            get
            {
                return SR.ResourceManager.GetString("ExpressionRequiredForConversion", SR.Culture);
            }
        }

        internal static string ExtensionsCannotBeModified
        {
            get
            {
                return SR.ResourceManager.GetString("ExtensionsCannotBeModified", SR.Culture);
            }
        }

        internal static string ExternalLocationsGetOnly
        {
            get
            {
                return SR.ResourceManager.GetString("ExternalLocationsGetOnly", SR.Culture);
            }
        }

        internal static string FlowchartContainsReferences
        {
            get
            {
                return SR.ResourceManager.GetString("FlowchartContainsReferences", SR.Culture);
            }
        }

        internal static string GeneratedAndProvidedMapConflict
        {
            get
            {
                return SR.ResourceManager.GetString("GeneratedAndProvidedMapConflict", SR.Culture);
            }
        }

        internal static string GeneratedAndProvidedMapConflictRuntime
        {
            get
            {
                return SR.ResourceManager.GetString("GeneratedAndProvidedMapConflictRuntime", SR.Culture);
            }
        }

        internal static string GetRunnableRequiresOwner
        {
            get
            {
                return SR.ResourceManager.GetString("GetRunnableRequiresOwner", SR.Culture);
            }
        }

        internal static string HandleInitializationContextDisposed
        {
            get
            {
                return SR.ResourceManager.GetString("HandleInitializationContextDisposed", SR.Culture);
            }
        }

        internal static string HandleNotInitialized
        {
            get
            {
                return SR.ResourceManager.GetString("HandleNotInitialized", SR.Culture);
            }
        }

        internal static string HasExecutingChildrenNoPersist
        {
            get
            {
                return SR.ResourceManager.GetString("HasExecutingChildrenNoPersist", SR.Culture);
            }
        }

        internal static string IdentityControlCharacter
        {
            get
            {
                return SR.ResourceManager.GetString("IdentityControlCharacter", SR.Culture);
            }
        }

        internal static string IdentityNameSemicolon
        {
            get
            {
                return SR.ResourceManager.GetString("IdentityNameSemicolon", SR.Culture);
            }
        }

        internal static string IdentityWhitespace
        {
            get
            {
                return SR.ResourceManager.GetString("IdentityWhitespace", SR.Culture);
            }
        }

        internal static string InitializationIncomplete
        {
            get
            {
                return SR.ResourceManager.GetString("InitializationIncomplete", SR.Culture);
            }
        }

        internal static string InstanceMethodCallRequiresTargetObject
        {
            get
            {
                return SR.ResourceManager.GetString("InstanceMethodCallRequiresTargetObject", SR.Culture);
            }
        }

        internal static string InstanceMustBePaused
        {
            get
            {
                return SR.ResourceManager.GetString("InstanceMustBePaused", SR.Culture);
            }
        }

        internal static string InstanceMustNotBePaused
        {
            get
            {
                return SR.ResourceManager.GetString("InstanceMustNotBePaused", SR.Culture);
            }
        }

        internal static string InstanceStoreDoesntMatchWorkflowApplication
        {
            get
            {
                return SR.ResourceManager.GetString("InstanceStoreDoesntMatchWorkflowApplication", SR.Culture);
            }
        }

        internal static string InstanceStoreFailed
        {
            get
            {
                return SR.ResourceManager.GetString("InstanceStoreFailed", SR.Culture);
            }
        }

        internal static string InstanceStoreHasDefaultOwner
        {
            get
            {
                return SR.ResourceManager.GetString("InstanceStoreHasDefaultOwner", SR.Culture);
            }
        }

        internal static string InstanceStoreRequiredToPersist
        {
            get
            {
                return SR.ResourceManager.GetString("InstanceStoreRequiredToPersist", SR.Culture);
            }
        }

        internal static string InvalidActivityIdFormat
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidActivityIdFormat", SR.Culture);
            }
        }

        internal static string InvalidEvaluationOrderValue
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidEvaluationOrderValue", SR.Culture);
            }
        }

        internal static string InvalidIdleAction
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidIdleAction", SR.Culture);
            }
        }

        internal static string InvalidImplementationAsWorkflowRoot
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidImplementationAsWorkflowRoot", SR.Culture);
            }
        }

        internal static string InvalidImplementationAsWorkflowRootForRuntimeState
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidImplementationAsWorkflowRootForRuntimeState", SR.Culture);
            }
        }

        internal static string InvalidImplementationAsWorkflowRootForRuntimeStateBecauseArgumentsChanged
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidImplementationAsWorkflowRootForRuntimeStateBecauseArgumentsChanged", SR.Culture);
            }
        }

        internal static string InvalidImplementationMapRuntime
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidImplementationMapRuntime", SR.Culture);
            }
        }

        internal static string InvalidLocationExpression
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidLocationExpression", SR.Culture);
            }
        }

        internal static string InvalidLValueExpression
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidLValueExpression", SR.Culture);
            }
        }

        internal static string InvalidMergeMapArgumentsChanged
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidMergeMapArgumentsChanged", SR.Culture);
            }
        }

        internal static string InvalidOriginalWorkflowDefinitionForImplementationMapCreation
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidOriginalWorkflowDefinitionForImplementationMapCreation", SR.Culture);
            }
        }

        internal static string InvalidPrepareForRuntimeValidationSettings
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidPrepareForRuntimeValidationSettings", SR.Culture);
            }
        }

        internal static string InvalidRuntimeState
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidRuntimeState", SR.Culture);
            }
        }

        internal static string InvalidStateForAsyncCallback
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidStateForAsyncCallback", SR.Culture);
            }
        }

        internal static string InvalidTypeConverterUsage
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidTypeConverterUsage", SR.Culture);
            }
        }

        internal static string InvalidUnhandledExceptionAction
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidUnhandledExceptionAction", SR.Culture);
            }
        }

        internal static string InvalidUpdatedWorkflowDefinitionForImplementationMapCreation
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidUpdatedWorkflowDefinitionForImplementationMapCreation", SR.Culture);
            }
        }

        internal static string InvalidVisualBasicSettingsValue
        {
            get
            {
                return SR.ResourceManager.GetString("InvalidVisualBasicSettingsValue", SR.Culture);
            }
        }

        internal static string IsolationLevelValidation
        {
            get
            {
                return SR.ResourceManager.GetString("IsolationLevelValidation", SR.Culture);
            }
        }

        internal static string ITextExpressionParameterMustBeActivity
        {
            get
            {
                return SR.ResourceManager.GetString("ITextExpressionParameterMustBeActivity", SR.Culture);
            }
        }

        internal static string LambdaExpressionReturnTypeInvalid
        {
            get
            {
                return SR.ResourceManager.GetString("LambdaExpressionReturnTypeInvalid", SR.Culture);
            }
        }

        internal static string LambdaExpressionTypeRequired
        {
            get
            {
                return SR.ResourceManager.GetString("LambdaExpressionTypeRequired", SR.Culture);
            }
        }

        internal static string LambdaNotXamlSerializable
        {
            get
            {
                return SR.ResourceManager.GetString("LambdaNotXamlSerializable", SR.Culture);
            }
        }

        internal static string LoadingWorkflowApplicationRequiresInstanceStore
        {
            get
            {
                return SR.ResourceManager.GetString("LoadingWorkflowApplicationRequiresInstanceStore", SR.Culture);
            }
        }

        internal static string MarkCanceledOnlyCallableIfCancelRequested
        {
            get
            {
                return SR.ResourceManager.GetString("MarkCanceledOnlyCallableIfCancelRequested", SR.Culture);
            }
        }

        internal static string MovingActivitiesInStateBlockDU
        {
            get
            {
                return SR.ResourceManager.GetString("MovingActivitiesInStateBlockDU", SR.Culture);
            }
        }

        internal static string MultiDimensionalArraysNotSupported
        {
            get
            {
                return SR.ResourceManager.GetString("MultiDimensionalArraysNotSupported", SR.Culture);
            }
        }

        internal static string MultipleFlowNodesSharingSameChildBlockDU
        {
            get
            {
                return SR.ResourceManager.GetString("MultipleFlowNodesSharingSameChildBlockDU", SR.Culture);
            }
        }

        internal static string MustCallPrepareBeforeFinalize
        {
            get
            {
                return SR.ResourceManager.GetString("MustCallPrepareBeforeFinalize", SR.Culture);
            }
        }

        internal static string MustMatchReferenceExpressionReturnType
        {
            get
            {
                return SR.ResourceManager.GetString("MustMatchReferenceExpressionReturnType", SR.Culture);
            }
        }

        internal static string NAUCDisposed
        {
            get
            {
                return SR.ResourceManager.GetString("NAUCDisposed", SR.Culture);
            }
        }

        internal static string NewArrayBoundsRequiresIntegralArguments
        {
            get
            {
                return SR.ResourceManager.GetString("NewArrayBoundsRequiresIntegralArguments", SR.Culture);
            }
        }

        internal static string NewArrayRequiresArrayTypeAsResultType
        {
            get
            {
                return SR.ResourceManager.GetString("NewArrayRequiresArrayTypeAsResultType", SR.Culture);
            }
        }

        internal static string NoCAInSecondaryRoot
        {
            get
            {
                return SR.ResourceManager.GetString("NoCAInSecondaryRoot", SR.Culture);
            }
        }

        internal static string NoChangesMapQueryNotSupported
        {
            get
            {
                return SR.ResourceManager.GetString("NoChangesMapQueryNotSupported", SR.Culture);
            }
        }

        internal static string NoDynamicArgumentsInActivityDefinitionChange
        {
            get
            {
                return SR.ResourceManager.GetString("NoDynamicArgumentsInActivityDefinitionChange", SR.Culture);
            }
        }

        internal static string NoDynamicArgumentsInActivityDefinitionChangeRuntime
        {
            get
            {
                return SR.ResourceManager.GetString("NoDynamicArgumentsInActivityDefinitionChangeRuntime", SR.Culture);
            }
        }

        internal static string NoOverloadGroupsAreConfigured
        {
            get
            {
                return SR.ResourceManager.GetString("NoOverloadGroupsAreConfigured", SR.Culture);
            }
        }

        internal static string NoRunnableInstances
        {
            get
            {
                return SR.ResourceManager.GetString("NoRunnableInstances", SR.Culture);
            }
        }

        internal static string NoRuntimeTransactionExists
        {
            get
            {
                return SR.ResourceManager.GetString("NoRuntimeTransactionExists", SR.Culture);
            }
        }

        internal static string OnlyBookmarkOwnerCanRemove
        {
            get
            {
                return SR.ResourceManager.GetString("OnlyBookmarkOwnerCanRemove", SR.Culture);
            }
        }

        internal static string OnlyOneOperationPerActivity
        {
            get
            {
                return SR.ResourceManager.GetString("OnlyOneOperationPerActivity", SR.Culture);
            }
        }

        internal static string OnlyOneRequireTransactionContextAllowed
        {
            get
            {
                return SR.ResourceManager.GetString("OnlyOneRequireTransactionContextAllowed", SR.Culture);
            }
        }

        internal static string OnlySingleCastDelegatesAllowed
        {
            get
            {
                return SR.ResourceManager.GetString("OnlySingleCastDelegatesAllowed", SR.Culture);
            }
        }

        internal static string OperationAlreadyCompleted
        {
            get
            {
                return SR.ResourceManager.GetString("OperationAlreadyCompleted", SR.Culture);
            }
        }

        internal static string OutOfIdSpaceIds
        {
            get
            {
                return SR.ResourceManager.GetString("OutOfIdSpaceIds", SR.Culture);
            }
        }

        internal static string OutOfInstanceIds
        {
            get
            {
                return SR.ResourceManager.GetString("OutOfInstanceIds", SR.Culture);
            }
        }

        internal static string OutOfInternalBookmarks
        {
            get
            {
                return SR.ResourceManager.GetString("OutOfInternalBookmarks", SR.Culture);
            }
        }

        internal static string OverloadingMethodMustBeStatic
        {
            get
            {
                return SR.ResourceManager.GetString("OverloadingMethodMustBeStatic", SR.Culture);
            }
        }

        internal static string OverloadOnlyCallableFromWorkflowThread
        {
            get
            {
                return SR.ResourceManager.GetString("OverloadOnlyCallableFromWorkflowThread", SR.Culture);
            }
        }

        internal static string PauseWhenPersistableInvalidIfPersistable
        {
            get
            {
                return SR.ResourceManager.GetString("PauseWhenPersistableInvalidIfPersistable", SR.Culture);
            }
        }

        internal static string PickBranchTriggerActionSwapped
        {
            get
            {
                return SR.ResourceManager.GetString("PickBranchTriggerActionSwapped", SR.Culture);
            }
        }

        internal static string PrepareForSerializationRequiresPersistability
        {
            get
            {
                return SR.ResourceManager.GetString("PrepareForSerializationRequiresPersistability", SR.Culture);
            }
        }

        internal static string PrivateMembersHaveChanged
        {
            get
            {
                return SR.ResourceManager.GetString("PrivateMembersHaveChanged", SR.Culture);
            }
        }

        internal static string ProvidedStateInitializedForExecution
        {
            get
            {
                return SR.ResourceManager.GetString("ProvidedStateInitializedForExecution", SR.Culture);
            }
        }

        internal static string PublicChildrenChangeBlockDU
        {
            get
            {
                return SR.ResourceManager.GetString("PublicChildrenChangeBlockDU", SR.Culture);
            }
        }

        internal static string PublicEnvironmentAccessToNonGenericActivity
        {
            get
            {
                return SR.ResourceManager.GetString("PublicEnvironmentAccessToNonGenericActivity", SR.Culture);
            }
        }

        internal static string QueryActivityIsNotInDefinition
        {
            get
            {
                return SR.ResourceManager.GetString("QueryActivityIsNotInDefinition", SR.Culture);
            }
        }

        internal static string QueryVariableIsNotInDefinition
        {
            get
            {
                return SR.ResourceManager.GetString("QueryVariableIsNotInDefinition", SR.Culture);
            }
        }

        internal static string QueryVariableIsNotPublic
        {
            get
            {
                return SR.ResourceManager.GetString("QueryVariableIsNotPublic", SR.Culture);
            }
        }

        internal static string ReadonlyNameScopeCannotBeUpdated
        {
            get
            {
                return SR.ResourceManager.GetString("ReadonlyNameScopeCannotBeUpdated", SR.Culture);
            }
        }

        internal static string ReferencedChildInIsNewlyAdded
        {
            get
            {
                return SR.ResourceManager.GetString("ReferencedChildInIsNewlyAdded", SR.Culture);
            }
        }

        internal static string RegisteredBookmarkScopeRequired
        {
            get
            {
                return SR.ResourceManager.GetString("RegisteredBookmarkScopeRequired", SR.Culture);
            }
        }

        internal static string RemovingTransitionsBlockDU
        {
            get
            {
                return SR.ResourceManager.GetString("RemovingTransitionsBlockDU", SR.Culture);
            }
        }

        internal static ResourceManager ResourceManager
        {
            get
            {
                if (SR.resourceManager == null)
                {
                    SR.resourceManager = new ResourceManager("System.Activities.SR", typeof(SR).Assembly);
                }
                return SR.resourceManager;
            }
        }

        internal static string ResultArgumentMustBeBoundToResultProperty
        {
            get
            {
                return SR.ResourceManager.GetString("ResultArgumentMustBeBoundToResultProperty", SR.Culture);
            }
        }

        internal static string ResultCannotBeSetOnArgumentExpressions
        {
            get
            {
                return SR.ResourceManager.GetString("ResultCannotBeSetOnArgumentExpressions", SR.Culture);
            }
        }

        internal static string RootArgumentViolationsFound
        {
            get
            {
                return SR.ResourceManager.GetString("RootArgumentViolationsFound", SR.Culture);
            }
        }

        internal static string RootArgumentViolationsFoundNoInputs
        {
            get
            {
                return SR.ResourceManager.GetString("RootArgumentViolationsFoundNoInputs", SR.Culture);
            }
        }

        internal static string RuntimeArgumentNotCreated
        {
            get
            {
                return SR.ResourceManager.GetString("RuntimeArgumentNotCreated", SR.Culture);
            }
        }

        internal static string RuntimeDelegateArgumentDirectionIncorrect
        {
            get
            {
                return SR.ResourceManager.GetString("RuntimeDelegateArgumentDirectionIncorrect", SR.Culture);
            }
        }

        internal static string RuntimeDelegateArgumentTypeIncorrect
        {
            get
            {
                return SR.ResourceManager.GetString("RuntimeDelegateArgumentTypeIncorrect", SR.Culture);
            }
        }

        internal static string RuntimeOperationInProgress
        {
            get
            {
                return SR.ResourceManager.GetString("RuntimeOperationInProgress", SR.Culture);
            }
        }

        internal static string RuntimeRunning
        {
            get
            {
                return SR.ResourceManager.GetString("RuntimeRunning", SR.Culture);
            }
        }

        internal static string RuntimeTransactionAlreadyExists
        {
            get
            {
                return SR.ResourceManager.GetString("RuntimeTransactionAlreadyExists", SR.Culture);
            }
        }

        internal static string RuntimeTransactionIsSuppressed
        {
            get
            {
                return SR.ResourceManager.GetString("RuntimeTransactionIsSuppressed", SR.Culture);
            }
        }

        internal static string SameUserStateUsedForMultipleInvokes
        {
            get
            {
                return SR.ResourceManager.GetString("SameUserStateUsedForMultipleInvokes", SR.Culture);
            }
        }

        internal static string SavingActivityToXamlNotSupported
        {
            get
            {
                return SR.ResourceManager.GetString("SavingActivityToXamlNotSupported", SR.Culture);
            }
        }

        internal static string SavingFuncToXamlNotSupported
        {
            get
            {
                return SR.ResourceManager.GetString("SavingFuncToXamlNotSupported", SR.Culture);
            }
        }

        internal static string SendNotSupported
        {
            get
            {
                return SR.ResourceManager.GetString("SendNotSupported", SR.Culture);
            }
        }

        internal static string SequenceDuplicateReferences
        {
            get
            {
                return SR.ResourceManager.GetString("SequenceDuplicateReferences", SR.Culture);
            }
        }

        internal static string SetupOrCleanupWorkflowThreadThrew
        {
            get
            {
                return SR.ResourceManager.GetString("SetupOrCleanupWorkflowThreadThrew", SR.Culture);
            }
        }

        internal static string SymbolResolverAlreadyExists
        {
            get
            {
                return SR.ResourceManager.GetString("SymbolResolverAlreadyExists", SR.Culture);
            }
        }

        internal static string SymbolResolverMustBeSingleton
        {
            get
            {
                return SR.ResourceManager.GetString("SymbolResolverMustBeSingleton", SR.Culture);
            }
        }

        internal static string TextExpressionCompilerActivityNameRequired
        {
            get
            {
                return SR.ResourceManager.GetString("TextExpressionCompilerActivityNameRequired", SR.Culture);
            }
        }

        internal static string TextExpressionCompilerActivityNamespaceRequired
        {
            get
            {
                return SR.ResourceManager.GetString("TextExpressionCompilerActivityNamespaceRequired", SR.Culture);
            }
        }

        internal static string TextExpressionCompilerActivityRequired
        {
            get
            {
                return SR.ResourceManager.GetString("TextExpressionCompilerActivityRequired", SR.Culture);
            }
        }

        internal static string TextExpressionCompilerAddGeneratedFileRequired
        {
            get
            {
                return SR.ResourceManager.GetString("TextExpressionCompilerAddGeneratedFileRequired", SR.Culture);
            }
        }

        internal static string TextExpressionCompilerLanguageRequired
        {
            get
            {
                return SR.ResourceManager.GetString("TextExpressionCompilerLanguageRequired", SR.Culture);
            }
        }

        internal static string TextExpressionCompilerOutputPathRequired
        {
            get
            {
                return SR.ResourceManager.GetString("TextExpressionCompilerOutputPathRequired", SR.Culture);
            }
        }

        internal static string TimerExtensionAlreadyAttached
        {
            get
            {
                return SR.ResourceManager.GetString("TimerExtensionAlreadyAttached", SR.Culture);
            }
        }

        internal static string TimerExtensionRequiresWorkflowInstance
        {
            get
            {
                return SR.ResourceManager.GetString("TimerExtensionRequiresWorkflowInstance", SR.Culture);
            }
        }

        internal static string TooManyViolationsForExceptionMessage
        {
            get
            {
                return SR.ResourceManager.GetString("TooManyViolationsForExceptionMessage", SR.Culture);
            }
        }

        internal static string TrackingRelatedWorkflowAbort
        {
            get
            {
                return SR.ResourceManager.GetString("TrackingRelatedWorkflowAbort", SR.Culture);
            }
        }

        internal static string TransactionHandleAlreadyHasTransaction
        {
            get
            {
                return SR.ResourceManager.GetString("TransactionHandleAlreadyHasTransaction", SR.Culture);
            }
        }

        internal static string TriggerOrConditionChangedDuringTransitioning
        {
            get
            {
                return SR.ResourceManager.GetString("TriggerOrConditionChangedDuringTransitioning", SR.Culture);
            }
        }

        internal static string TriggerOrConditionIsReferenced
        {
            get
            {
                return SR.ResourceManager.GetString("TriggerOrConditionIsReferenced", SR.Culture);
            }
        }

        internal static string TryLoadRequiresOwner
        {
            get
            {
                return SR.ResourceManager.GetString("TryLoadRequiresOwner", SR.Culture);
            }
        }

        internal static string UnInitializedRuntimeTransactionHandle
        {
            get
            {
                return SR.ResourceManager.GetString("UnInitializedRuntimeTransactionHandle", SR.Culture);
            }
        }

        internal static string UnmatchedNoPersistExit
        {
            get
            {
                return SR.ResourceManager.GetString("UnmatchedNoPersistExit", SR.Culture);
            }
        }

        internal static string UnsupportedLocationReferenceValue
        {
            get
            {
                return SR.ResourceManager.GetString("UnsupportedLocationReferenceValue", SR.Culture);
            }
        }

        internal static string UpdateSymbolsMustMatch
        {
            get
            {
                return SR.ResourceManager.GetString("UpdateSymbolsMustMatch", SR.Culture);
            }
        }

        internal static string ValueMustBeAssignableToType
        {
            get
            {
                return SR.ResourceManager.GetString("ValueMustBeAssignableToType", SR.Culture);
            }
        }

        internal static string VariableMustBeSet
        {
            get
            {
                return SR.ResourceManager.GetString("VariableMustBeSet", SR.Culture);
            }
        }

        internal static string VariableOrArgumentAdditionToReferencedEnvironmentNoDUSupported
        {
            get
            {
                return SR.ResourceManager.GetString("VariableOrArgumentAdditionToReferencedEnvironmentNoDUSupported", SR.Culture);
            }
        }

        internal static string WDCDisposed
        {
            get
            {
                return SR.ResourceManager.GetString("WDCDisposed", SR.Culture);
            }
        }

        internal static string WorkflowApplicationAlreadyHasId
        {
            get
            {
                return SR.ResourceManager.GetString("WorkflowApplicationAlreadyHasId", SR.Culture);
            }
        }

        internal static string WorkflowApplicationInstanceAbandoned
        {
            get
            {
                return SR.ResourceManager.GetString("WorkflowApplicationInstanceAbandoned", SR.Culture);
            }
        }

        internal static string WorkflowApplicationInstanceLoaded
        {
            get
            {
                return SR.ResourceManager.GetString("WorkflowApplicationInstanceLoaded", SR.Culture);
            }
        }

        internal static string WorkflowTerminatedExceptionDefaultMessage
        {
            get
            {
                return SR.ResourceManager.GetString("WorkflowTerminatedExceptionDefaultMessage", SR.Culture);
            }
        }

        internal static string WorkItemAbortedInstance
        {
            get
            {
                return SR.ResourceManager.GetString("WorkItemAbortedInstance", SR.Culture);
            }
        }

        internal static string WrongCacheMetadataForCodeActivity
        {
            get
            {
                return SR.ResourceManager.GetString("WrongCacheMetadataForCodeActivity", SR.Culture);
            }
        }

        internal static string WrongCacheMetadataForNativeActivity
        {
            get
            {
                return SR.ResourceManager.GetString("WrongCacheMetadataForNativeActivity", SR.Culture);
            }
        }

        internal static string WrongNumberOfArgumentsForActivityDelegate
        {
            get
            {
                return SR.ResourceManager.GetString("WrongNumberOfArgumentsForActivityDelegate", SR.Culture);
            }
        }

        internal static string WrongOnCreateDynamicUpdateMapForNativeActivity
        {
            get
            {
                return SR.ResourceManager.GetString("WrongOnCreateDynamicUpdateMapForNativeActivity", SR.Culture);
            }
        }

        internal static string XamlElementExpected
        {
            get
            {
                return SR.ResourceManager.GetString("XamlElementExpected", SR.Culture);
            }
        }

        private SR()
        {
        }

        internal static string ActivityBlockingUpdate(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityBlockingUpdate", SR.Culture), new object[] { param0, param1 });
        }

        internal static string ActivityCannotBeReferenced(object param0, object param1, object param2, object param3)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityCannotBeReferenced", SR.Culture), new object[] { param0, param1, param2, param3 });
        }

        internal static string ActivityCannotBeReferencedWithoutTarget(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityCannotBeReferencedWithoutTarget", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string ActivityCannotReferenceItself(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityCannotReferenceItself", SR.Culture), new object[] { param0 });
        }

        internal static string ActivityDefinitionCannotBeShared(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityDefinitionCannotBeShared", SR.Culture), new object[] { param0 });
        }

        internal static string ActivityDelegateAlreadyOpened(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityDelegateAlreadyOpened", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string ActivityDelegateCannotBeReferenced(object param0, object param1, object param2, object param3)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityDelegateCannotBeReferenced", SR.Culture), new object[] { param0, param1, param2, param3 });
        }

        internal static string ActivityDelegateCannotBeReferencedNoHandler(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityDelegateCannotBeReferencedNoHandler", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string ActivityDelegateCannotBeReferencedWithoutTarget(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityDelegateCannotBeReferencedWithoutTarget", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string ActivityDelegateCannotBeReferencedWithoutTargetNoHandler(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityDelegateCannotBeReferencedWithoutTargetNoHandler", SR.Culture), new object[] { param0, param1 });
        }

        internal static string ActivityDelegateHandlersMustBeDeclarations(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityDelegateHandlersMustBeDeclarations", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string ActivityDelegateNotOpened(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityDelegateNotOpened", SR.Culture), new object[] { param0 });
        }

        internal static string ActivityDelegateOwnerEnvironmentMissing(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityDelegateOwnerEnvironmentMissing", SR.Culture), new object[] { param0, param1 });
        }

        internal static string ActivityDelegateOwnerMissing(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityDelegateOwnerMissing", SR.Culture), new object[] { param0 });
        }

        internal static string ActivityDelegateOwnerNotInParentScope(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityDelegateOwnerNotInParentScope", SR.Culture), new object[] { param0, param1 });
        }

        internal static string ActivityHasNoImplementation(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityHasNoImplementation", SR.Culture), new object[] { param0 });
        }

        internal static string ActivityNotFound(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityNotFound", SR.Culture), new object[] { param0 });
        }

        internal static string ActivityNotPartOfThisTree(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityNotPartOfThisTree", SR.Culture), new object[] { param0, param1 });
        }

        internal static string ActivityPropertyMustBeSet(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityPropertyMustBeSet", SR.Culture), new object[] { param0, param1 });
        }

        internal static string ActivityPropertyNotSet(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityPropertyNotSet", SR.Culture), new object[] { param0, param1 });
        }

        internal static string ActivityPropertyRequiresName(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityPropertyRequiresName", SR.Culture), new object[] { param0 });
        }

        internal static string ActivityPropertyRequiresType(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityPropertyRequiresType", SR.Culture), new object[] { param0 });
        }

        internal static string ActivityTypeMismatch(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityTypeMismatch", SR.Culture), new object[] { param0, param1 });
        }

        internal static string ActivityXamlServicesCompilationFailed(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityXamlServicesCompilationFailed", SR.Culture), new object[] { param0 });
        }

        internal static string ActivityXamlServicesRequiresActivity(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ActivityXamlServicesRequiresActivity", SR.Culture), new object[] { param0 });
        }

        internal static string AddedIdleArgumentBlockDU(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("AddedIdleArgumentBlockDU", SR.Culture), new object[] { param0, param1 });
        }

        internal static string AddedIdleVariableDefaultBlockDU(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("AddedIdleVariableDefaultBlockDU", SR.Culture), new object[] { param0, param1 });
        }

        internal static string AddMatchActivityNewAndOldParentMismatch(object param0, object param1, object param2, object param3)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("AddMatchActivityNewAndOldParentMismatch", SR.Culture), new object[] { param0, param1, param2, param3 });
        }

        internal static string AddMatchActivityNewParentMismatch(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("AddMatchActivityNewParentMismatch", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string AddMatchActivityPrivateChild(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("AddMatchActivityPrivateChild", SR.Culture), new object[] { param0 });
        }

        internal static string AddMatchVariableNewAndOldParentMismatch(object param0, object param1, object param2, object param3)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("AddMatchVariableNewAndOldParentMismatch", SR.Culture), new object[] { param0, param1, param2, param3 });
        }

        internal static string AddMatchVariableNewParentMismatch(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("AddMatchVariableNewParentMismatch", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string AddMatchVariablePrivateChild(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("AddMatchVariablePrivateChild", SR.Culture), new object[] { param0 });
        }

        internal static string AddMatchVariableSignatureMismatch(object param0, object param1, object param2, object param3, object param4, object param5, object param6)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("AddMatchVariableSignatureMismatch", SR.Culture), new object[] { param0, param1, param2, param3, param4, param5, param6 });
        }

        internal static string AddValidationErrorMustBeCalledFromConstraint(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("AddValidationErrorMustBeCalledFromConstraint", SR.Culture), new object[] { param0 });
        }

        internal static string AmbiguousVBVariableReference(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("AmbiguousVBVariableReference", SR.Culture), new object[] { param0 });
        }

        internal static string ArgumentAlreadyInitialized(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ArgumentAlreadyInitialized", SR.Culture), new object[] { param0, param1 });
        }

        internal static string ArgumentAlreadyInUse(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ArgumentAlreadyInUse", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string ArgumentDirectionMismatch(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ArgumentDirectionMismatch", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string ArgumentDoesNotExist(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ArgumentDoesNotExist", SR.Culture), new object[] { param0 });
        }

        internal static string ArgumentDoesNotExistInEnvironment(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ArgumentDoesNotExistInEnvironment", SR.Culture), new object[] { param0 });
        }

        internal static string ArgumentIsAddedMoreThanOnce(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ArgumentIsAddedMoreThanOnce", SR.Culture), new object[] { param0, param1 });
        }

        internal static string ArgumentLocationExpressionTypeMismatch(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ArgumentLocationExpressionTypeMismatch", SR.Culture), new object[] { param0, param1 });
        }

        internal static string ArgumentNotFound(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ArgumentNotFound", SR.Culture), new object[] { param0 });
        }

        internal static string ArgumentNotInTree(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ArgumentNotInTree", SR.Culture), new object[] { param0 });
        }

        internal static string ArgumentNumberRequiresTheSameAsParameterNumber(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ArgumentNumberRequiresTheSameAsParameterNumber", SR.Culture), new object[] { param0 });
        }

        internal static string ArgumentRequired(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ArgumentRequired", SR.Culture), new object[] { param0, param1 });
        }

        internal static string ArgumentTypeMismatch(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ArgumentTypeMismatch", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string ArgumentTypeMustBeCompatible(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ArgumentTypeMustBeCompatible", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string ArgumentValueExpressionTypeMismatch(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ArgumentValueExpressionTypeMismatch", SR.Culture), new object[] { param0, param1 });
        }

        internal static string ArgumentViolationsFound(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ArgumentViolationsFound", SR.Culture), new object[] { param0, param1 });
        }

        internal static string BinaryExpressionActivityRequiresArgument(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("BinaryExpressionActivityRequiresArgument", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string BookmarkAlreadyExists(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("BookmarkAlreadyExists", SR.Culture), new object[] { param0 });
        }

        internal static string BookmarkNotRegistered(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("BookmarkNotRegistered", SR.Culture), new object[] { param0 });
        }

        internal static string BookmarkScopeNotFound(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("BookmarkScopeNotFound", SR.Culture), new object[] { param0 });
        }

        internal static string BookmarkScopeWithIdAlreadyExists(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("BookmarkScopeWithIdAlreadyExists", SR.Culture), new object[] { param0 });
        }

        internal static string CallbackExceptionFromHostAbort(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CallbackExceptionFromHostAbort", SR.Culture), new object[] { param0 });
        }

        internal static string CallbackExceptionFromHostGetExtension(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CallbackExceptionFromHostGetExtension", SR.Culture), new object[] { param0 });
        }

        internal static string CancellationHandlerFatalException(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CancellationHandlerFatalException", SR.Culture), new object[] { param0 });
        }

        internal static string CanInduceIdleActivityInArgumentExpression(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CanInduceIdleActivityInArgumentExpression", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string CanInduceIdleNotSpecified(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CanInduceIdleNotSpecified", SR.Culture), new object[] { param0 });
        }

        internal static string CannotDereferenceNull(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CannotDereferenceNull", SR.Culture), new object[] { param0 });
        }

        internal static string CannotGenerateSchemaForXmlSerializable(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CannotGenerateSchemaForXmlSerializable", SR.Culture), new object[] { param0 });
        }

        internal static string CannotNestTransactionScopeWhenAmbientHandleIsSuppressed(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CannotNestTransactionScopeWhenAmbientHandleIsSuppressed", SR.Culture), new object[] { param0 });
        }

        internal static string CannotPropagateExceptionWhileCanceling(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CannotPropagateExceptionWhileCanceling", SR.Culture), new object[] { param0, param1 });
        }

        internal static string CannotRemoveExecutingActivityUpdateError(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CannotRemoveExecutingActivityUpdateError", SR.Culture), new object[] { param0, param1 });
        }

        internal static string CannotSaveOriginalValueForNewActivity(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CannotSaveOriginalValueForNewActivity", SR.Culture), new object[] { param0 });
        }

        internal static string CannotSerializeExpression(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CannotSerializeExpression", SR.Culture), new object[] { param0 });
        }

        internal static string CannotSetValueToLocation(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CannotSetValueToLocation", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string CannotValidateNullObject(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CannotValidateNullObject", SR.Culture), new object[] { param0, param1 });
        }

        internal static string CanOnlyGetOwnedArguments(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CanOnlyGetOwnedArguments", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string CanOnlyScheduleDirectChildren(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CanOnlyScheduleDirectChildren", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string CatchOrFinallyExpected(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CatchOrFinallyExpected", SR.Culture), new object[] { param0 });
        }

        internal static string CollectionActivityRequiresCollection(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CollectionActivityRequiresCollection", SR.Culture), new object[] { param0 });
        }

        internal static string ColumnNumberTooLarge(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ColumnNumberTooLarge", SR.Culture), new object[] { param0 });
        }

        internal static string CompensateWithoutCompensableActivity(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CompensateWithoutCompensableActivity", SR.Culture), new object[] { param0 });
        }

        internal static string CompensationHandlerFatalException(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CompensationHandlerFatalException", SR.Culture), new object[] { param0 });
        }

        internal static string CompiledExpressionIdNotFound(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CompiledExpressionIdNotFound", SR.Culture), new object[] { param0 });
        }

        internal static string CompiledExpressionsActivityException(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CompiledExpressionsActivityException", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string CompiledExpressionsCacheMetadataException(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CompiledExpressionsCacheMetadataException", SR.Culture), new object[] { param0, param1 });
        }

        internal static string CompiledExpressionsDuplicateName(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CompiledExpressionsDuplicateName", SR.Culture), new object[] { param0 });
        }

        internal static string CompiledExpressionsIgnoringInvalidIdentifierVariable(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CompiledExpressionsIgnoringInvalidIdentifierVariable", SR.Culture), new object[] { param0 });
        }

        internal static string CompiledExpressionsNoCompiledRoot(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CompiledExpressionsNoCompiledRoot", SR.Culture), new object[] { param0 });
        }

        internal static string CompiledLocationNoDefaultConstructor(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CompiledLocationNoDefaultConstructor", SR.Culture), new object[] { param0 });
        }

        internal static string CompilerErrorSpecificExpression(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CompilerErrorSpecificExpression", SR.Culture), new object[] { param0, param1 });
        }

        internal static string CompletionConditionSetButNoBody(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("CompletionConditionSetButNoBody", SR.Culture), new object[] { param0 });
        }

        internal static string ConfirmationHandlerFatalException(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ConfirmationHandlerFatalException", SR.Culture), new object[] { param0 });
        }

        internal static string ConfirmWithoutCompensableActivity(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ConfirmWithoutCompensableActivity", SR.Culture), new object[] { param0 });
        }

        internal static string ConstructorInfoNotFound(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ConstructorInfoNotFound", SR.Culture), new object[] { param0 });
        }

        internal static string ConvertVariableToValueExpressionFailed(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ConvertVariableToValueExpressionFailed", SR.Culture), new object[] { param0, param1 });
        }

        internal static string DebugInfoCannotEvaluateExpression(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DebugInfoCannotEvaluateExpression", SR.Culture), new object[] { param0 });
        }

        internal static string DebugInfoExceptionCaught(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DebugInfoExceptionCaught", SR.Culture), new object[] { param0, param1 });
        }

        internal static string DebugInstrumentationFailed(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DebugInstrumentationFailed", SR.Culture), new object[] { param0 });
        }

        internal static string DelegateArgumentAlreadyInUseOnActivity(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DelegateArgumentAlreadyInUseOnActivity", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string DelegateArgumentDoesNotExist(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DelegateArgumentDoesNotExist", SR.Culture), new object[] { param0 });
        }

        internal static string DelegateArgumentMustBeReferenced(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DelegateArgumentMustBeReferenced", SR.Culture), new object[] { param0 });
        }

        internal static string DelegateArgumentNotVisible(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DelegateArgumentNotVisible", SR.Culture), new object[] { param0 });
        }

        internal static string DelegateArgumentTypeInvalid(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DelegateArgumentTypeInvalid", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string DelegateHandlersCannotBeScheduledDirectly(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DelegateHandlersCannotBeScheduledDirectly", SR.Culture), new object[] { param0, param1 });
        }

        internal static string DelegateInArgumentTypeMismatch(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DelegateInArgumentTypeMismatch", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string DelegateOutArgumentTypeMismatch(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DelegateOutArgumentTypeMismatch", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string DelegateParameterCannotBeModifiedAfterOpen(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DelegateParameterCannotBeModifiedAfterOpen", SR.Culture), new object[] { param0 });
        }

        internal static string DelegateParameterDirectionalityMismatch(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DelegateParameterDirectionalityMismatch", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string DoNotSupportArrayIndexerOnNonArrayType(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DoNotSupportArrayIndexerOnNonArrayType", SR.Culture), new object[] { param0 });
        }

        internal static string DoNotSupportArrayIndexerReferenceWithDifferentArrayTypeAndResultType(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DoNotSupportArrayIndexerReferenceWithDifferentArrayTypeAndResultType", SR.Culture), new object[] { param0, param1 });
        }

        internal static string DoNotSupportArrayIndexerValueWithIncompatibleArrayTypeAndResultType(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DoNotSupportArrayIndexerValueWithIncompatibleArrayTypeAndResultType", SR.Culture), new object[] { param0, param1 });
        }

        internal static string DoNotSupportArrayIndexerWithDifferentArrayTypeAndResultType(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DoNotSupportArrayIndexerWithDifferentArrayTypeAndResultType", SR.Culture), new object[] { param0, param1 });
        }

        internal static string DoNotSupportArrayIndexerWithNonIntIndex(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DoNotSupportArrayIndexerWithNonIntIndex", SR.Culture), new object[] { param0 });
        }

        internal static string DoWhileRequiresCondition(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DoWhileRequiresCondition", SR.Culture), new object[] { param0 });
        }

        internal static string DUActivityTypeMismatch(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DUActivityTypeMismatch", SR.Culture), new object[] { param0, param1 });
        }

        internal static string DuplicateAnnotationName(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DuplicateAnnotationName", SR.Culture), new object[] { param0 });
        }

        internal static string DuplicateCatchClause(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DuplicateCatchClause", SR.Culture), new object[] { param0 });
        }

        internal static string DuplicateEvaluationOrderValues(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DuplicateEvaluationOrderValues", SR.Culture), new object[] { param0, param1 });
        }

        internal static string DuplicateImportAttribute(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DuplicateImportAttribute", SR.Culture), new object[] { param0, param1 });
        }

        internal static string DuplicateInstrumentation(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DuplicateInstrumentation", SR.Culture), new object[] { param0 });
        }

        internal static string DuplicateMethodFound(object param0, object param1, object param2, object param3)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DuplicateMethodFound", SR.Culture), new object[] { param0, param1, param2, param3 });
        }

        internal static string DuplicateOriginActivityActivity(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DuplicateOriginActivityActivity", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string DuplicateOriginActivityVariable(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DuplicateOriginActivityVariable", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string DuplicateOriginVariableVariable(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DuplicateOriginVariableVariable", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string DurationIsNegative(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DurationIsNegative", SR.Culture), new object[] { param0 });
        }

        internal static string DynamicActivityDuplicatePropertyDetected(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DynamicActivityDuplicatePropertyDetected", SR.Culture), new object[] { param0 });
        }

        internal static string DynamicActivityMultipleExpressionLanguages(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("DynamicActivityMultipleExpressionLanguages", SR.Culture), new object[] { param0 });
        }

        internal static string EmptyIdReturnedFromHost(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("EmptyIdReturnedFromHost", SR.Culture), new object[] { param0 });
        }

        internal static string ErrorExtractingValuesForLambdaRewrite(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ErrorExtractingValuesForLambdaRewrite", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string ExecutionPropertyAlreadyDefined(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ExecutionPropertyAlreadyDefined", SR.Culture), new object[] { param0 });
        }

        internal static string ExtraOverloadGroupPropertiesConfigured(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ExtraOverloadGroupPropertiesConfigured", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string FaultContextNotFound(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("FaultContextNotFound", SR.Culture), new object[] { param0 });
        }

        internal static string FinalStateCannotHaveProperty(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("FinalStateCannotHaveProperty", SR.Culture), new object[] { param0, param1 });
        }

        internal static string FinalStateCannotHaveTransition(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("FinalStateCannotHaveTransition", SR.Culture), new object[] { param0 });
        }

        internal static string FlowchartContainsUnconnectedNodes(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("FlowchartContainsUnconnectedNodes", SR.Culture), new object[] { param0 });
        }

        internal static string FlowchartMissingStartNode(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("FlowchartMissingStartNode", SR.Culture), new object[] { param0 });
        }

        internal static string FlowDecisionRequiresCondition(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("FlowDecisionRequiresCondition", SR.Culture), new object[] { param0 });
        }

        internal static string FlowNodeCannotBeShared(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("FlowNodeCannotBeShared", SR.Culture), new object[] { param0, param1 });
        }

        internal static string FlowNodeLockedForRuntime(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("FlowNodeLockedForRuntime", SR.Culture), new object[] { param0 });
        }

        internal static string FlowSwitchRequiresExpression(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("FlowSwitchRequiresExpression", SR.Culture), new object[] { param0 });
        }

        internal static string ForEachRequiresNonNullValues(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ForEachRequiresNonNullValues", SR.Culture), new object[] { param0 });
        }

        internal static string GetLocationOnPublicAccessReference(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("GetLocationOnPublicAccessReference", SR.Culture), new object[] { param0 });
        }

        internal static string HostIdDoesNotMatchInstance(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("HostIdDoesNotMatchInstance", SR.Culture), new object[] { param0, param1 });
        }

        internal static string IdNotFoundInWorkflow(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("IdNotFoundInWorkflow", SR.Culture), new object[] { param0 });
        }

        internal static string ImplementationVersionMismatch(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ImplementationVersionMismatch", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string IncompatibleTypeForMultidimensionalArrayItemReference(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("IncompatibleTypeForMultidimensionalArrayItemReference", SR.Culture), new object[] { param0, param1 });
        }

        internal static string IncorrectIndexForArgument(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("IncorrectIndexForArgument", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string IndexOutOfBounds(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("IndexOutOfBounds", SR.Culture), new object[] { param0, param1 });
        }

        internal static string IndicesAreNeeded(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("IndicesAreNeeded", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InitialStateCannotBeFinalState(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InitialStateCannotBeFinalState", SR.Culture), new object[] { param0 });
        }

        internal static string InitialStateNotInStatesCollection(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InitialStateNotInStatesCollection", SR.Culture), new object[] { param0 });
        }

        internal static string InlinedLocationReferenceOnlyAccessibleByOwner(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InlinedLocationReferenceOnlyAccessibleByOwner", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InputParametersCountMismatch(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InputParametersCountMismatch", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InputParametersMissing(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InputParametersMissing", SR.Culture), new object[] { param0 });
        }

        internal static string InputParametersTypeMismatch(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InputParametersTypeMismatch", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InsufficientArraySize(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InsufficientArraySize", SR.Culture), new object[] { param0 });
        }

        internal static string InternalConstraintException(object param0, object param1, object param2, object param3)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InternalConstraintException", SR.Culture), new object[] { param0, param1, param2, param3 });
        }

        internal static string InvalidActivityToBlockUpdate(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidActivityToBlockUpdate", SR.Culture), new object[] { param0 });
        }

        internal static string InvalidActivityToBlockUpdateServices(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidActivityToBlockUpdateServices", SR.Culture), new object[] { param0 });
        }

        internal static string InvalidArgumentExpression(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidArgumentExpression", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InvalidAsyncBeginMethodSignature(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidAsyncBeginMethodSignature", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InvalidAsyncCancelMethodSignature(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidAsyncCancelMethodSignature", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InvalidAsyncEndMethodSignature(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidAsyncEndMethodSignature", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InvalidCallbackState(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidCallbackState", SR.Culture), new object[] { param0 });
        }

        internal static string InvalidCompensateActivityUsage(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidCompensateActivityUsage", SR.Culture), new object[] { param0 });
        }

        internal static string InvalidCompensationToken(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidCompensationToken", SR.Culture), new object[] { param0 });
        }

        internal static string InvalidConfirmActivityUsage(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidConfirmActivityUsage", SR.Culture), new object[] { param0 });
        }

        internal static string InvalidDirectionForArgument(object param0, object param1, object param2, object param3)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidDirectionForArgument", SR.Culture), new object[] { param0, param1, param2, param3 });
        }

        internal static string InvalidDynamicActivityProperty(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidDynamicActivityProperty", SR.Culture), new object[] { param0 });
        }

        internal static string InvalidExecutionCallback(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidExecutionCallback", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InvalidExpressionForLocation(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidExpressionForLocation", SR.Culture), new object[] { param0 });
        }

        internal static string InvalidExpressionProperty(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidExpressionProperty", SR.Culture), new object[] { param0 });
        }

        internal static string InvalidFileName(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidFileName", SR.Culture), new object[] { param0 });
        }

        internal static string InvalidGenericTypeInfo(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidGenericTypeInfo", SR.Culture), new object[] { param0 });
        }

        internal static string InvalidImplementationMap(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidImplementationMap", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InvalidImplementationMapAssociation(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidImplementationMapAssociation", SR.Culture), new object[] { param0 });
        }

        internal static string InvalidImplementationMapAssociationServices(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidImplementationMapAssociationServices", SR.Culture), new object[] { param0 });
        }

        internal static string InvalidMergeMap(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidMergeMap", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string InvalidMergeMapArgumentCount(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidMergeMapArgumentCount", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InvalidMergeMapEnvironmentCount(object param0, object param1, object param2, object param3, object param4, object param5)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidMergeMapEnvironmentCount", SR.Culture), new object[] { param0, param1, param2, param3, param4, param5 });
        }

        internal static string InvalidMergeMapForImplementation(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidMergeMapForImplementation", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InvalidMergeMapMemberCount(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidMergeMapMemberCount", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InvalidParameterInfo(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidParameterInfo", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InvalidProperty(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidProperty", SR.Culture), new object[] { param0 });
        }

        internal static string InvalidPropertyType(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidPropertyType", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InvalidRootMergeMap(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidRootMergeMap", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InvalidSourceLocationColumn(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidSourceLocationColumn", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InvalidSourceLocationLineNumber(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidSourceLocationLineNumber", SR.Culture), new object[] { param0, param1 });
        }

        internal static string InvalidTypeForArgument(object param0, object param1, object param2, object param3)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidTypeForArgument", SR.Culture), new object[] { param0, param1, param2, param3 });
        }

        internal static string InvalidUpdateMap(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidUpdateMap", SR.Culture), new object[] { param0 });
        }

        internal static string InvalidXamlMember(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("InvalidXamlMember", SR.Culture), new object[] { param0 });
        }

        internal static string LineNumberTooLarge(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("LineNumberTooLarge", SR.Culture), new object[] { param0 });
        }

        internal static string LiteralsMustBeValueTypesOrImmutableTypes(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("LiteralsMustBeValueTypesOrImmutableTypes", SR.Culture), new object[] { param0, param1 });
        }

        internal static string LocationExpressionCouldNotBeResolved(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("LocationExpressionCouldNotBeResolved", SR.Culture), new object[] { param0 });
        }

        internal static string LocationTypeMismatch(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("LocationTypeMismatch", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string MapEntryNotFound(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("MapEntryNotFound", SR.Culture), new object[] { param0 });
        }

        internal static string MemberCannotBeNull(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("MemberCannotBeNull", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string MemberIsReadOnly(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("MemberIsReadOnly", SR.Culture), new object[] { param0, param1 });
        }

        internal static string MemberNotFound(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("MemberNotFound", SR.Culture), new object[] { param0, param1 });
        }

        internal static string MemberNotSupportedByActivityXamlServices(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("MemberNotSupportedByActivityXamlServices", SR.Culture), new object[] { param0 });
        }

        internal static string MethodInfoRequired(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("MethodInfoRequired", SR.Culture), new object[] { param0 });
        }

        internal static string MethodNameRequired(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("MethodNameRequired", SR.Culture), new object[] { param0 });
        }

        internal static string MissingArgument(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("MissingArgument", SR.Culture), new object[] { param0, param1 });
        }

        internal static string MissingNameProperty(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("MissingNameProperty", SR.Culture), new object[] { param0 });
        }

        internal static string MissingSetAccessorForIndexer(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("MissingSetAccessorForIndexer", SR.Culture), new object[] { param0, param1 });
        }

        internal static string MultipleOverloadGroupsConfigured(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("MultipleOverloadGroupsConfigured", SR.Culture), new object[] { param0 });
        }

        internal static string NativeActivityUpdateInstanceThrewException(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("NativeActivityUpdateInstanceThrewException", SR.Culture), new object[] { param0 });
        }

        internal static string NoNamespace(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("NoNamespace", SR.Culture), new object[] { param0 });
        }

        internal static string NoOutputLocationWasFound(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("NoOutputLocationWasFound", SR.Culture), new object[] { param0 });
        }

        internal static string NoPersistScopeCannotContainPersist(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("NoPersistScopeCannotContainPersist", SR.Culture), new object[] { param0, param1 });
        }

        internal static string NullReferencedMemberAccess(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("NullReferencedMemberAccess", SR.Culture), new object[] { param0, param1 });
        }

        internal static string OneOfTwoPropertiesMustBeSet(object param0, object param1, object param2, object param3)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("OneOfTwoPropertiesMustBeSet", SR.Culture), new object[] { param0, param1, param2, param3 });
        }

        internal static string OptionalExtensionTypeMatchedMultiple(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("OptionalExtensionTypeMatchedMultiple", SR.Culture), new object[] { param0 });
        }

        internal static string OriginalActivityReusedInModifiedDefinition(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("OriginalActivityReusedInModifiedDefinition", SR.Culture), new object[] { param0 });
        }

        internal static string OriginalVariableReusedInModifiedDefinition(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("OriginalVariableReusedInModifiedDefinition", SR.Culture), new object[] { param0 });
        }

        internal static string OriginCannotBeRuntimeIntrinsic(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("OriginCannotBeRuntimeIntrinsic", SR.Culture), new object[] { param0 });
        }

        internal static string OutArgumentCannotHaveInputValue(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("OutArgumentCannotHaveInputValue", SR.Culture), new object[] { param0 });
        }

        internal static string OutOfRangeSourceLocationEndColumn(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("OutOfRangeSourceLocationEndColumn", SR.Culture), new object[] { param0 });
        }

        internal static string OutOfRangeSourceLocationEndLine(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("OutOfRangeSourceLocationEndLine", SR.Culture), new object[] { param0 });
        }

        internal static string OverloadGroupHasSubsets(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("OverloadGroupHasSubsets", SR.Culture), new object[] { param0, param1 });
        }

        internal static string OverloadGroupsAreEquivalent(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("OverloadGroupsAreEquivalent", SR.Culture), new object[] { param0 });
        }

        internal static string ParallelForEachRequiresNonNullValues(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ParallelForEachRequiresNonNullValues", SR.Culture), new object[] { param0 });
        }

        internal static string PermissionArgumentWrongType(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("PermissionArgumentWrongType", SR.Culture), new object[] { param0 });
        }

        internal static string PickBranchRequiresTrigger(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("PickBranchRequiresTrigger", SR.Culture), new object[] { param0 });
        }

        internal static string PropertyCannotBeModified(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("PropertyCannotBeModified", SR.Culture), new object[] { param0 });
        }

        internal static string PropertyMemberNotSupportedByActivityXamlServices(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("PropertyMemberNotSupportedByActivityXamlServices", SR.Culture), new object[] { param0 });
        }

        internal static string PropertyReadOnlyInWorkflowDataContext(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("PropertyReadOnlyInWorkflowDataContext", SR.Culture), new object[] { param0 });
        }

        internal static string PropertyReferenceNotFound(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("PropertyReferenceNotFound", SR.Culture), new object[] { param0 });
        }

        internal static string PublicMethodWithMatchingParameterDoesNotExist(object param0, object param1, object param2, object param3)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("PublicMethodWithMatchingParameterDoesNotExist", SR.Culture), new object[] { param0, param1, param2, param3 });
        }

        internal static string PublicReferencesOnActivityRequiringArgumentResolution(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("PublicReferencesOnActivityRequiringArgumentResolution", SR.Culture), new object[] { param0 });
        }

        internal static string QueryActivityIsInImplementation(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("QueryActivityIsInImplementation", SR.Culture), new object[] { param0 });
        }

        internal static string QueryActivityIsPublic(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("QueryActivityIsPublic", SR.Culture), new object[] { param0 });
        }

        internal static string QueryVariableIsInImplementation(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("QueryVariableIsInImplementation", SR.Culture), new object[] { param0 });
        }

        internal static string QueryVariableIsPublic(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("QueryVariableIsPublic", SR.Culture), new object[] { param0 });
        }

        internal static string ReadAccessToWriteOnlyPublicReference(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ReadAccessToWriteOnlyPublicReference", SR.Culture), new object[] { param0 });
        }

        internal static string ReadonlyPropertyCannotBeSet(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ReadonlyPropertyCannotBeSet", SR.Culture), new object[] { param0, param1 });
        }

        internal static string RequiredArgumentValueNotSupplied(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("RequiredArgumentValueNotSupplied", SR.Culture), new object[] { param0 });
        }

        internal static string RequiredExtensionTypeNotFound(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("RequiredExtensionTypeNotFound", SR.Culture), new object[] { param0 });
        }

        internal static string RequiredVariableCoundNotBeExtracted(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("RequiredVariableCoundNotBeExtracted", SR.Culture), new object[] { param0, param1 });
        }

        internal static string RequireExtensionOnlyAcceptsReferenceTypes(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("RequireExtensionOnlyAcceptsReferenceTypes", SR.Culture), new object[] { param0 });
        }

        internal static string ResultArgumentHasRequiredTypeAndDirection(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ResultArgumentHasRequiredTypeAndDirection", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string ResultArgumentMustBeSpecificType(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ResultArgumentMustBeSpecificType", SR.Culture), new object[] { param0 });
        }

        internal static string RethrowMustBeAPublicChild(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("RethrowMustBeAPublicChild", SR.Culture), new object[] { param0 });
        }

        internal static string RethrowNotInATryCatch(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("RethrowNotInATryCatch", SR.Culture), new object[] { param0 });
        }

        internal static string ReturnTypeIncompatible(object param0, object param1, object param2, object param3, object param4)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ReturnTypeIncompatible", SR.Culture), new object[] { param0, param1, param2, param3, param4 });
        }

        internal static string RootActivityAlreadyAssociatedWithInstance(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("RootActivityAlreadyAssociatedWithInstance", SR.Culture), new object[] { param0 });
        }

        internal static string RootActivityCannotBeReferenced(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("RootActivityCannotBeReferenced", SR.Culture), new object[] { param0, param1 });
        }

        internal static string RuntimeArgumentBindingInvalid(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("RuntimeArgumentBindingInvalid", SR.Culture), new object[] { param0, param1 });
        }

        internal static string RuntimeArgumentChangeBlockDU(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("RuntimeArgumentChangeBlockDU", SR.Culture), new object[] { param0 });
        }

        internal static string RuntimeArgumentNotOpen(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("RuntimeArgumentNotOpen", SR.Culture), new object[] { param0 });
        }

        internal static string RuntimeTransactionHandleNotRegisteredAsExecutionProperty(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("RuntimeTransactionHandleNotRegisteredAsExecutionProperty", SR.Culture), new object[] { param0 });
        }

        internal static string SchemaContextFromBeforeInitializeComponentXBTExtensionCannotBeGeneric(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("SchemaContextFromBeforeInitializeComponentXBTExtensionCannotBeGeneric", SR.Culture), new object[] { param0 });
        }

        internal static string SchemaContextFromBeforeInitializeComponentXBTExtensionNotFound(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("SchemaContextFromBeforeInitializeComponentXBTExtensionNotFound", SR.Culture), new object[] { param0 });
        }

        internal static string SimpleStateMustHaveOneTransition(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("SimpleStateMustHaveOneTransition", SR.Culture), new object[] { param0 });
        }

        internal static string SpecialMethodNotFound(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("SpecialMethodNotFound", SR.Culture), new object[] { param0, param1 });
        }

        internal static string StateCannotBeAddedTwice(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("StateCannotBeAddedTwice", SR.Culture), new object[] { param0 });
        }

        internal static string StateCannotBeSerialized(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("StateCannotBeSerialized", SR.Culture), new object[] { param0 });
        }

        internal static string StateMachineMustHaveInitialState(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("StateMachineMustHaveInitialState", SR.Culture), new object[] { param0 });
        }

        internal static string StateNotBelongToAnyParent(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("StateNotBelongToAnyParent", SR.Culture), new object[] { param0, param1 });
        }

        internal static string SubexpressionResultWasNotVisible(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("SubexpressionResultWasNotVisible", SR.Culture), new object[] { param0 });
        }

        internal static string SubexpressionResultWasNull(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("SubexpressionResultWasNull", SR.Culture), new object[] { param0 });
        }

        internal static string SwitchCaseKeyTypesMustMatchExpressionType(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("SwitchCaseKeyTypesMustMatchExpressionType", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string SwitchCaseNullWithValueType(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("SwitchCaseNullWithValueType", SR.Culture), new object[] { param0 });
        }

        internal static string SwitchCaseTypeMismatch(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("SwitchCaseTypeMismatch", SR.Culture), new object[] { param0, param1 });
        }

        internal static string SymbolNamesMustBeUnique(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("SymbolNamesMustBeUnique", SR.Culture), new object[] { param0 });
        }

        internal static string SymbolResolverDoesNotHaveSymbol(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("SymbolResolverDoesNotHaveSymbol", SR.Culture), new object[] { param0, param1 });
        }

        internal static string TargetTypeAndTargetObjectAreMutuallyExclusive(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("TargetTypeAndTargetObjectAreMutuallyExclusive", SR.Culture), new object[] { param0, param1 });
        }

        internal static string TargetTypeCannotBeEnum(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("TargetTypeCannotBeEnum", SR.Culture), new object[] { param0, param1 });
        }

        internal static string TargetTypeIsValueType(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("TargetTypeIsValueType", SR.Culture), new object[] { param0, param1 });
        }

        internal static string TextExpressionCompilerNoCodebase(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("TextExpressionCompilerNoCodebase", SR.Culture), new object[] { param0 });
        }

        internal static string TextExpressionCompilerUnableToLoadAssembly(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("TextExpressionCompilerUnableToLoadAssembly", SR.Culture), new object[] { param0 });
        }

        internal static string TextExpressionMetadataRequiresCompilation(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("TextExpressionMetadataRequiresCompilation", SR.Culture), new object[] { param0 });
        }

        internal static string TimeoutOnOperation(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("TimeoutOnOperation", SR.Culture), new object[] { param0 });
        }

        internal static string TransitionCannotBeAddedTwice(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("TransitionCannotBeAddedTwice", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string TransitionTargetCannotBeNull(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("TransitionTargetCannotBeNull", SR.Culture), new object[] { param0, param1 });
        }

        internal static string TryCatchInvalidStateForUpdate(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("TryCatchInvalidStateForUpdate", SR.Culture), new object[] { param0 });
        }

        internal static string TypeConverterHelperCacheAddFailed(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("TypeConverterHelperCacheAddFailed", SR.Culture), new object[] { param0 });
        }

        internal static string TypeMismatchForAssign(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("TypeMismatchForAssign", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string TypeMustbeValueType(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("TypeMustbeValueType", SR.Culture), new object[] { param0 });
        }

        internal static string TypeNotAssignableTo(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("TypeNotAssignableTo", SR.Culture), new object[] { param0, param1 });
        }

        internal static string UnableToLocateCompiledLocationContext(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("UnableToLocateCompiledLocationContext", SR.Culture), new object[] { param0 });
        }

        internal static string UnconditionalTransitionShouldNotShareNullTriggersWithOthers(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("UnconditionalTransitionShouldNotShareNullTriggersWithOthers", SR.Culture), new object[] { param0, param1 });
        }

        internal static string UnconditionalTransitionShouldNotShareTriggersWithOthers(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("UnconditionalTransitionShouldNotShareTriggersWithOthers", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string UnexpectedArgumentCount(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("UnexpectedArgumentCount", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string UnexpectedExpressionNodeType(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("UnexpectedExpressionNodeType", SR.Culture), new object[] { param0, param1 });
        }

        internal static string UnknownExpressionCompilationError(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("UnknownExpressionCompilationError", SR.Culture), new object[] { param0 });
        }

        internal static string UnknownLanguage(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("UnknownLanguage", SR.Culture), new object[] { param0 });
        }

        internal static string UnopenedActivitiesCannotBeExecuted(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("UnopenedActivitiesCannotBeExecuted", SR.Culture), new object[] { param0 });
        }

        internal static string UnsupportedExpressionType(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("UnsupportedExpressionType", SR.Culture), new object[] { param0 });
        }

        internal static string UnsupportedMemberExpressionWithType(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("UnsupportedMemberExpressionWithType", SR.Culture), new object[] { param0 });
        }

        internal static string UnsupportedReferenceExpressionType(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("UnsupportedReferenceExpressionType", SR.Culture), new object[] { param0 });
        }

        internal static string UnusedInputArguments(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("UnusedInputArguments", SR.Culture), new object[] { param0 });
        }

        internal static string UpdateMapBuilderRequiredProperty(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("UpdateMapBuilderRequiredProperty", SR.Culture), new object[] { param0 });
        }

        internal static string ValidationContextCannotBeNull(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ValidationContextCannotBeNull", SR.Culture), new object[] { param0, param1 });
        }

        internal static string ValidationErrorPrefixForHiddenActivity(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ValidationErrorPrefixForHiddenActivity", SR.Culture), new object[] { param0 });
        }

        internal static string ValidationErrorPrefixForPublicActivityWithHiddenParent(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("ValidationErrorPrefixForPublicActivityWithHiddenParent", SR.Culture), new object[] { param0, param1 });
        }

        internal static string VariableAlreadyInUseOnActivity(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("VariableAlreadyInUseOnActivity", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string VariableCannotBePopulatedInLocationEnvironment(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("VariableCannotBePopulatedInLocationEnvironment", SR.Culture), new object[] { param0 });
        }

        internal static string VariableDoesNotExist(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("VariableDoesNotExist", SR.Culture), new object[] { param0 });
        }

        internal static string VariableExpressionTypeMismatch(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("VariableExpressionTypeMismatch", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string VariableIsReadOnly(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("VariableIsReadOnly", SR.Culture), new object[] { param0 });
        }

        internal static string VariableNameNotAnIdentifier(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("VariableNameNotAnIdentifier", SR.Culture), new object[] { param0 });
        }

        internal static string VariableNotOpen(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("VariableNotOpen", SR.Culture), new object[] { param0, param1 });
        }

        internal static string VariableNotVisible(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("VariableNotVisible", SR.Culture), new object[] { param0 });
        }

        internal static string VariableOnlyAccessibleAtScopeOfDeclaration(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("VariableOnlyAccessibleAtScopeOfDeclaration", SR.Culture), new object[] { param0, param1 });
        }

        internal static string VariableOrArgumentDoesNotExist(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("VariableOrArgumentDoesNotExist", SR.Culture), new object[] { param0 });
        }

        internal static string VariableShouldBeOpen(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("VariableShouldBeOpen", SR.Culture), new object[] { param0 });
        }

        internal static string VariableTypeInvalid(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("VariableTypeInvalid", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string VariableTypeNotMatchLocationType(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("VariableTypeNotMatchLocationType", SR.Culture), new object[] { param0, param1 });
        }

        internal static string VBExpressionTamperedSinceLastCompiled(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("VBExpressionTamperedSinceLastCompiled", SR.Culture), new object[] { param0 });
        }

        internal static string WhileRequiresCondition(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WhileRequiresCondition", SR.Culture), new object[] { param0 });
        }

        internal static string WorkflowAbortedReason(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WorkflowAbortedReason", SR.Culture), new object[] { param0, param1 });
        }

        internal static string WorkflowApplicationAborted(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WorkflowApplicationAborted", SR.Culture), new object[] { param0 });
        }

        internal static string WorkflowApplicationCompleted(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WorkflowApplicationCompleted", SR.Culture), new object[] { param0 });
        }

        internal static string WorkflowApplicationTerminated(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WorkflowApplicationTerminated", SR.Culture), new object[] { param0 });
        }

        internal static string WorkflowApplicationUnloaded(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WorkflowApplicationUnloaded", SR.Culture), new object[] { param0 });
        }

        internal static string WorkflowIdentityNullHostId(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WorkflowIdentityNullHostId", SR.Culture), new object[] { param0 });
        }

        internal static string WorkflowIdentityNullStateId(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WorkflowIdentityNullStateId", SR.Culture), new object[] { param0 });
        }

        internal static string WorkflowIdentityStateIdHostIdMismatch(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WorkflowIdentityStateIdHostIdMismatch", SR.Culture), new object[] { param0, param1 });
        }

        internal static string WorkflowInstanceAborted(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WorkflowInstanceAborted", SR.Culture), new object[] { param0 });
        }

        internal static string WorkflowInstanceIsReadOnly(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WorkflowInstanceIsReadOnly", SR.Culture), new object[] { param0 });
        }

        internal static string WorkflowInstanceNotFoundInStore(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WorkflowInstanceNotFoundInStore", SR.Culture), new object[] { param0 });
        }

        internal static string WorkflowInstanceUnlocked(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WorkflowInstanceUnlocked", SR.Culture), new object[] { param0 });
        }

        internal static string WriteAccessToReadOnlyPublicReference(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WriteAccessToReadOnlyPublicReference", SR.Culture), new object[] { param0 });
        }

        internal static string WriteonlyPropertyCannotBeRead(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WriteonlyPropertyCannotBeRead", SR.Culture), new object[] { param0, param1 });
        }

        internal static string WrongArgumentType(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WrongArgumentType", SR.Culture), new object[] { param0, param1 });
        }

        internal static string WrongEnvironmentCount(object param0, object param1, object param2, object param3, object param4, object param5, object param6, object param7, object param8)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WrongEnvironmentCount", SR.Culture), new object[] { param0, param1, param2, param3, param4, param5, param6, param7, param8 });
        }

        internal static string WrongMemberCount(object param0, object param1, object param2)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WrongMemberCount", SR.Culture), new object[] { param0, param1, param2 });
        }

        internal static string WrongOriginalEnvironmentCount(object param0, object param1, object param2, object param3, object param4, object param5, object param6)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("WrongOriginalEnvironmentCount", SR.Culture), new object[] { param0, param1, param2, param3, param4, param5, param6 });
        }

        internal static string XamlBuildTaskResourceNotFound(object param0)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("XamlBuildTaskResourceNotFound", SR.Culture), new object[] { param0 });
        }

        internal static string XamlElementExpectedAt(object param0, object param1)
        {
            return string.Format(SR.Culture, SR.ResourceManager.GetString("XamlElementExpectedAt", SR.Culture), new object[] { param0, param1 });
        }
    }
}
