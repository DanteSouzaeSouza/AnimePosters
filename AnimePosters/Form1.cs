using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePosters
{
    public partial class FrmAnimes : Form
    {
        public FrmAnimes()
        {
            InitializeComponent();
        }

        private void cboAnimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboAnimes.SelectedIndex;

            // Montar a tela com a imagem de acordo com o Index
            switch (index)
            {
                
            }

        }

        private void FrmAnimes_Load(object sender, EventArgs e)
        {
            cboAnimes.Items.Add("Sakura Card Captors");
            cboAnimes.Items.Add("Cowboy Bebop 1");
            cboAnimes.Items.Add("Cowboy Bebop 2");
            cboAnimes.Items.Add("Dragon Ball Z");
            cboAnimes.Items.Add("Yu Yu Hakusho");
            cboAnimes.Items.Add("Nadia");
            cboAnimes.Items.Add("Gangsta");
            cboAnimes.Items.Add("Ranma 1/2");
            cboAnimes.Items.Add("Eden of the east");
            cboAnimes.Items.Add("Samurai Champloo");
            cboAnimes.Items.Add("Galaxy Express 999");
            cboAnimes.Items.Add("Tsubasa Chronicle");
        }
    }
}
