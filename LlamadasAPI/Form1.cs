using ChuckNorris;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LlamadasAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetJoke_Click(object sender, EventArgs e)
        {
            var response = API.Random(exclude: new string[] { "explicit" });
            var joke = response.Result;

            lblJoke.Text = joke.Text;
        }
    }
}
