using System;
using Microsoft.AspNetCore.Mvc;
using OpenCvSharp;

namespace Example.WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        [Route("example.webp")]
        public IActionResult GetExampleImage()
        {
            using var mat = new Mat(new Size(256, 256), MatType.CV_8UC3, Scalar.Black);
            Cv2.Rectangle(mat, new Point(64, 64), new Point(192, 192), Scalar.Red, 2);
            return File(mat.ToBytes(".webp"), "image/webp");
        }
    }
}