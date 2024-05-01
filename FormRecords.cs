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
    public partial class FormRecords : Form
    {
        public FormRecords()
        {
            InitializeComponent();

            DisplayNormalSkill();
            DisplayHighSkill();
            DisplayVeryHighSkill();
        }

        private void DisplayNormalSkill()
        {
            List<User> NormalSkill = DatabaseHandler.SelectUsers(Complication.Easy);
            for (int i = 0; i < NormalSkill.Count; i++)
            {
                dataGridViewNormalSkill.Rows.Add(new object[] {i+1, NormalSkill[i].Nickname, NormalSkill[i].CountOfPoints });
            }
        }

        private void DisplayHighSkill()
        {
            List<User> HighSkill = DatabaseHandler.SelectUsers(Complication.Middle);
            for (int i = 0; i < HighSkill.Count; i++)
            {
                dataGridViewHighSkill.Rows.Add(new object[] {i+1, HighSkill[i].Nickname, HighSkill[i].CountOfPoints });
            }
        }

        private void DisplayVeryHighSkill()
        {
            List<User> VeryHighSkill = DatabaseHandler.SelectUsers(Complication.Difficult);
            for (int i = 0; i < VeryHighSkill.Count; i++)
            {
                dataGridViewVeryHighSkill.Rows.Add(new object[] {i+1, VeryHighSkill[i].Nickname, VeryHighSkill[i].CountOfPoints });
            }
        }

        private void FormRecords_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
