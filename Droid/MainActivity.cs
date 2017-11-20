using Android.App;
using Android.Widget;
using Android.OS;
using XamarinMVPTemplate.Droid.Resources;
using Android.Views;
using XamarinMVPTemplate.Main.Presenters;

namespace XamarinMVPTemplate.Droid
{
    [Activity(Label = "xamarinmvptemplate", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity, View.IOnClickListener
    {
        MainPresenter _MainPresenter;

        EditText usernameEdtxt, passwordEdtxt;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
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
                _MainPresenter.StartLogin(usernameEdtxt.Text, passwordEdtxt.Text);
            }
        }
    }
}

