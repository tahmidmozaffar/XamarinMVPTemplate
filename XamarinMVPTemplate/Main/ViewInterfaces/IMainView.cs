using System;
namespace XamarinMVPTemplate.Main.ViewInterfaces
{
	public interface IMainView
	{
		void ShowErrorMessage(string v);
        void OnLoginSuccess();
    }
}
