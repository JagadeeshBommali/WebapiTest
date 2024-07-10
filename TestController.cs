using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiCodeTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IShapeFactory, ShapeFactory>()
                .AddTransient<IShapeCalculationService, ShapeCalculationService>()
                .AddScoped<Sphere>()
                .AddScoped<IShape, Sphere>(s => s.GetService<Sphere>())
                .AddScoped<Cube>()
                .AddScoped<IShape, Cube>(s => s.GetService<Cube>())
                .BuildServiceProvider();

            //do the actual work here
            var service = serviceProvider.GetService<IShapeCalculationService>();
            service.CalculateShapeMeasurements();
            return new string[] { "value1", "value2" };
        }
    }
}
