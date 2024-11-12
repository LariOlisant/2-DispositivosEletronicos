using _2_DispositivosEletronicos.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2_DispositivosEletronicos.Controllers
{
    public class DispositivoController : Controller
    {

        public IActionResult Index()
        {
            List<DispositivoEletronico> dispositivos = new List<DispositivoEletronico>
            {
                new Computador { Marca = "Dell", Modelo = "Inspirion", AnoDeFabricacao = 2021, Ehlaptop = true, MemoriaRam = 16, SistemaOperacional = "Windows 11" },
                new Computador { Marca = "Dell", Modelo = "Inspirion", AnoDeFabricacao = 2021, Ehlaptop = true, MemoriaRam = 16, SistemaOperacional = "Windows 11" },
                new Smartphone {Marca = "Apple", Modelo = "Iphone 13", AnoDeFabricacao = 2022, Tem5G = true }

            };
            return View(dispositivos);
        }
    }
}
