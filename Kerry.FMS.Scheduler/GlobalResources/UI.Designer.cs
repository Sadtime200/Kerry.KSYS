﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kerry.FMS.Scheduler {
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
    public class UI {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UI() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Kerry.FMS.Scheduler.GlobalResources.UI", typeof(UI).Assembly);
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
        ///   Looks up a localized string similar to &lt;span class=&apos;glyphicon glyphicon glyphicon-edit&apos;&gt;&lt;/span&gt;.
        /// </summary>
        public static string Constant_Edit {
            get {
                return ResourceManager.GetString("Constant_Edit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;span class=&apos;glyphicon glyphicon glyphicon-pause&apos;&gt;&lt;/span&gt;.
        /// </summary>
        public static string Constant_Pause {
            get {
                return ResourceManager.GetString("Constant_Pause", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;span class=&apos;glyphicon glyphicon glyphicon-refresh&apos;&gt;&lt;/span&gt;.
        /// </summary>
        public static string Constant_Refresh {
            get {
                return ResourceManager.GetString("Constant_Refresh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;span class=&apos;glyphicon glyphicon glyphicon-play&apos;&gt;&lt;/span&gt;.
        /// </summary>
        public static string Constant_Run {
            get {
                return ResourceManager.GetString("Constant_Run", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} is required!.
        /// </summary>
        public static string Validation_Required_Error {
            get {
                return ResourceManager.GetString("Validation_Required_Error", resourceCulture);
            }
        }
    }
}
