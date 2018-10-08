using MongoDB.Bson;
using MongoDB.Driver;
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
        static async Task method1()
        {
            IMongoDatabase db = (new MongoClient("mongodb://localhost:27017")).GetDatabase("MongoLAB");

            var collection = db.GetCollection<BsonDocument>("Peliculas");
            //Debug.Write(collection.ToBsonDocument);
            using (IAsyncCursor<BsonDocument> cursor = await collection.FindAsync(new BsonDocument()))
            {
                while (await cursor.MoveNextAsync())
                {
                    IEnumerable<BsonDocument> batch = cursor.Current;
                    foreach (BsonDocument document in batch)
                    {
                        Debug.WriteLine(document);
                    }
                }
            }
            var document1 = new BsonDocument
            {
                { "firstname", BsonValue.Create("Peter")},
                { "lastname", new BsonString("Mbanugo")},
                { "subjects", new BsonArray(new[] {"English", "Mathematics", "Physics"}) },
                { "class", "JSS 3" },
                { "age", 45}
            };
            await collection.InsertOneAsync(document1);
        }

    }
}
