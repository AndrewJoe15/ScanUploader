﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChemicalScan.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class LogSN : global::System.Configuration.ApplicationSettingsBase {
        
        private static LogSN defaultInstance = ((LogSN)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new LogSN())));
        
        public static LogSN Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int log_currSerialNumber {
            get {
                return ((int)(this["log_currSerialNumber"]));
            }
            set {
                this["log_currSerialNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int log_nextSerialNumber {
            get {
                return ((int)(this["log_nextSerialNumber"]));
            }
            set {
                this["log_nextSerialNumber"] = value;
            }
        }
    }
}
