﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TechOil.Models;

namespace TechOil.DTO
{
    public class TrabajoDTO
    {
        public string Fecha { get; set; }
        public int IdProyecto { get; set; }
        public int IdServicio { get; set; }
        public int CantidadHoras { get; set; }
        public double ValorHora { get; set; }
        public double Costo { get; set; }
    }
}
