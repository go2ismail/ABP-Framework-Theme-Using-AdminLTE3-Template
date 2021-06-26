using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpLteDemo.Pages
{
    public class Index_Tests : AbpLteDemoWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
