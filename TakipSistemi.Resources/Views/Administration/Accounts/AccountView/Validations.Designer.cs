﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TakipSistemi.Resources.Views.Administration.Accounts.AccountView {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Validations {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Validations() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TakipSistemi.Resources.Views.Administration.Accounts.AccountView.Validations", typeof(Validations).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recovery token is already expired..
        /// </summary>
        public static string ExpiredToken {
            get {
                return ResourceManager.GetString("ExpiredToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The username or password is incorrect..
        /// </summary>
        public static string IncorrectAuthentication {
            get {
                return ResourceManager.GetString("IncorrectAuthentication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password is incorrect..
        /// </summary>
        public static string IncorrectPassword {
            get {
                return ResourceManager.GetString("IncorrectPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your account is locked..
        /// </summary>
        public static string LockedAccount {
            get {
                return ResourceManager.GetString("LockedAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to E-mail address is already being used..
        /// </summary>
        public static string UniqueEmail {
            get {
                return ResourceManager.GetString("UniqueEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username is already taken..
        /// </summary>
        public static string UniqueUsername {
            get {
                return ResourceManager.GetString("UniqueUsername", resourceCulture);
            }
        }
    }
}
