using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoLAB
{
    [BsonIgnoreExtraElements]
    public class modelPelicula
    {
        
        public ObjectId Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Director { get; set; }
        public string Franquicia { get; set; }
        public string Pais { get; set; }
        public int Estreno { get; set; }
        public int Duracion { get; set; }
        public string Productora { get; set; }
        public BsonArray Actores { get; set; }
    }
}
