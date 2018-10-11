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
using MongoDB.Driver;
using System.Diagnostics;

namespace MongoLAB
{
    public partial class RegistrarCompania : UserControl
    {
        IMongoDatabase db = (new MongoClient("mongodb://localhost:27017")).GetDatabase("MongoLAB");

        public RegistrarCompania()
        {
            InitializeComponent();
        }

        private void registrarCompa_Click(object sender, EventArgs e)
        {
            try
            {
                var collection = db.GetCollection<BsonDocument>("compania");

                var infoCompa = new BsonDocument
            {
                { "Nombre", nombreBox.Text},
                { "Fundacion", int.Parse(fundacionBox.Text)},
                { "Web", webBox.Text }
            };
                collection.InsertOne(infoCompa);

                nombreBox.Clear();
                fundacionBox.Clear();
                webBox.Clear();

                Debug.WriteLine(infoCompa);
            }
            catch (Exception excep) { Debug.WriteLine(excep); }
        }
    }
}
