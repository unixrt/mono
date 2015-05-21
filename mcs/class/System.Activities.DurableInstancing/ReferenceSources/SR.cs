using System;
using System.Globalization;
using System.Resources;

namespace System.Activities.DurableInstancing
{
    internal class SR
    {
        private static ResourceManager resourceManager;

        private static CultureInfo resourceCulture;

        internal static string CleanupInProgress
        {
            get
            {
                return SR.ResourceManager.GetString("CleanupInProgress", SR.Culture);
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

        internal static string HostLockExpired
        {
            get
            {
                return SR.ResourceManager.GetString("HostLockExpired", SR.Culture);
            }
        }

        internal static string HostLockNotFound
        {
            get
            {
                return SR.ResourceManager.GetString("HostLockNotFound", SR.Culture);
            }
        }

        internal static string IdentityNotSupportedWithActivation
        {
            get
            {
                return SR.ResourceManager.GetString("IdentityNotSupportedWithActivation", SR.Culture);
            }
        }

        internal static string InstanceKeyMetadataChangesNotSupported
        {
            get
            {
                return SR.ResourceManager.GetString("InstanceKeyMetadataChangesNotSupported", SR.Culture);
            }
        }

        internal static string InstanceStoreReadOnly
        {
            get
            {
                return SR.ResourceManager.GetString("InstanceStoreReadOnly", SR.Culture);
            }
        }

        internal static string MultipleLockOwnersNotSupported
        {
            get
            {
                return SR.ResourceManager.GetString("MultipleLockOwnersNotSupported", SR.Culture);
            }
        }

        internal static string NonWASActivationNotSupported
        {
            get
            {
                return SR.ResourceManager.GetString("NonWASActivationNotSupported", SR.Culture);
            }
        }

        internal static ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(SR.resourceManager, null))
                {
                    SR.resourceManager = new ResourceManager("System.Activities.DurableInstancing.SR", typeof(SR).Assembly);
                }
                return SR.resourceManager;
            }
        }

        internal static string TryLoadRequiresWorkflowType
        {
            get
            {
                return SR.ResourceManager.GetString("TryLoadRequiresWorkflowType", SR.Culture);
            }
        }

        internal static string UnknownDatabaseVersion
        {
            get
            {
                return SR.ResourceManager.GetString("UnknownDatabaseVersion", SR.Culture);
            }
        }

        private SR()
        {
        }

        internal static string CanNotDefineNullForAPromotion(object param0, object param1)
        {
            CultureInfo culture = SR.Culture;
            string str = SR.ResourceManager.GetString("CanNotDefineNullForAPromotion", SR.Culture);
            object[] objArray = new object[] { param0, param1 };
            return string.Format(culture, str, objArray);
        }

        internal static string CannotPromoteAsSqlVariant(object param0, object param1)
        {
            CultureInfo culture = SR.Culture;
            string str = SR.ResourceManager.GetString("CannotPromoteAsSqlVariant", SR.Culture);
            object[] objArray = new object[] { param0, param1 };
            return string.Format(culture, str, objArray);
        }

        internal static string CannotPromoteXNameTwiceInPromotion(object param0, object param1)
        {
            CultureInfo culture = SR.Culture;
            string str = SR.ResourceManager.GetString("CannotPromoteXNameTwiceInPromotion", SR.Culture);
            object[] objArray = new object[] { param0, param1 };
            return string.Format(culture, str, objArray);
        }

        internal static string DatabaseUpgradeRequiredForCommand(object param0, object param1, object param2)
        {
            CultureInfo culture = SR.Culture;
            string str = SR.ResourceManager.GetString("DatabaseUpgradeRequiredForCommand", SR.Culture);
            object[] objArray = new object[] { param0, param1, param2 };
            return string.Format(culture, str, objArray);
        }

        internal static string InvalidLockRenewalPeriod(object param0, object param1)
        {
            CultureInfo culture = SR.Culture;
            string str = SR.ResourceManager.GetString("InvalidLockRenewalPeriod", SR.Culture);
            object[] objArray = new object[] { param0, param1 };
            return string.Format(culture, str, objArray);
        }

        internal static string InvalidMetadataValue(object param0, object param1)
        {
            CultureInfo culture = SR.Culture;
            string str = SR.ResourceManager.GetString("InvalidMetadataValue", SR.Culture);
            object[] objArray = new object[] { param0, param1 };
            return string.Format(culture, str, objArray);
        }

        internal static string InvalidRunnableInstancesDetectionPeriod(object param0, object param1)
        {
            CultureInfo culture = SR.Culture;
            string str = SR.ResourceManager.GetString("InvalidRunnableInstancesDetectionPeriod", SR.Culture);
            object[] objArray = new object[] { param0, param1 };
            return string.Format(culture, str, objArray);
        }

        internal static string NoPromotionsDefined(object param0)
        {
            CultureInfo culture = SR.Culture;
            string str = SR.ResourceManager.GetString("NoPromotionsDefined", SR.Culture);
            object[] objArray = new object[] { param0 };
            return string.Format(culture, str, objArray);
        }

        internal static string PromotionAlreadyDefined(object param0)
        {
            CultureInfo culture = SR.Culture;
            string str = SR.ResourceManager.GetString("PromotionAlreadyDefined", SR.Culture);
            object[] objArray = new object[] { param0 };
            return string.Format(culture, str, objArray);
        }

        internal static string PromotionTooManyDefined(object param0, object param1, object param2, object param3)
        {
            CultureInfo culture = SR.Culture;
            string str = SR.ResourceManager.GetString("PromotionTooManyDefined", SR.Culture);
            object[] objArray = new object[] { param0, param1, param2, param3 };
            return string.Format(culture, str, objArray);
        }

        internal static string TimeoutOnSqlOperation(object param0)
        {
            CultureInfo culture = SR.Culture;
            string str = SR.ResourceManager.GetString("TimeoutOnSqlOperation", SR.Culture);
            object[] objArray = new object[] { param0 };
            return string.Format(culture, str, objArray);
        }

        internal static string UnknownCompressionOption(object param0)
        {
            CultureInfo culture = SR.Culture;
            string str = SR.ResourceManager.GetString("UnknownCompressionOption", SR.Culture);
            object[] objArray = new object[] { param0 };
            return string.Format(culture, str, objArray);
        }

        internal static string UnknownSprocResult(object param0)
        {
            CultureInfo culture = SR.Culture;
            string str = SR.ResourceManager.GetString("UnknownSprocResult", SR.Culture);
            object[] objArray = new object[] { param0 };
            return string.Format(culture, str, objArray);
        }
    }
}
