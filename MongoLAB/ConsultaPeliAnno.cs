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
    public partial class ConsultaPeliAnno : UserControl
    {
        IMongoDatabase db = (new MongoClient("mongodb://localhost:27017")).GetDatabase("MongoLAB");

        public ConsultaPeliAnno()
        {
            InitializeComponent();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if(inicioBox.Text!="" && finalBox.Text!="" && (int.Parse(inicioBox.Text)<= int.Parse(finalBox.Text)))
            {
                try
                {
                    var collection = db.GetCollection<modelPelicula>("peliculas");
                    var inicio = int.Parse(inicioBox.Text);
                    var final = int.Parse(finalBox.Text);
                    var resultado = collection.Find(x => (x.Estreno >= inicio) && (x.Estreno <= final));
                    peliDGV.DataSource = resultado.ToList();
                    peliDGV.Columns.Remove("Id");

                }
                catch (Exception excep) { Debug.WriteLine(excep); }
            }
            else
            {
                MessageBox.Show("Rango de años inválido");
            }
        }
    }
}
