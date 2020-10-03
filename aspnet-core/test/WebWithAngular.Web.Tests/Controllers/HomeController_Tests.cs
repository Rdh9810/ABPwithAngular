using System.Threading.Tasks;
using WebWithAngular.Models.TokenAuth;
using WebWithAngular.Web.Controllers;
using Shouldly;
using Xunit;

namespace WebWithAngular.Web.Tests.Controllers
{
    public class HomeController_Tests: WebWithAngularWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}