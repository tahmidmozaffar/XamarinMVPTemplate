// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamarinMVPTemplate.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton loginBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField passwordField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField usernameField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (loginBtn != null) {
                loginBtn.Dispose ();
                loginBtn = null;
            }

            if (passwordField != null) {
                passwordField.Dispose ();
                passwordField = null;
            }

            if (usernameField != null) {
                usernameField.Dispose ();
                usernameField = null;
            }
        }
    }
}