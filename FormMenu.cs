using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dota3InARow
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void pictureBoxStartGame_Click(object sender, EventArgs e)
        {
            Complication complication = Complication.Difficult;
            if (radioButtonNormal.Checked)
            {
                complication = Complication.Easy;
            }
            if (radioButtonHigh.Checked)
            {
                complication = Complication.Middle;
            }

            FormGame formGame = new FormGame(complication);
            formGame.ShowDialog();
        }

        private void pictureBoxSkullBreaker_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxRecords_Click(object sender, EventArgs e)
        {
            FormRecords formRecords = new FormRecords();
            formRecords.ShowDialog();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите выйти из программы?","Выход ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
