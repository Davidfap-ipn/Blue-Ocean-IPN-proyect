using Microsoft.AspNetCore.Mvc;
using HosUpiicsa.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace HosUpiicsa.Controllers
{
    public class HomeController : Controller
    {
        private static int _visitas = 0;
        private readonly List<Hotel> _hotelesEjemplo;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
            _hotelesEjemplo = new List<Hotel>
            {
                new Hotel {
                    id_hotel = 1,
                    tipo_hotel = "Todo Incluido",
                    calle_hotel = "Blvd. Kukulcan Km 12.5",
                    alc_hotel = "Zona Hotelera",
                    cp_hotel = 77500,
                    col_hotel = "Cancún",
                    tel_hotel = 998127,
                    disponibilidad = true
                },
                new Hotel {
                    id_hotel = 2,
                    tipo_hotel = "Frente al mar",
                    calle_hotel = "Av. Costera Miguel Alemán 999",
                    alc_hotel = "Costera",
                    cp_hotel = 39690,
                    col_hotel = "Acapulco",
                    tel_hotel = 744567,
                    disponibilidad = true
                },
                new Hotel {
                    id_hotel = 3,
                    tipo_hotel = "Boutique",
                    calle_hotel = "Púlpito 102",
                    alc_hotel = "Col. Emiliano Zapata",
                    cp_hotel = 48380,
                    col_hotel = "Puerto Vallarta",
                    tel_hotel = 322567,
                    disponibilidad = true
                }
            };
        }

        public IActionResult Index()
        {
            try
            {
                _visitas++;
                HttpContext.Items["Visitas"] = _visitas;
                _logger.LogInformation($"Visita número {_visitas} al Home/Index");

               
                var hotelesDisponibles = _hotelesEjemplo
                    .Where(h => h.disponibilidad)
                    .OrderBy(h => h.id_hotel)
                    .ToList();

                if (!hotelesDisponibles.Any())
                {
                    _logger.LogWarning("No hay hoteles disponibles para mostrar");
                    return View(new List<Hotel>());
                }

                return View(hotelesDisponibles);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en HomeController.Index");
                return View("Error", new ErrorViewModel { 
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                });
            }
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}