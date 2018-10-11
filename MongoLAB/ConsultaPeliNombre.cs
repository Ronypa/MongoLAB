using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using System.Diagnostics;
using MongoDB.Bson;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MongoLAB
{
    public partial class ConsultaPeliNombre : UserControl
    {
        IMongoDatabase db = (new MongoClient("mongodb://localhost:27017")).GetDatabase("MongoLAB");

        public ConsultaPeliNombre()
        {
            InitializeComponent();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            try {
                var collection = db.GetCollection<modelPelicula>("peliculas");
                var pelicula = nombrePeliBox.Text;

                var resultado = collection.Find(x => x.Nombre == pelicula);
                peliDGV.DataSource = resultado.ToList();
                peliDGV.Columns.Remove("Id");

            }
            catch (Exception excep) { Debug.WriteLine(excep); }
        }
    }
}
