using Main.Controllers;
using Main.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace MainTest
{
    [TestClass]
    public class AccountControllerTest
    {
        [TestMethod]
        public void testRegister()
        {
            AccountController accountController = new AccountController();
            ActionResult register = accountController.Register();
        }

        [TestMethod]
        public void testResetPW()
        {
            AccountController accountController = new AccountController();
            ActionResult resetPassword = accountController.ResetPassword("reset");
        }

        [TestMethod]
        public void testExternalLoginFailure()
        {
            AccountController accountController = new AccountController();
            ActionResult externalLoginFailure = accountController.ExternalLoginFailure();
        }

        [TestMethod]
        public void testForgotPWConfirmation()
        {
            AccountController accountController = new AccountController();
            ActionResult forgetPasswordConfirmation = accountController.ForgotPasswordConfirmation();
        }

        [TestMethod]
        public void testForgotPW()
        {
            AccountController accountController = new AccountController();
            ActionResult forgetPasswordConfirmation = accountController.ForgotPassword();
        }

        [TestMethod]
        public void testLogin()
        {
            AccountController accountController = new AccountController();
            ActionResult login1 = accountController.Login("login");

            LoginViewModel loginViewModel = new LoginViewModel();
            loginViewModel.Email = "ab.padan@gmail.com";
            int hashCode = loginViewModel.GetHashCode();
            loginViewModel.Password = "Password1,";
            loginViewModel.RememberMe = false;

            string weburl = "www.unomaha.edu";
            var login2 = accountController.Login(loginViewModel, weburl);
        }
    }
}
