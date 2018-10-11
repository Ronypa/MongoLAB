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
    public partial class ConsultaPeliFranquicia : UserControl
    {
        IMongoDatabase db = (new MongoClient("mongodb://localhost:27017")).GetDatabase("MongoLAB");

        public ConsultaPeliFranquicia()
        {
            InitializeComponent();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var collection = db.GetCollection<modelPelicula>("peliculas");
                var franquicia = nombreFranquiBox.Text;

                var resultado = collection.Find(x => x.Franquicia == franquicia);
                peliDGV.DataSource = resultado.ToList();
                peliDGV.Columns.Remove("Id");

            }
            catch (Exception excep) { Debug.WriteLine(excep); }
        }
    }
}
