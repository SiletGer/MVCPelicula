using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCPelicula.Controllers
{
    public class HelloWorldController : Controller
    {
        private static Dictionary<string, int> nameCount = new Dictionary<string, int>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string nombre, string apellido,  int NumVeces = 1)
        {
            string Nombrecompleto = $"{nombre} {apellido}";

            if (nameCount.ContainsKey(Nombrecompleto))
            {
                nameCount[Nombrecompleto]++;
            }
            else
            {
                nameCount[Nombrecompleto] = 1;
            }


            ViewData["nombre"] = "Hola " + Nombrecompleto;
            ViewData["numVeces"] = NumVeces;
            ViewData["count"] = nameCount[Nombrecompleto];

            return View();
        }
    }
}
