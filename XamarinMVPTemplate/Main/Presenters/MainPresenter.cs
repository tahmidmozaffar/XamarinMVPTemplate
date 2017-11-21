using System;
using XamarinMVPTemplate.Main.Models;
using XamarinMVPTemplate.Main.ViewInterfaces;

namespace XamarinMVPTemplate.Main.Presenters
{
    public class MainPresenter
    {
        IMainView _View;

        public MainPresenter(IMainView view)
        {
            _View = view;
        }


        public void StartLogin(LoginCredential loginCredential)
        {

            if (!loginCredential.IsValidUserName())
            {
                _View.ShowErrorMessage("Invalid username");
                return;
            }

            if (!loginCredential.IsValidPassword())
            {
                _View.ShowErrorMessage("Invalid password");
                return;
            }

            _View.OnLoginSuccess();

        }
    }
}
