using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dota3InARow
{
    public static class Loader
    {
        public static void Load(FormGame formGame)
        {
            LoadVenga(formGame);
            LoadTechis(formGame);
            LoadEncha(formGame);
            LoadVrka(formGame);
            LoadZevs(formGame);
            LoadVoid(formGame);
            LoadSheiker(formGame);
        }

        private static void LoadVenga(FormGame formGame)
        {
            if (formGame.SkillSelection[0])
            {
                formGame.pictureBoxSkillVenga.Load("Skill1.1.1.png");
            }
            else
            {
                if (formGame.Matrix.CountVenga >= ConstantSkillsCost.SkillVenga)
                {
                    formGame.pictureBoxSkillVenga.Load("Skill1.1.png");
                }
                else
                {
                    formGame.pictureBoxSkillVenga.Load("Skill1.png");
                }
            }
        }

        private static void LoadTechis(FormGame formMain)
        {
            if (formMain.SkillSelection[1])
            {
                formMain.pictureBoxSkillTechis.Load("Skill1.1.2.png");
            }
            else
            {
                if (formMain.Matrix.CountTechis >= ConstantSkillsCost.SkillTechis)
                {
                    formMain.pictureBoxSkillTechis.Load("Skill1.2.png");
                }
                else
                {
                    formMain.pictureBoxSkillTechis.Load("Skill2.png");
                }
            }
        }

        private static void LoadEncha(FormGame formMain)
        {
            if(formMain.Matrix.CountEncha >= ConstantSkillsCost.SkillEncha)
            {
                formMain.pictureBoxSkillEncha.Load("Skill1.3.png");
            }
            else
            {
                formMain.pictureBoxSkillEncha.Load("Skill3.png");
            }
        }

        private static void LoadVrka(FormGame formMain)
        {
            if (formMain.SkillSelection[2])
            {
                formMain.pictureBoxSkillVrka.Load("Skill1.1.4.png");
            }
            else
            {
                if (formMain.Matrix.CountVrka >= ConstantSkillsCost.SkillVrka)
                {
                    formMain.pictureBoxSkillVrka.Load("Skill1.4.png");
                }
                else
                {
                    formMain.pictureBoxSkillVrka.Load("Skill4.png");
                }
            }
        }

        private static void LoadZevs(FormGame formMain)
        {
            if (formMain.SkillSelection[3])
            {
                formMain.pictureBoxSkillZevs.Load("Skill1.1.5.png");
            }
            else
            {
                if (formMain.Matrix.CountZevs >= ConstantSkillsCost.SkillZevs)
                {
                    formMain.pictureBoxSkillZevs.Load("Skill1.5.png");
                }
                else
                {
                    formMain.pictureBoxSkillZevs.Load("Skill5.png");
                }
            }
        }

        private static void LoadVoid(FormGame formMain)
        {
            if (formMain.Matrix.CountVoid >= ConstantSkillsCost.SkillVoid)
            {
                formMain.pictureBoxSkillVoid.Load("Skill1.6.jpg");
            }
            else
            {
                formMain.pictureBoxSkillVoid.Load("Skill6.jpg");
            }
        }

        private static void LoadSheiker(FormGame formMain)
        {
            if (formMain.Matrix.CountSheiker >= ConstantSkillsCost.SkillSheiker)
            {
                formMain.pictureBoxSkillSheiker.Load("Skill1.7.png");
            }
            else
            {
                formMain.pictureBoxSkillSheiker.Load("Skill7.png");
            }
        }

        public static void LoadLabelsTo(FormGame formMain)
        {
            formMain.labelVengaTo.Text = "из "+ConstantSkillsCost.SkillVenga.ToString();
            formMain.labelTechisTo.Text = "из " + ConstantSkillsCost.SkillTechis.ToString();
            formMain.labelEnchaTo.Text = "из " + ConstantSkillsCost.SkillEncha.ToString();
            formMain.labelVrkaTo.Text = "из " + ConstantSkillsCost.SkillVrka.ToString();
            formMain.labelZevsTo.Text = "из " + ConstantSkillsCost.SkillZevs.ToString();
            formMain.labelVoidTo.Text = "из " + ConstantSkillsCost.SkillVoid.ToString();
            formMain.labelSheikerTo.Text = "из " + ConstantSkillsCost.SkillSheiker.ToString();
        }

        public static void SetToolTips(FormGame formMain)
        {
            ToolTip toolTipVenga = new ToolTip();
            toolTipVenga.SetToolTip(formMain.pictureBoxSkillVenga, "Выберите скил венги, затем выберите 2 любых героев, чтобы поменять их местами");

            ToolTip toolTipEncha = new ToolTip();
            toolTipEncha.SetToolTip(formMain.pictureBoxSkillEncha, "Просто нажмите на скилл энчи, чтобы замедлить время в 2 раза на 10 секунд");

            ToolTip toolTipVrka = new ToolTip();
            toolTipVrka.SetToolTip(formMain.pictureBoxSkillVrka, "Выберите скилл vrkи, а затем клетку, уничтожиться линия и столбец, на которой находится эта клетка");

            ToolTip toolTipSkillVoid = new ToolTip();
            toolTipSkillVoid.SetToolTip(formMain.pictureBoxSkillVoid, "Выберите скилл войда, чтобы остановить время на 10 секунд");

            ToolTip toolTipZevs = new ToolTip();
            toolTipZevs.SetToolTip(formMain.pictureBoxSkillZevs, "Выберите скилл зевса, затем любого героя, чтобы уничтожить всех таких героев");

            ToolTip toolTipTechis = new ToolTip();
            toolTipTechis.SetToolTip(formMain.pictureBoxSkillTechis, "Выберите скилл течиса, затем выберите клетку, будут взорваны все клетки в радиусе 1 от неё");

            ToolTip toolTipScheiker = new ToolTip();
            toolTipScheiker.SetToolTip(formMain.pictureBoxSkillSheiker, "Выберите скилл шейкера, чтобы уничтожить все клетки на поле");
        }
        
        public static void HideLabelsAndPicrureBoxes(FormGame formGame, Complication complication)
        {
            switch (complication)
            {
                case Complication.Easy:
                    HideZevsAndVrka(formGame);
                    HideSheikerAndVoid(formGame);
                    break;
                case Complication.Middle:
                    HideSheikerAndVoid(formGame);
                    break;
                default:
                    break;
            }
        }

        private static void HideSheikerAndVoid(FormGame formGame)
        {
            formGame.labelSheikerFrom.Visible = false;
            formGame.labelSheikerTo.Visible = false;
            formGame.pictureBoxSkillSheiker.Visible = false;
            formGame.pictureBoxSkillVoid.Visible = false;
            formGame.labelVoidFrom.Visible = false;
            formGame.labelVoidTo.Visible = false;
        }

        private static void HideZevsAndVrka(FormGame formGame)
        {
            formGame.labelVrkaFrom.Visible = false;
            formGame.labelVrkaTo.Visible = false;
            formGame.pictureBoxSkillVrka.Visible = false;
            formGame.labelZevsFrom.Visible = false;
            formGame.labelZevsTo.Visible = false;
            formGame.pictureBoxSkillZevs.Visible = false;
        }
    }
    }

