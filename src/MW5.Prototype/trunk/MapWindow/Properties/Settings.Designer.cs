﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MapWindow.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point MainForm_location {
            get {
                return ((global::System.Drawing.Point)(this["MainForm_location"]));
            }
            set {
                this["MainForm_location"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("WindowsDefaultLocation")]
        public global::System.Windows.Forms.FormStartPosition MainForm_startLocation {
            get {
                return ((global::System.Windows.Forms.FormStartPosition)(this["MainForm_startLocation"]));
            }
            set {
                this["MainForm_startLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("853")]
        public int MainForm_SizeWidth {
            get {
                return ((int)(this["MainForm_SizeWidth"]));
            }
            set {
                this["MainForm_SizeWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("603")]
        public int MainForm_SizeHeight {
            get {
                return ((int)(this["MainForm_SizeHeight"]));
            }
            set {
                this["MainForm_SizeHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7")]
        public int CurrentZoomlevel {
            get {
                return ((int)(this["CurrentZoomlevel"]));
            }
            set {
                this["CurrentZoomlevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.Forms.FormWindowState MainForm_windowState {
            get {
                return ((global::System.Windows.Forms.FormWindowState)(this["MainForm_windowState"]));
            }
            set {
                this["MainForm_windowState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("47.181324")]
        public float CurrentLatitude {
            get {
                return ((float)(this["CurrentLatitude"]));
            }
            set {
                this["CurrentLatitude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("19.8511734")]
        public float CurrentLongitude {
            get {
                return ((float)(this["CurrentLongitude"]));
            }
            set {
                this["CurrentLongitude"] = value;
            }
        }
    }
}