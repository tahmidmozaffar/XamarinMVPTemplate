using System;
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

        public void StartLogin(string username, string password)
        {



        }
    }
}
