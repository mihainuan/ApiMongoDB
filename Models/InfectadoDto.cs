using System;

namespace ApiMongoDB.Models
{
    public class InfectadoDto
    {
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}