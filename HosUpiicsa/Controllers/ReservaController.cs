using Microsoft.AspNetCore.Mvc;
using HosUpiicsa.Models;
using System;
using System.Linq;


namespace HosUpiicsa.Controllers
{
    public class ReservasController : Controller
    {
        public IActionResult Create()
        {
            var habitacion = new Habitacion
            {
                id_habitacion = 101,
                nom_habitacion = "Suite Premier",
                tipoCama = "King Size",
                no_camas = 1,
                capacidad = 2,
                precio = 2500,
                disponibilidad = true
            };

            ViewBag.Habitacion = habitacion;
            ViewBag.FechaEntrada = DateTime.Today.AddDays(1);
            ViewBag.FechaSalida = DateTime.Today.AddDays(3);

            return View();
        }

        [HttpPost]
        public IActionResult Create(Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirmacion", new { id = 1 }); //.....idprueba
            }

            return View(reserva);
        }

        public IActionResult Confirmacion(int id)
        {
            var reserva = new Reserva
            {
                id_reserva = id,
                fecha_entrada = DateTime.Today.AddDays(1),
                fecha_salida = DateTime.Today.AddDays(3),
                hora_entrada = new TimeSpan(15, 0, 0),
                hora_salida = new TimeSpan(12, 0, 0),
                habitacion = new Habitacion
                {
                    nom_habitacion = "Suite Premier",
                    precio = 2500
                }
            };

            return View(reserva);
        }
    }
}