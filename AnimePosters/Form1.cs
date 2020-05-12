using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimePosters.Properties;

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
                case 0:
                    picPoster.Image = Resources.img_anime_01;
                    break;
                case 1:
                    picPoster.Image = Resources.img_anime_02;
                    break;
                case 2:
                    picPoster.Image = Resources.img_anime_03;
                    break;
                case 3:
                    picPoster.Image = Resources.img_anime_04;
                    break;
                case 4:
                    picPoster.Image = Resources.img_anime_05;
                    break;
                case 5:
                    picPoster.Image = Resources.img_anime_06;
                    break;
                case 6:
                    picPoster.Image = Resources.img_anime_07;
                    break;
                case 7:
                    picPoster.Image = Resources.img_anime_08;
                    break;
                case 8:
                    picPoster.Image = Resources.img_anime_09;
                    break;
                case 9:
                    picPoster.Image = Resources.img_anime_10;
                    break;
                case 10:
                    picPoster.Image = Resources.img_anime_11;
                    break;
                case 11:
                    picPoster.Image = Resources.img_anime_12;
                    break;
                default:
                    MessageBox.Show("Selecione um valor válido");
                    break;

            }

        }

        private void FrmAnimes_Load(object sender, EventArgs e)
        {
            cboAnimes.Items.Add("Sakura Card Captors");
            cboAnimes.Items.Add("Tsubasa Chronicle");
            cboAnimes.Items.Add("Yu Yu Hakusho");
            cboAnimes.Items.Add("Cowboy Bebop 1");
            cboAnimes.Items.Add("Cowboy Bebop 2");
            cboAnimes.Items.Add("Ranma 1/2");
            cboAnimes.Items.Add("Samurai Champloo");
            cboAnimes.Items.Add("Draghon Ball Z");
            cboAnimes.Items.Add("Nadia");
            cboAnimes.Items.Add("Eden of the East");
            cboAnimes.Items.Add("Galaxy Express 999");
            cboAnimes.Items.Add("Gangsta");
        }
    }
}
