﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.PackageManagement.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.PackageManagement.Internal.Resources.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version {0} of the Package Provider {1} is already loaded. Since this is an assembly-based provider, we cannot load another version..
        /// </summary>
        internal static string AssemblyPackageProviderAlreadyLoaded {
            get {
                return ResourceManager.GetString("AssemblyPackageProviderAlreadyLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to create specified folder &apos;{0}&apos;..
        /// </summary>
        internal static string CreatefolderFailed {
            get {
                return ResourceManager.GetString("CreatefolderFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dependent Package &apos;{0}&apos; failed to install..
        /// </summary>
        internal static string DependentPackageFailedInstall_dependency {
            get {
                return ResourceManager.GetString("DependentPackageFailedInstall_dependency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination Path not set..
        /// </summary>
        internal static string DestinationPathNotSet {
            get {
                return ResourceManager.GetString("DestinationPathNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provider &apos;{0}&apos; is ignored because the other provider with the same name has already been imported from path &apos;{1}&apos;..
        /// </summary>
        internal static string DuplicatedProviderName {
            get {
                return ResourceManager.GetString("DuplicatedProviderName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PowerShell meta provider initialization failed..
        /// </summary>
        internal static string FailedPowerShellMetaProvider {
            get {
                return ResourceManager.GetString("FailedPowerShellMetaProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to bootstrap provider &apos;{0}&apos;..
        /// </summary>
        internal static string FailedProviderBootstrap {
            get {
                return ResourceManager.GetString("FailedProviderBootstrap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to re-import the provider &apos;{0}&apos;..
        /// </summary>
        internal static string FailToReImportProvider {
            get {
                return ResourceManager.GetString("FailToReImportProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File from &apos;{0}&apos; failed signature validation. .
        /// </summary>
        internal static string FileFailedVerification {
            get {
                return ResourceManager.GetString("FileFailedVerification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified file &apos;{0}&apos; is not found..
        /// </summary>
        internal static string FileNotFound {
            get {
                return ResourceManager.GetString("FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The hash expected &apos;{0}&apos; is not equal to the hash &apos;{1}&apos; computed from the file to be download..
        /// </summary>
        internal static string HashNotEqual {
            get {
                return ResourceManager.GetString("HashNotEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Importing package provider &apos;{0}&apos;..
        /// </summary>
        internal static string ImportPackageProvider {
            get {
                return ResourceManager.GetString("ImportPackageProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Administrator rights are required to install packages in &apos;{0}&apos;. Log on to the computer with an account that has Administrator rights, and then try again, or install &apos;{1}&apos; by adding &quot;-Scope CurrentUser&quot; to your command. You can also try running the Windows PowerShell session with elevated rights (Run as Administrator)..
        /// </summary>
        internal static string InstallRequiresCurrentUserScopeParameterForNonAdminUser {
            get {
                return ResourceManager.GetString("InstallRequiresCurrentUserScopeParameterForNonAdminUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The filename specified is not valid..
        /// </summary>
        internal static string InvalidFilename {
            get {
                return ResourceManager.GetString("InvalidFilename", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified provider &apos;{0}&apos; was not loaded because no valid type was found. The supported file types are &apos;{1}&apos;..
        /// </summary>
        internal static string InvalidFileType {
            get {
                return ResourceManager.GetString("InvalidFileType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format of the specified hash &apos;{0}&apos; is invalid..
        /// </summary>
        internal static string InvalidHashFormat {
            get {
                return ResourceManager.GetString("InvalidHashFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wildcards in the &apos;{0}&apos; is not supported. Please specify a full provider name..
        /// </summary>
        internal static string InvalidParameter {
            get {
                return ResourceManager.GetString("InvalidParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to import the specified provider &apos;{0}&apos;. Please check if it is a valid PackageManagement provider..
        /// </summary>
        internal static string InvalidProvider {
            get {
                return ResourceManager.GetString("InvalidProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified version range is invalid. Minimum Version:{0} MaximumVersion:{1}.
        /// </summary>
        internal static string InvalidVersionRange {
            get {
                return ResourceManager.GetString("InvalidVersionRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading an assembly &apos;{0}&apos;..
        /// </summary>
        internal static string LoadingAssembly {
            get {
                return ResourceManager.GetString("LoadingAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading a PowerShell module &apos;{0}&apos;..
        /// </summary>
        internal static string LoadingPowerShellModule {
            get {
                return ResourceManager.GetString("LoadingPowerShellModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing File xml tag..
        /// </summary>
        internal static string MissingFileTag {
            get {
                return ResourceManager.GetString("MissingFileTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing the hash attribute within the File xml tag..
        /// </summary>
        internal static string MissingHashAttribute {
            get {
                return ResourceManager.GetString("MissingHashAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the hash xml attribue is empty..
        /// </summary>
        internal static string MissingHashContent {
            get {
                return ResourceManager.GetString("MissingHashContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter &apos;{0}&apos; is required for this operation.
        /// </summary>
        internal static string MissingRequiredParameter {
            get {
                return ResourceManager.GetString("MissingRequiredParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find package provider: {0}..
        /// </summary>
        internal static string ModuleWithVersionNotFound {
            get {
                return ResourceManager.GetString("ModuleWithVersionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No match was found for the specified search criteria and provider name &apos;{0}&apos;. Try &apos;Get-PackageProvider -ListAvailable&apos; to see if the provider exists on the system..
        /// </summary>
        internal static string NoMatchFoundForCriteria {
            get {
                return ResourceManager.GetString("NoMatchFoundForCriteria", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package source &apos;{0}&apos; already exists with that provider..
        /// </summary>
        internal static string PackageSourceExists {
            get {
                return ResourceManager.GetString("PackageSourceExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A protocol handler for scheme &apos;{0}&apos; is not available..
        /// </summary>
        internal static string ProtocolNotSupported {
            get {
                return ResourceManager.GetString("ProtocolNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provider &apos;{0}&apos; has already been imported..
        /// </summary>
        internal static string ProviderImportedAlready {
            get {
                return ResourceManager.GetString("ProviderImportedAlready", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified assembly &apos;{0}&apos; is installed at top level directory. However it is recommended that the assemblies should be installed under its ProviderName\Version folder..
        /// </summary>
        internal static string ProviderNameAndVersionNotAvailableFromFilePath {
            get {
                return ResourceManager.GetString("ProviderNameAndVersionNotAvailableFromFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provider &apos;{0}&apos; failed to load..
        /// </summary>
        internal static string ProviderPluginLoadFailure {
            get {
                return ResourceManager.GetString("ProviderPluginLoadFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provider {0} is successfully loaded..
        /// </summary>
        internal static string ProviderSuccessfullyLoaded {
            get {
                return ResourceManager.GetString("ProviderSuccessfullyLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provider is loaded from path: &apos;{0}&apos;..
        /// </summary>
        internal static string ProviderSuccessfullyLoadedFromLocation {
            get {
                return ResourceManager.GetString("ProviderSuccessfullyLoadedFromLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to download the list of available providers. Check your internet connection..
        /// </summary>
        internal static string ProviderSwidtagUnavailable {
            get {
                return ResourceManager.GetString("ProviderSwidtagUnavailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provider &apos;{0}&apos; has already been imported. Trying to import it again..
        /// </summary>
        internal static string ReImportProvider {
            get {
                return ResourceManager.GetString("ReImportProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removal of the environment variable &apos;{0}&apos; requires elevation.
        /// </summary>
        internal static string RemoveEnvironmentVariableRequiresElevation {
            get {
                return ResourceManager.GetString("RemoveEnvironmentVariableRequiresElevation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A protocol handler for scheme &apos;{0}&apos; is not available..
        /// </summary>
        internal static string SchemeNotSupported {
            get {
                return ResourceManager.GetString("SchemeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple assemblies are found under path &apos;{0}&apos;. Please install a single provider assembly under each version folder.  .
        /// </summary>
        internal static string SingleAssemblyAllowed {
            get {
                return ResourceManager.GetString("SingleAssemblyAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skipping previously processed assembly: {0}..
        /// </summary>
        internal static string SkippingProcessedAssembly {
            get {
                return ResourceManager.GetString("SkippingProcessedAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skipping previously processed provider &apos;{0}&apos;..
        /// </summary>
        internal static string SkipPreviousProcessedProvider {
            get {
                return ResourceManager.GetString("SkipPreviousProcessedProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source location &apos;{0}&apos; is not valid for this provider..
        /// </summary>
        internal static string SourceLocationNotValid_Location {
            get {
                return ResourceManager.GetString("SourceLocationNotValid_Location", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to copy file to destination &apos;{0}&apos;..
        /// </summary>
        internal static string UnableToCopyFileTo {
            get {
                return ResourceManager.GetString("UnableToCopyFileTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to create shortcut for file &apos;{0}&apos; that does not exist .
        /// </summary>
        internal static string UnableToCreateShortcutTargetDoesNotExist {
            get {
                return ResourceManager.GetString("UnableToCreateShortcutTargetDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to download from URI &apos;{0}&apos; to &apos;{1}&apos;..
        /// </summary>
        internal static string UnableToDownload {
            get {
                return ResourceManager.GetString("UnableToDownload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to import provider &apos;{0}&apos; under the current file path. The known provider search paths are &apos;{1}.&apos;.
        /// </summary>
        internal static string UnableToImportProvider {
            get {
                return ResourceManager.GetString("UnableToImportProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package &apos;{0}&apos; failed to install..
        /// </summary>
        internal static string UnableToInstallPackage_package_reason {
            get {
                return ResourceManager.GetString("UnableToInstallPackage_package_reason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to overwrite existing file &apos;{0}&apos;..
        /// </summary>
        internal static string UnableToOverwriteExistingFile {
            get {
                return ResourceManager.GetString("UnableToOverwriteExistingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to remove existing file &apos;{0}&apos;..
        /// </summary>
        internal static string UnableToRemoveFile {
            get {
                return ResourceManager.GetString("UnableToRemoveFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to resolve package dependency -- package &apos;{0}&apos; not found..
        /// </summary>
        internal static string UnableToResolveDependency_dependencyPackage {
            get {
                return ResourceManager.GetString("UnableToResolveDependency_dependencyPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to resolve package reference &apos;{0}&apos;..
        /// </summary>
        internal static string UnableToResolvePackage {
            get {
                return ResourceManager.GetString("UnableToResolvePackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to resolve package source &apos;{0}&apos;..
        /// </summary>
        internal static string UnableToResolveSource_NameOrLocation {
            get {
                return ResourceManager.GetString("UnableToResolveSource_NameOrLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to uninstall package..
        /// </summary>
        internal static string UnableToUninstallPackage {
            get {
                return ResourceManager.GetString("UnableToUninstallPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown Folder Id &apos;{0}&apos;..
        /// </summary>
        internal static string UnknownFolderId {
            get {
                return ResourceManager.GetString("UnknownFolderId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find package provider &apos;{0}&apos;..
        /// </summary>
        internal static string UnknownProvider {
            get {
                return ResourceManager.GetString("UnknownProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The archive file type is not supported..
        /// </summary>
        internal static string UnsupportedArchive {
            get {
                return ResourceManager.GetString("UnsupportedArchive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified hash algorithm &apos;{0}&apos; is not supported. Please try using &apos;{1}&apos; instead..
        /// </summary>
        internal static string UnsupportedHashAlgorithm {
            get {
                return ResourceManager.GetString("UnsupportedHashAlgorithm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provider type is not supported..
        /// </summary>
        internal static string UnsupportedProviderType {
            get {
                return ResourceManager.GetString("UnsupportedProviderType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ??? not used ???.
        /// </summary>
        internal static string UriSchemeNotSupported_Scheme {
            get {
                return ResourceManager.GetString("UriSchemeNotSupported_Scheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User declined to install untrusted package &apos;{0}&apos;..
        /// </summary>
        internal static string UserDeclinedUntrustedPackageInstall {
            get {
                return ResourceManager.GetString("UserDeclinedUntrustedPackageInstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requiredVersion, minimumVersion or maximumVersion property applies to PowerShell modules. For the assembly providers, it is ignored..
        /// </summary>
        internal static string VersionPropertyWillbeIgnored {
            get {
                return ResourceManager.GetString("VersionPropertyWillbeIgnored", resourceCulture);
            }
        }
    }
}
