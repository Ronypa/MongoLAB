using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using System.Diagnostics;
using MongoDB.Driver;

namespace MongoLAB
{
    public partial class RegistrarPelicula : UserControl
    {
        IMongoDatabase db = (new MongoClient("mongodb://localhost:27017")).GetDatabase("MongoLAB");

        public RegistrarPelicula()
        {
            InitializeComponent();
        }

        private void registrarPeli_Click(object sender, EventArgs e)
        {
            try
            {
                var collection = db.GetCollection<BsonDocument>("peliculas");

                var actors = actoresBox.Text.Split(',').Select(x => x.Trim())
                    .Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                BsonArray actores = new BsonArray(actors);

                var infoPeli = new BsonDocument
            {
                { "Nombre", nombreBox.Text},
                { "Genero", generoBox.Text},
                { "Director", directorBox.Text },
                { "Franquicia", franquiBox.Text },
                { "Pais", paisBox.Text},
                { "Estreno", estrenoBox.Text},
                { "Duracion", duracionBox.Text},
                { "Productora", productoraBox.Text},
                { "Actores", actores}
            };
                collection.InsertOne(infoPeli);

                nombreBox.Clear();
                generoBox.Clear();
                directorBox.Clear();
                franquiBox.Clear();
                paisBox.Clear();
                estrenoBox.Clear();
                duracionBox.Clear();
                productoraBox.Clear();
                actoresBox.Clear();

                Debug.WriteLine(infoPeli);
            }
            catch (Exception excep) { Debug.WriteLine(excep); }
        }
    }
}
