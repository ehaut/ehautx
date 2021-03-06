// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;
using EhautX.Model;

namespace EhautX.View
{
    public partial class GeneralPrefsController : NSViewController
    {
        public static AppDelegate App => (AppDelegate)NSApplication.SharedApplication.Delegate;

        [Export("Preferences")]
        public AppPreferences Preferences => App.Preferences;

        public GeneralPrefsController(IntPtr handle) : base(handle)
        {
        }
    }
}
