﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Marble.Properties {
	
	
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("ICSharpCode.SettingsEditor.SettingsCodeGeneratorTool", "5.0.0.4755")]
	internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
		
		private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
		
		public static Settings Default {
			get {
				return defaultInstance;
			}
		}
		
		[global::System.Configuration.ApplicationScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("Marble")]
		public string ApplicationName {
			get {
				return ((string)(this["ApplicationName"]));
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("tenanji@gmail.com")]
		public string CalendarAccount {
			get {
				return ((string)(this["CalendarAccount"]));
			}
			set {
				this["CalendarAccount"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("1")]
		public int CalendarDaysInPast {
			get {
				return ((int)(this["CalendarDaysInPast"]));
			}
			set {
				this["CalendarDaysInPast"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("30")]
		public int CalendarDaysInTheFuture {
			get {
				return ((int)(this["CalendarDaysInTheFuture"]));
			}
			set {
				this["CalendarDaysInTheFuture"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("Work")]
		public string CalendarId {
			get {
				return ((string)(this["CalendarId"]));
			}
			set {
				this["CalendarId"] = value;
			}
		}
		
		[global::System.Configuration.ApplicationScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("1032384851384-6gv06rktf1o8cqrplv9ljpa0u29i5iog.apps.googleusercontent.com")]
		public string ClientId {
			get {
				return ((string)(this["ClientId"]));
			}
		}
		
		[global::System.Configuration.ApplicationScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("swyGLjZpRMoe-E73JpHmNEub")]
		public string ClientSecret {
			get {
				return ((string)(this["ClientSecret"]));
			}
		}
		
		[global::System.Configuration.ApplicationScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("Marble.Calendar.Auth.Store")]
		public string DataStoreFolderNameCalendar {
			get {
				return ((string)(this["DataStoreFolderNameCalendar"]));
			}
		}
		
		[global::System.Configuration.ApplicationScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("Marble.Tasks.Auth.Store")]
		public string DataStoreFolderNameTasks {
			get {
				return ((string)(this["DataStoreFolderNameTasks"]));
			}
		}
		
		[global::System.Configuration.ApplicationScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("https://www.googleapis.com/auth/calendar")]
		public string ScopeCalendar {
			get {
				return ((string)(this["ScopeCalendar"]));
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("False")]
		public bool StartWithWindows {
			get {
				return ((bool)(this["StartWithWindows"]));
			}
			set {
				this["StartWithWindows"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("False")]
		public bool SyncEveryHour {
			get {
				return ((bool)(this["SyncEveryHour"]));
			}
			set {
				this["SyncEveryHour"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("10")]
		public int SyncMinutesOffset {
			get {
				return ((int)(this["SyncMinutesOffset"]));
			}
			set {
				this["SyncMinutesOffset"] = value;
			}
		}
	}
}
