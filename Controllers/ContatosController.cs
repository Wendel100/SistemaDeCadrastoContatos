using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using SistemaDeCadastroContatos.Models;
namespace SistemaDeCadastroContatos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Apagar()
        {
            return View();
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
