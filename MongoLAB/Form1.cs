using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoLAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            method1();
        }

        async Task method1()
        {

            //Debug.Write(collection.ToBsonDocument);
            /*using (IAsyncCursor<BsonDocument> cursor = await collection.FindAsync(new BsonDocument()))
            {
                while (await cursor.MoveNextAsync())
                {

                    IEnumerable<BsonDocument> batch = cursor.Current;
                    foreach (BsonDocument document in batch)
                    {
                        Debug.WriteLine(document);
                    }
                }
            }*/
            var document1 = new BsonDocument
            {
                { "firstname", BsonValue.Create("Peter")},
                { "lastname", new BsonString("Mbanugo")},
                { "subjects", new BsonArray(new[] {"English", "Mathematics", "Physics"}) },
                { "class", "JSS 3" },
                { "age", 45}
            };
            //await collection.InsertOneAsync(document1);
            //var result = JsonConvert.DeserializeObject<List<JsonResult>>(document1.ToJson());
            //DGV1.DataSource = document1.ToList();
            //var filter = Builders<JsonResult>.Filter.Eq(x => x.Id == 5);
            //var result = collection.Find(x => x.Nombre == "Rapidos y Furiosos");

            //var rr = result.ToList();
            Debug.WriteLine("");
            //DGV1.DataSource = rr;
        }

        private void registroPeliBtn_Click(object sender, EventArgs e)
        {
            registrarPelicula.BringToFront();
        }

        private void registroCompaBtn_Click(object sender, EventArgs e)
        {
            registrarCompania.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            consultaPeliNombre.BringToFront();
        }

        private void consultaFranquiBtn_Click(object sender, EventArgs e)
        {
            consultaPeliFranquicia.BringToFront();
        }

        private void consultarAnnoBtn_Click(object sender, EventArgs e)
        {
            consultaPeliAnno.BringToFront();
        }

        private void consultaCompaBtn_Click(object sender, EventArgs e)
        {
            consultaPeliCompania.BringToFront();
        }
    }
}
