﻿
namespace ComPDFKit.Controls.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::ComPDFKit.Controls.Data.CustomStampList CustomStampList {
            get {
                return ((global::ComPDFKit.Controls.Data.CustomStampList)(this["CustomStampList"]));
            }
            set {
                this["CustomStampList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::ComPDFKit.Controls.Data.SignatureList SignatureList {
            get {
                return ((global::ComPDFKit.Controls.Data.SignatureList)(this["SignatureList"]));
            }
            set {
                this["SignatureList"] = value;
            }
        }
    }
}