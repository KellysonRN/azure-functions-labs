using System.Web.Http;
using Labs.AzureFunctions.App;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Moq;

namespace Labs.AzureFunctions.Tests
{
    public class ExampleTest
    {
        [Theory]
        [InlineData("", typeof(BadRequestResult))]
        [InlineData("QueryParamValue", typeof(OkResult))]
        [InlineData("ThisStringCausesTheFunctionToThrowAnError", typeof(InternalServerErrorResult))]
        public async Task Should_Returns_Correct_StatusCode(string queryParam, Type expectedResult)
        {
            var queryCollection = new QueryCollection(new Dictionary<string, StringValues>{{"q", new StringValues(queryParam)}});

            var request = new Mock<HttpRequest>();
            request.Setup(x => x.Query)
                .Returns(() => queryCollection);

            var logger = Mock.Of<ILogger>();

            var response = await FunctionExample7.Run(request.Object, logger);

            Assert.True(response.GetType() == expectedResult);
        }
    }
}
