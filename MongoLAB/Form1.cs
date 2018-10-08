using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoLAB
{
    public partial class Form1 : Form
    {
        MongoClient client = new MongoClient("mongodb://localhost:27017");
        public Form1()
        {
            InitializeComponent();
        }

    }
}
