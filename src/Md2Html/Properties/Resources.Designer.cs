﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Md2Html.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Md2Html.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to (c) 2019, 2021 Gregory Karastergios
        ///
        ///(c) 2014 Alan Barber
        ///
        ///Licensed under the Apache License, Version 2.0 (the &quot;License&quot;);
        ///you may not use this file except in compliance with the License.
        ///You may obtain a copy of the License at
        ///
        ///http://www.apache.org/licenses/LICENSE-2.0
        ///
        ///Unless required by applicable law or agreed to in writing, software
        ///distributed under the License is distributed on an &quot;AS IS&quot; BASIS,
        ///WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
        ///See the License for [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string License {
            get {
                return ResourceManager.GetString("License", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: Md2Html &lt;File&gt;.md &lt;Options&gt;
        ///
        ///Options:
        ///
        ///-Header &lt;File&gt;              Adds a header from the file specified
        ///-Footer &lt;File&gt;              Adds a footer from the file specified
        ///-AsteriskIntraWordEmphasis  Allows asterisks to be used for intraword emphasis
        ///-AutoNewLines               Converts RETURN into a literal newline *
        ///-AutoHyperlink              Converts most bare plain URLs into hyperlinks *
        ///-CloseEmptyElements         Uses &apos;/&gt;&apos; instead of &apos;&gt;&apos; to close empty HTML elements for XHTML
        ///-DontLin [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Usage {
            get {
                return ResourceManager.GetString("Usage", resourceCulture);
            }
        }
    }
}
