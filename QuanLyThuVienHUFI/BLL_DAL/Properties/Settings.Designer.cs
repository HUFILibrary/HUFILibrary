﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLL_DAL.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-RDLUFLH4\\SQLEXPRESS;Initial Catalog=QuanLyThuVienCNTP;Integrat" +
            "ed Security=True")]
        public string QuanLyThuVienCNTPConnectionString {
            get {
                return ((string)(this["QuanLyThuVienCNTPConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-F6GMAH7\\SQLEXPRESS;Initial Catalog=QuanLyThuVienCNTP;User ID=" +
            "sa;Password=024453854")]
        public string QuanLyThuVienCNTPConnectionString1 {
            get {
                return ((string)(this["QuanLyThuVienCNTPConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=QuanLyThuVienCNTP;Integrated S" +
            "ecurity=True")]
        public string QuanLyThuVienCNTPConnectionString2 {
            get {
                return ((string)(this["QuanLyThuVienCNTPConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-F6GMAH7\\SQLEXPRESS;Initial Catalog=QuanLyThuVienCNTP2;Integra" +
            "ted Security=True")]
        public string QuanLyThuVienCNTP2ConnectionString {
            get {
                return ((string)(this["QuanLyThuVienCNTP2ConnectionString"]));
            }
        }
    }
}
