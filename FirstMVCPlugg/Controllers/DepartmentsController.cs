using FirstMVCPlugg.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCPlugg.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Electronics"});
            list.Add(new Department { Id = 2, Name = "Fashion" });

            return View(list); //envia a lista com os dados para a view, basta colocar a lista em parentese
        }
    }
}
