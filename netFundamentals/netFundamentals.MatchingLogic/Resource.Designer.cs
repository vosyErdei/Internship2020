﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace netFundamentals.MatchingLogic {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("netFundamentals.MatchingLogic.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to COMPLETED.
        /// </summary>
        internal static string CompletedState {
            get {
                return ResourceManager.GetString("CompletedState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a failure during the matching process..
        /// </summary>
        internal static string FailureMessage {
            get {
                return ResourceManager.GetString("FailureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Match is done on element Id = {0}!.
        /// </summary>
        internal static string MatchIsDoneMessage {
            get {
                return ResourceManager.GetString("MatchIsDoneMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to These two people have a matching hobby..
        /// </summary>
        internal static string SuccessMessage {
            get {
                return ResourceManager.GetString("SuccessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [ValidationStatus = {0}, MatchState = {1}, ImportEntryId = {2}, MatchingEntryId = {3}, Message = {4}].
        /// </summary>
        internal static string ValidationLog {
            get {
                return ResourceManager.GetString("ValidationLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NOTFOUND.
        /// </summary>
        internal static string WrongMatchStatus {
            get {
                return ResourceManager.GetString("WrongMatchStatus", resourceCulture);
            }
        }
    }
}
