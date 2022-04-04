using ApiMongoDB.Data.Collections;
using ApiMongoDB.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace ApiMongoDB.Controllers
{
    public class InfectadoController : ControllerBase
    {
         Data.MongoDB _mongoDB;
         IMongoCollection<Infectado> _infectadosCollection;

         public InfectadoController(Data.MongoDB mongoDB)
         {
            _mongoDB = mongoDB;
            _infectadosCollection = mongoDB.DB.GetCollection<Infectado>(typeof(Infectado).Name.ToLower());
         }
         
        [HttpPost]
        public ActionResult SaveInfectado([FromBody] InfectadoDto dto)
        {
            var infectado = new Infectado(dto.DataNascimento, dto.Genero, dto.Latitude, dto.Longitude);
            _infectadosCollection.InsertOne(infectado);
            return StatusCode(201, "Infectado adicionado com sucesso!");
        }

        [HttpGet]
        public ActionResult GetInfectados()
        {
            var infectados = _infectadosCollection.Find(Builders<Infectado>.Filter.Empty).ToList();
            return Ok(infectados);
        }          
    }
}