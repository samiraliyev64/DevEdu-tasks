using System.Net;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Figures;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FigureController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<FigureController> _logger;

        public FigureController(ILogger<FigureController> logger)
        {
            _logger = logger;
        }

        List<Figure> figlist = MenuActions.ReadFromFile();

        [HttpGet]
        public IEnumerable<Figure> GetFigures()
        {
            return figlist;
        }


        [HttpGet(("{id}"))]
        public IActionResult GetFigureById(int id)
        {
            var figure = figlist.Find(s => s.Id == id);
            if (figure == null)
            {
                return NotFound();
            }
            return Ok(figure);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var figure = figlist.Find(s => s.Id == id);
            if (figure == null)
            {
                return NotFound();
            }
            figlist.Remove(figure);
            MenuActions.SaveToFile("figure.json",figlist);
            return Ok(figure);
        }


        [HttpPost("CreateCircle/{centerX}/{centerY}/{coordinateX}/{coordinateY}")] //not working
        public IActionResult PostCircle(double centerX,double centerY,double coordinateX,double coordinateY)
        {
            Circle crc1 = new Circle(new List<Point>()
              {
             new Point(centerX,centerY),
             new Point(coordinateX,coordinateY)
              });
            figlist.Add(crc1);
            MenuActions.SaveToFile("figure.json", figlist);
            return Ok();
        }

        [HttpPost("CreateTriangle/{firstCoordinateX}/{firstCoordinateY}/{secondCoordinateX}/{secondCoordinateY}/{thirdCoordinateX}/{thirdCoordinateY}")]
        public IActionResult PostSquare(double firstCoordinateX, double firstCoordinateY, double secondCoordinateX, double secondCoordinateY, double thirdCoordinateX, double thirdCoordinateY)
        {
            Triangle trngl1 = new Triangle(new List<Point>()
            {
            new Point(firstCoordinateX,firstCoordinateY),
            new Point(secondCoordinateX,secondCoordinateY),
            new Point(thirdCoordinateX,thirdCoordinateY)
            });
            figlist.Add(trngl1);
            MenuActions.SaveToFile("figure.json", figlist);
            return Ok();
        }

        [HttpPost("CreateSquare/{firstCoordinateX}/{firstCoordinateY}/{secondCoordinateX}/{secondCoordinateY}/{thirdCoordinateX}/{thirdCoordinateY}/{fourthCoordinateX}/{fourthCoordinateY}")] 
        public IActionResult PostSquare(double firstCoordinateX, double firstCoordinateY, double secondCoordinateX, double secondCoordinateY, double thirdCoordinateX, double thirdCoordinateY, double fourthCoordinateX, double fourthCoordinateY)
        {
            Square sq1 = new Square(new List<Point>()
            {
            new Point(firstCoordinateX,firstCoordinateY),
            new Point(secondCoordinateX,secondCoordinateY),
            new Point(thirdCoordinateX,thirdCoordinateY),
            new Point(fourthCoordinateX,fourthCoordinateY)
            });
            figlist.Add(sq1);
            MenuActions.SaveToFile("figure.json", figlist);
            return Ok();
        }

        [HttpPost("CreateRectangle/{firstCoordinateX}/{firstCoordinateY}/{secondCoordinateX}/{secondCoordinateY}/{thirdCoordinateX}/{thirdCoordinateY}/{fourthCoordinateX}/{fourthCoordinateY}")]
        public IActionResult PostRectangle(double firstCoordinateX, double firstCoordinateY, double secondCoordinateX, double secondCoordinateY, double thirdCoordinateX, double thirdCoordinateY, double fourthCoordinateX, double fourthCoordinateY)
        {
            Rectangle rect1 = new Rectangle(new List<Point>()
            {
            new Point(firstCoordinateX,firstCoordinateY),
            new Point(secondCoordinateX,secondCoordinateY),
            new Point(thirdCoordinateX,thirdCoordinateY),
            new Point(fourthCoordinateX,fourthCoordinateY)
            });
            figlist.Add(rect1);
            MenuActions.SaveToFile("figure.json", figlist);
            return Ok();
        }


        [HttpPatch("RotateFigure/{id}")] 
        public IActionResult RotateFigure(int id,double rotationDegree)
        {
            if (id == null || id == 0)
                return BadRequest();

            var figure = figlist.Find(s => s.Id == id);
            if (figure == null)
                return NotFound();
            else
            {
                figlist[id-1].RotateFigure(rotationDegree);
            }
            MenuActions.SaveToFile("figure.json", figlist);
            return Ok();
        }

        [HttpPatch("ScaleFigure/{id}")]
        public IActionResult ScaleFigure(int id, double scaleMultiplier)
        {
            if (id == null || id == 0)
                return BadRequest();

            var figure = figlist.Find(s => s.Id == id);
            if (figure == null)
                return NotFound();
            else
            {
                figlist[id - 1].ScaleFigure(scaleMultiplier);
            }
            MenuActions.SaveToFile("figure.json", figlist);
            return Ok();
        }

        [HttpPatch("MoveFigure/{id}")]
        public IActionResult MoveFigure(int id, double coordinateX, double coordinateY)
        {
            if (id == null || id == 0)
                return BadRequest();

            var figure = figlist.Find(s => s.Id == id);
            if (figure == null)
                return NotFound();
            else
            {
                figlist[id - 1].MoveFigure(coordinateX, coordinateY);
            }
            MenuActions.SaveToFile("figure.json", figlist);
            return Ok();
        }

    }
}