using System.Threading.Tasks;
using HolidaysCalculator.API.Clients;
using HolidaysCalculator.API.Controllers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HolidaysCalculator.UnitTest
{
    [TestClass]
    public class HolidaysCalculatorControllerTest
    {
        private readonly HolidayCalculatorController _HolidayCalculatorController;
        private readonly Mock<IMediator> _mediator;

        public HolidaysCalculatorControllerTest()
        {
            _mediator = new Mock<IMediator>();
            _HolidayCalculatorController = new HolidayCalculatorController(_mediator.Object);
        }

        [TestMethod]
        public async Task HolidayOptimizerController_GetCountryWithMostHolidaysByYear_Should_Return_Ok_Result()
        {
            var actionResult = await _HolidayCalculatorController.GetCountryWithMostHolidaysByYear(2020);
            Assert.AreEqual(StatusCodes.Status200OK, ((OkObjectResult)actionResult).StatusCode);
        }

        [TestMethod]
        public async Task HolidayOptimizerController_GetMonthWithMostHolidaysByYear_Should_Return_Ok_Result()
        {
            var actionResult = await _HolidayCalculatorController.GetMonthWithMostHolidaysByYear(2020);
            Assert.AreEqual(StatusCodes.Status200OK, ((OkObjectResult)actionResult).StatusCode);
        }

        [TestMethod]
        public async Task HolidayOptimizerController_GetCountryWithMostUniqueHolidaysByYear_Should_Return_Ok_Result()
        {
            var actionResult = await _HolidayCalculatorController.GetCountryWithMostUniqueHolidaysByYear(2020);
            Assert.AreEqual(StatusCodes.Status200OK, ((OkObjectResult)actionResult).StatusCode);
        }
    }
}
