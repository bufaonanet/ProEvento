using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private IEnumerable<Evento> _eventos = new Evento[] {
            new Evento{
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1° Lote",
                QtdPessoas = 250,
                EventoData = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "Foto1.png"
            },
            new Evento{
                EventoId = 2,
                Tema = "Angular e suas Novidades",
                Local = "São Paulo",
                Lote = "2° Lote",
                QtdPessoas = 100,
                EventoData = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "Foto2.png"
            }

        };

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventos;
        }

        [HttpGet("{id:int}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _eventos.Where(p => p.EventoId == id);
        }
    }
}
