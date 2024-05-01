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
    public partial class FormResultGame : Form
    {
        public FormResultGame(int countOfPoints,Complication complication)
        {
            InitializeComponent();
            this.complication = complication;
            this.countOfPoints = countOfPoints;
            labelCountPoints.Text = "Количество очков - " + countOfPoints;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(textBoxNickname.Text == "")
            {
                MessageBox.Show("Введите никнейм");
                return;
            }
            if (DatabaseHandler.IsUserExists(textBoxNickname.Text, complication))
            {
                if (countOfPoints > DatabaseHandler.SelectCountOfPoints(textBoxNickname.Text, complication))
                {
                    DatabaseHandler.UpdateRecords(textBoxNickname.Text, complication, countOfPoints);
                }
            }
            else
            {
                DatabaseHandler.InsertIntoRecords(textBoxNickname.Text, complication, countOfPoints);
            }
            MessageBox.Show("Cохранение результата произошло успешно");
            this.Close();
        }

        private Complication complication;
        private int countOfPoints;
    }
}
