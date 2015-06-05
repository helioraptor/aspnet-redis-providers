﻿//
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Web.Redis {
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
    internal class RedisProviderResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RedisProviderResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Web.Redis.RedisProviderResource", typeof(RedisProviderResource).Assembly);
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
        ///   Looks up a localized string similar to The specified class &apos;{0}&apos; could not be loaded.  Please make sure that the value specified is an assembly qualified class name..
        /// </summary>
        internal static string LoggingClassNotFound {
            get {
                return ResourceManager.GetString("LoggingClassNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified method &apos;{0}&apos; on the class &apos;{1}&apos; could not be found or does meet the required method signature. Please make sure that it exists, is public and doesn&apos;t take any parameters..
        /// </summary>
        internal static string LoggingMethodNotFound {
            get {
                return ResourceManager.GetString("LoggingMethodNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified method &apos;{0}&apos; on the class &apos;{1}&apos; does not match the required method signature. The method must be defined as \&quot;static\&quot;..
        /// </summary>
        internal static string LoggingMethodNotStatic {
            get {
                return ResourceManager.GetString("LoggingMethodNotStatic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified method &apos;{0}&apos; on the class &apos;{1}&apos; does not match the required method signature. The method must have a return type of \&quot;System.IO.TextWriter\&quot;..
        /// </summary>
        internal static string LoggingMethodWrongReturnType {
            get {
                return ResourceManager.GetString("LoggingMethodWrongReturnType", resourceCulture);
            }
        }
    }
}
