﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScanUploader.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.1.0.0")]
    internal sealed partial class LogFileName : global::System.Configuration.ApplicationSettingsBase {
        
        private static LogFileName defaultInstance = ((LogFileName)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new LogFileName())));
        
        public static LogFileName Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HP")]
        public string prefix {
            get {
                return ((string)(this["prefix"]));
            }
            set {
                this["prefix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("yyyyMMdd")]
        public string dateFormat {
            get {
                return ((string)(this["dateFormat"]));
            }
            set {
                this["dateFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int serialFigureCount {
            get {
                return ((int)(this["serialFigureCount"]));
            }
            set {
                this["serialFigureCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int nextSerialNumber {
            get {
                return ((int)(this["nextSerialNumber"]));
            }
            set {
                this["nextSerialNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".text")]
        public string fileFormat {
            get {
                return ((string)(this["fileFormat"]));
            }
            set {
                this["fileFormat"] = value;
            }
        }
    }
}
