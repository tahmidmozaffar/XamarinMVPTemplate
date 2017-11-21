using NUnit.Framework;
using System;
using XamarinMVPTemplate.Main.Presenters;
using Moq;
using XamarinMVPTemplate.Main.ViewInterfaces;
using XamarinMVPTemplate.Main.Models;

namespace XamarinMVPTemplate.UnitTests
{
    [TestFixture()]
    public class MainPresenterTests
    {

        MainPresenter _MainPresenter;
        Mock<IMainView> mockMainView;

        [SetUp]
        public void Setup()
        {
            mockMainView = new Mock<IMainView>(MockBehavior.Strict);
            _MainPresenter = new MainPresenter(mockMainView.Object);
        }

        [Test()]
        public void StartLogin_withInvalidUsername_willShowErrorMessage()
        {

            mockMainView.Setup(view => view.ShowErrorMessage("Invalid username")).Verifiable();
            mockMainView.Setup(view => view.OnLoginSuccess()).Verifiable();

            var loginCredential = new LoginCredential { UserName = "*aaa", Password = "12123" };
            _MainPresenter.StartLogin(loginCredential);

            mockMainView.Verify(view => view.ShowErrorMessage("Invalid username"), Times.Once());
            mockMainView.Verify(view => view.OnLoginSuccess(), Times.Never());


        }

        [Test()]
        public void StartLogin_withInvalidPassword_willShowErrorMessage()
        {
            mockMainView.Setup(view => view.ShowErrorMessage("Invalid password")).Verifiable();
            mockMainView.Setup(view => view.OnLoginSuccess()).Verifiable();

            var loginCredential = new LoginCredential { UserName = "aaa", Password = "12" };
            _MainPresenter.StartLogin(loginCredential);

            mockMainView.Verify(view => view.ShowErrorMessage("Invalid password"), Times.Once());
            mockMainView.Verify(view => view.OnLoginSuccess(), Times.Never());

        }

        [Test()]
        public void StartLogin_withValidCredential_willAllowLogin()
        {

            mockMainView.Setup(view => view.ShowErrorMessage(It.IsAny<string>())).Verifiable();
            mockMainView.Setup(view => view.OnLoginSuccess()).Verifiable();

            var loginCredential = new LoginCredential { UserName = "aaa", Password = "12121" };
            _MainPresenter.StartLogin(loginCredential);

            mockMainView.Verify(view => view.ShowErrorMessage(It.IsAny<string>()), Times.Never());
            mockMainView.Verify(view => view.OnLoginSuccess(), Times.Once());


        }
    }
}
