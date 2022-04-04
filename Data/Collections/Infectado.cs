using System;
using MongoDB.Driver.GeoJsonObjectModel;

namespace ApiMongoDB.Data.Collections
{
    //Classe como representação da COLLECTION no banco de dados (MongoDB)
    public class Infectado
    {
        public Infectado(DateTime dataNascimento, string genero, double latitude, double longitude)
        {
            this.DataNascimento = dataNascimento;
            this.Genero = genero;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude,latitude);
        }
        public DateTime DataNascimento { get; set; }

        public string Genero { get; set; }

        public GeoJson2DGeographicCoordinates Localizacao { get; set; }
    }
}