using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MyFirstAzureWebApp.Pages.Tests
{
    [TestClass()]
    public class IndexModelTests
    {
        private readonly IndexModel _indexModel;

        public IndexModelTests()
        {
            _indexModel = new IndexModel(null);
        }

        [TestMethod()]
        public void AuthenticateTest_with_correct_credentials_results_successful()
        {

            string userName = "test";
            string password = "passcode";

            var result = _indexModel.Authenticate(userName, password);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Equals($"Login succeeded for user {userName}"));

            //Assert.Fail();
        }

        [TestMethod()]
        public void AuthenticateTest_when_I_Provide_wrong_credentials_it_should_fail_or_return_null()
        {
            //Assert.Fail();
            string userName = "test";
            string password = "passcode_abc!!";

            var result = _indexModel.Authenticate(userName, password);

            Assert.IsNull(result);

        }

        [TestMethod]
        public void Add_ByAddingTwoNumbers_returns_sum_of_numbers()
        {
            //Arrange
            var a = 4;
            var b = 5;
            //Act
            var result = _indexModel.Add(a, b);
            //Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Add_ByAddingTwoNumbers_returns_sum_of_numbers_smart()
        {
            Assert.AreEqual(13, _indexModel.Add(6, 7));
        }
    }
}