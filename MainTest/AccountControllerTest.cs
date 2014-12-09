using Main.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace MainTest
{
    [TestClass]
    public class AccountControllerTest
    {
        [TestMethod]
        public void AccountController()
        {
            AccountController accountController = new AccountController();
            ActionResult register = accountController.Register();
            ActionResult resetPassword = accountController.ResetPassword("reset");
            ActionResult externalLoginFailure = accountController.ExternalLoginFailure();
            ActionResult resetPasswordConfirmation = accountController.ExternalLoginFailure();
            ActionResult forgetPasswordConfirmation = accountController.ForgotPasswordConfirmation();
            ActionResult forgetPassword = accountController.ForgotPassword();
            ActionResult login = accountController.Login("login");
        }
    }
}
