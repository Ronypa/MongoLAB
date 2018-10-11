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

namespace MongoLAB
{
    public partial class ConsultaPeliCompania : UserControl
    {
        IMongoDatabase db = (new MongoClient("mongodb://localhost:27017")).GetDatabase("MongoLAB");

        public ConsultaPeliCompania()
        {
            InitializeComponent();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var collection = db.GetCollection<modelPelicula>("peliculas");
                var compania = nombreCompaBox.Text;

                var resultado = collection.Find(x => x.Productora == compania);
                peliDGV.DataSource = resultado.ToList();
                peliDGV.Columns.Remove("Id");
                peliDGV.Columns.Remove("Director");
                peliDGV.Columns.Remove("Productora");
                peliDGV.Columns.Remove("Actores");
                peliDGV.Columns.Remove("Pais");
                peliDGV.Columns.Remove("Franquicia");
                peliDGV.Columns.Remove("Duracion");

            }
            catch (Exception excep) { Debug.WriteLine(excep); }
        }
    }
}
