using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using XamarinMVPTemplate.Main.Presenters;
using XamarinMVPTemplate.Main.Models;
using XamarinMVPTemplate.Main.ViewInterfaces;

namespace XamarinMVPTemplate.Droid
{
    [Activity(Label = "xamarinmvptemplate", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity, View.IOnClickListener, IMainView
    {
        MainPresenter _MainPresenter;

        EditText usernameEdtxt, passwordEdtxt;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);


            usernameEdtxt = FindViewById<EditText>(Resource.Id.usernameEdtxt);
            passwordEdtxt = FindViewById<EditText>(Resource.Id.passwordEdtxt);
            Button button = FindViewById<Button>(Resource.Id.loginBtn);


            button.SetOnClickListener(this);
        }

        public void OnClick(View v)
        {
            if (v.Id == Resource.Id.loginBtn)
            {
                _MainPresenter.StartLogin(new LoginCredential { UserName = usernameEdtxt.Text, Password = passwordEdtxt.Text });
            }
        }

        public void ShowErrorMessage(string msg)
        {
            System.Diagnostics.Debug.WriteLine(msg);
        }

        public void OnLoginSuccess()
        {
            //do something
        }
    }
}

