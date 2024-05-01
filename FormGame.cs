using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dota3InARow
{
    public partial class FormGame : Form
    {
        public FormGame(Complication complication)
        {
            InitializeComponent();
            int countRows = 0;
            this.complication = complication;
            switch (complication)
            {
                case Complication.Easy:
                    countRows = 6;
                    timeToEnd = 150;
                    break;
                case Complication.Middle:
                    countRows = 8;
                    timeToEnd = 135;
                    break;
                case Complication.Difficult:
                    countRows = 10;
                    timeToEnd = 120;
                    break;
            }

            LoadMusic(9,3200);

            labelTimeToEnd.Text = "Осталось " + Math.Round(timeToEnd, 2) + " секунд";
            Loader.HideLabelsAndPicrureBoxes(this, complication);
            
            Matrix = new Matrix(countRows);
            pictureBoxes = new PictureBox[countRows, countRows];
            SelectionMatrix = new int[countRows, countRows];
            CreatePictureBoxes();
            Loader.SetToolTips(this);
            Loader.LoadLabelsTo(this);
        }

        public PictureBox[,] pictureBoxes;
        public int[,] SelectionMatrix;
        public bool[] SkillSelection = new bool[4];
        public Matrix Matrix { get => matrix; set => matrix = value; }

        public void AllPictureBoxesClick(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            Point pointClick = (Point)pictureBox.Tag;
            Point lastClick = GetLastClick(pointClick);

            if (SkillSelection[0])
            {
                VengaSkill(pointClick);
                return;
            }
            if (SkillSelection[1])
            {
                TechisSkill(pointClick);
                return;
            }
            if (SkillSelection[2])
            {
                SkillVrka(pointClick);
                return;
            }
            if (SkillSelection[3])
            {
                SkillZevs(pointClick);
                return;
            }

            if(lastClick == new Point(-1, -1))
            {
                SetSelectionMatrixAndLoadPictureBoxes(pointClick);
                return;
            }

            int[,] helpMatrix = Matrix.GetCopyMatrix();
            Matrix.Swap(ref helpMatrix[pointClick.X, pointClick.Y], ref helpMatrix[lastClick.X, lastClick.Y]);

            if (!Matrix.IsIt3InARow(helpMatrix))// если при перестановке не получается 3 в ряд
            {
                SetSelectionMatrixAndLoadPictureBoxes(pointClick);
            }
            else
            {
                ClearSelectionMatrix();
                Matrix.ElementsMatrix = helpMatrix;
                LoadPictureBoxes();
                timerAnimation.Enabled = true;
            }
        }

        private bool IsSelection()
        {
            for (int i = 0; i < SelectionMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < SelectionMatrix.GetLength(0); j++)
                {
                    if(SelectionMatrix[i,j] == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private Point GetSelection()
        {
            for (int i = 0; i < SelectionMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < SelectionMatrix.GetLength(0); j++)
                {
                    if (SelectionMatrix[i, j] == 1)
                    {
                        return new Point(i, j);
                    }
                }
            }
            return new Point(-1, -1);
        }

        private void SetSelectionMatrixAndLoadPictureBoxes(Point pointClick)
        {
            ClearSelectionMatrix();
            SelectionMatrix[pointClick.X, pointClick.Y] = 1;
            LoadPictureBoxes();
        }

        private Point GetLastClick( Point pointClick)
        {
            Point lastClick = new Point(-1,-1);
            if (pointClick.X != 0)
            {
                if (SelectionMatrix[pointClick.X - 1, pointClick.Y] == 1)
                {
                    lastClick = new Point(pointClick.X - 1, pointClick.Y);
                }
            }

            if (pointClick.X != SelectionMatrix.GetLength(0) - 1)
            {
                if (SelectionMatrix[pointClick.X + 1, pointClick.Y] == 1)
                {
                    lastClick = new Point(pointClick.X + 1, pointClick.Y);
                }
            }

            if (pointClick.Y != 0)
            {
                if (SelectionMatrix[pointClick.X, pointClick.Y - 1] == 1)
                {
                    lastClick = new Point(pointClick.X, pointClick.Y - 1);
                }
            }

            if (pointClick.Y != SelectionMatrix.GetLength(1) - 1)
            {
                if (SelectionMatrix[pointClick.X, pointClick.Y + 1] == 1)
                {
                    lastClick = new Point(pointClick.X, pointClick.Y + 1);
                }
            }

            return lastClick;
        }

        public void ClearSelectionMatrix()
        {
            for (int i = 0; i < SelectionMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < SelectionMatrix.GetLength(1); j++)
                {
                    SelectionMatrix[i, j] = 0;
                }
            }
        }

        public void CreatePictureBoxes()
        {
            int x = 5;
            int y = 5;
            for (int i = 0; i < pictureBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < pictureBoxes.GetLength(1); j++)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Location = new Point(x, y),
                        Tag = new Point(i, j),
                        Name = "pictureBox" + i + j,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(70, 70),
                        Visible = true,
                        Parent = pictureBoxBackGround
                    };
                    pictureBox.Load(Matrix[i, j] + ".png");
                    pictureBox.Click += AllPictureBoxesClick;
                    x += 75;
                    pictureBoxes[i, j] = pictureBox;
                }
                x = 5;
                y += 75;
            }
        }

        public void LoadPictureBoxes()
        {
            for (int i = 0; i < pictureBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < pictureBoxes.GetLength(1); j++)
                {
                    if(SelectionMatrix[i,j] == 1)
                    {
                        pictureBoxes[i, j].Load("1." + Matrix[i, j] + ".png");
                    }
                    else
                    {
                        pictureBoxes[i, j].Load(Matrix[i, j] + ".png");
                    }
                }
            }
        }

        private void VengaSkill(Point pointClick)
        {
            if (!IsSelection())
            {
                SetSelectionMatrixAndLoadPictureBoxes(pointClick);
            }
            else
            {
                LoadMusic(10, 2000);
                Point lastClick = GetSelection();
                if(lastClick == pointClick)
                {
                    return;
                }
                else
                {
                    matrix.Swap(ref matrix.ElementsMatrix[pointClick.X, pointClick.Y], ref matrix.ElementsMatrix[lastClick.X, lastClick.Y]);
                    matrix.CountVenga -= ConstantSkillsCost.SkillVenga;
                    timerAnimation.Enabled = true;
                    ActionAfterSkill();
                }
            }
        }

        private void SkillZevs(Point pointClick)
        {
            int view = matrix[pointClick.X, pointClick.Y];
            int[,] helpMatrix = matrix.GetCopyMatrix();

            for (int i = 0; i < helpMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < helpMatrix.GetLength(1); j++)
                {
                    if(helpMatrix[i,j] == view)
                    {
                        helpMatrix[i, j] = 0;
                    }
                }
            }

            int randomNumber = getRandom.Next(1, 3);
            if (randomNumber == 1)
            {
                LoadMusic(17, 4900);
            }
            else
            {
                LoadMusic(18, 5700);
            }
            matrix.CountZevs -= ConstantSkillsCost.SkillZevs;
            timerBombAnimation.Tag = helpMatrix;
            timerBombAnimation.Enabled = true;
            ActionAfterSkill();
        }

        private void ActionAfterSkill()
        {
            ClearSkillSelection();
            ClearSelectionMatrix();
            
            Loader.Load(this);
        }

        private void TechisSkill(Point pointClick)
        {
            int[,] helpMatrix = matrix.GetCopyMatrix();

            helpMatrix[pointClick.X, pointClick.Y] = 0;
            if(pointClick.X + 1 != helpMatrix.GetLength(0))
            {
                helpMatrix[pointClick.X + 1, pointClick.Y] = 0;
            }
            if (pointClick.X != 0)
            {
                helpMatrix[pointClick.X -1, pointClick.Y] = 0;
            }
            if(pointClick.Y + 1 != matrix.ElementsMatrix.GetLength(1))
            {
                helpMatrix[pointClick.X, pointClick.Y+1] = 0;
            }
            if (pointClick.Y != 0)
            {
                helpMatrix[pointClick.X, pointClick.Y-1] = 0;
            }
            if(pointClick.X + 1 != helpMatrix.GetLength(0) && pointClick.Y+1 != helpMatrix.GetLength(1))
            {
                helpMatrix[pointClick.X + 1, pointClick.Y + 1] = 0;
            }
            if (pointClick.X + 1 != helpMatrix.GetLength(0) && pointClick.Y !=0)
            {
                helpMatrix[pointClick.X + 1, pointClick.Y - 1] = 0;
            }
            if (pointClick.X != 0 && pointClick.Y + 1 != helpMatrix.GetLength(1))
            {
                helpMatrix[pointClick.X - 1 , pointClick.Y + 1] = 0;
            }
            if (pointClick.X != 0 && pointClick.Y != 0)
            {
                helpMatrix[pointClick.X - 1, pointClick.Y - 1] = 0;
            }
            int randomNumber = getRandom.Next(1, 3);
            if (randomNumber == 1)
            {
                LoadMusic(11, 1500);
            }
            else
            {
                LoadMusic(12, 1600);
            }

            matrix.CountTechis -= ConstantSkillsCost.SkillTechis;
            timerBombAnimation.Tag = helpMatrix;
            timerBombAnimation.Enabled = true;
            ActionAfterSkill();
        }

        private void SkillSheiker()
        {
            int[,] helpMatrix = matrix.GetCopyMatrix();
            for (int i = 0; i < helpMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < helpMatrix.GetLength(1); j++)
                {
                    helpMatrix[i, j] = 0;
                }
            }
            LoadMusic(19, 2200);
            matrix.CountSheiker -= ConstantSkillsCost.SkillSheiker;
            timerBombAnimation.Tag = helpMatrix;
            timerBombAnimation.Enabled = true;
            ActionAfterSkill();
        }

        

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            if (Matrix.IsIt3InARow() || matrix.IsNulls())
            {
                if (act == 0)
                {
                    Matrix.Destroy3InARow();
                    LoadPictureBoxes();
                    act = 1;
                }
                else
                {
                    Matrix.SortMatrix();
                    Matrix.AddNewElements();
                    LoadPictureBoxes();
                    act = 0;
                }
            }
            else
            {
                timerAnimation.Enabled = false;
            }
            labelCountPoints.Text = "Количество очков - " + Matrix.CountPoints;
            DisplaySkills();
            Loader.Load(this);
        }

        private void DisplaySkills()
        {
            labelVengaFrom.Text = Matrix.CountVenga.ToString();
            labelTechisFrom.Text = Matrix.CountTechis.ToString();
            labelEnchaFrom.Text = Matrix.CountEncha.ToString();
            labelVrkaFrom.Text = Matrix.CountVrka.ToString();
            labelZevsFrom.Text = Matrix.CountZevs.ToString();
            labelVoidFrom.Text = Matrix.CountVoid.ToString();
            labelSheikerFrom.Text = Matrix.CountSheiker.ToString();
        }

        private int act = 0;

        private void pictureBoxMix_Click(object sender, EventArgs e)
        {
            ClearSelectionMatrix();
            Matrix.Mix();
            LoadPictureBoxes();
        }

        private void pictureBoxSkillVenga_Click(object sender, EventArgs e)
        {
            if(matrix.CountVenga < ConstantSkillsCost.SkillVenga)
            {
                LoadMusic(1,2300);
            }
            else
            {
                SetSelection(0);
            }
        }

        private void SetSelection(int index)
        {
            ClearSelectionMatrix();
            LoadPictureBoxes();
            ClearSkillSelection();
            SkillSelection[index] = true;
            Loader.Load(this);
        }

        private void pictureBoxSkillTechis_Click(object sender, EventArgs e)
        {
            if (matrix.CountTechis < ConstantSkillsCost.SkillTechis)
            {
                LoadMusic(getRandom.Next(2,4),1300);
            }
            else
            {
                SetSelection(1);
            }
        }

        private void pictureBoxSkillEncha_Click(object sender, EventArgs e)
        {
            if (matrix.CountEncha < ConstantSkillsCost.SkillEncha)
            {
                LoadMusic(4,1500);
            }
            else
            {
                SkillEncha();
            }
        }

        private void pictureBoxSkillVrka_Click(object sender, EventArgs e)
        {
            if (matrix.CountVrka < ConstantSkillsCost.SkillVrka)
            {
                LoadMusic(5,1500);
            }
            else
            {
                SetSelection(2);
            }
        }

        private void pictureBoxSkillZevs_Click(object sender, EventArgs e)
        {
            if (matrix.CountZevs < ConstantSkillsCost.SkillZevs)
            {
                LoadMusic(6,1500);
            }
            else
            {
                SetSelection(3);
            }
        }

        private void pictureBoxSkillVoid_Click(object sender, EventArgs e)
        {
            if (matrix.CountVoid < ConstantSkillsCost.SkillVoid)
            {
                LoadMusic(8,2000);
            }
            else
            {
                SkillVoid();
            }
        }

        private void SkillEncha()
        {
            int randomNumber = getRandom.Next(1, 3);
            if (randomNumber == 1)
            {
                LoadMusic(15, 7500);
            }
            else
            {
                LoadMusic(16, 4000);
            }
            timeSpeed /= 2;
            matrix.CountEncha -= ConstantSkillsCost.SkillEncha;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer
            {
                Interval = 10000
            };
            timer.Tick += DoubleTime;
            timer.Enabled = true;
            DisplaySkills();
            ActionAfterSkill();
        }

        private void SkillVoid()
        {
            LoadMusic(14, 3000);
            matrix.CountVoid -= ConstantSkillsCost.SkillVoid;
            timeToAppCountTimer = 10;
            timerCountTime.Enabled = false;
            timerTimeToAppCountTimer.Enabled = true;
            DisplaySkills();
            ActionAfterSkill();
        }

        private void SkillVrka(Point pointClick)
        {
            int[,] helpMatrix = matrix.GetCopyMatrix();
            for (int i = 0; i < helpMatrix.GetLength(0); i++)
            {
                helpMatrix[i, pointClick.Y] = 0;
            }
            for (int j = 0; j < helpMatrix.GetLength(1); j++)
            {
                helpMatrix[pointClick.X, j] = 0;
            }
            LoadMusic(13, 2100);
            matrix.CountVrka -= ConstantSkillsCost.SkillVrka;
            timerBombAnimation.Tag = helpMatrix;
            timerBombAnimation.Enabled = true;
            ActionAfterSkill();
        }

        private void pictureBoxSkillSheiker_Click(object sender, EventArgs e)
        {
            if (matrix.CountSheiker < ConstantSkillsCost.SkillSheiker)
            {
                LoadMusic(7,1400);
            }
            else
            {
                SkillSheiker();
            }
        }

        private void LoadMusic(int count, int interval)
        {
            //System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(count + ".wav");
            //soundPlayer.PlayLooping();
            //System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer
            //{
            //    Interval = interval,
            //    Tag = soundPlayer
            //};
            //timer.Tick += timerMusic_Tick;
            //timer.Enabled = true;
            soundPlayer = new System.Media.SoundPlayer(count + ".wav");
            soundPlayer.PlayLooping();
            timerEndMusic.Interval = interval;
            timerEndMusic.Enabled = false;
            timerEndMusic.Enabled = true;
        }

        private void ClearSkillSelection()
        {
            for (int i = 0; i < SkillSelection.Length; i++)
            {
                SkillSelection[i] = false;
            }
        }

        private void timerBombAnimation_Tick(object sender, EventArgs e)
        {
            matrix.Destroy3InARow((int[,])timerBombAnimation.Tag);
            LoadPictureBoxes();
            timerBombAnimation.Enabled = false;
            act = 1;
            timerAnimation.Enabled = true;
        }

       

        private void DoubleTime(object sender, EventArgs e)
        {
            timeSpeed *= 2;
            (sender as System.Windows.Forms.Timer).Enabled = false;
        }

        private void timerCountTime_Tick(object sender, EventArgs e)
        {
            timeToEnd -= timeSpeed;
            if(timeToEnd <= 0)
            {
                this.Visible = false;
                this.Close();
                timerCountTime.Enabled = false;
                FormResultGame formResultGame = new FormResultGame(matrix.CountPoints, complication);
                formResultGame.ShowDialog();
            }
            else
            {
                labelTimeToEnd.Text = "Осталось " + Math.Round(timeToEnd, 2) + " секунд";
            }
        }

        private void pictureBoxBackGround_Click(object sender, EventArgs e)
        {
        }

        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerCountTime.Enabled = false;
        }

        private void timerTimeToAppCountTimer_Tick(object sender, EventArgs e)
        {
            timeToAppCountTimer -= 1;
            if(timeToAppCountTimer == 0)
            {
                timerTimeToAppCountTimer.Enabled = false;
                timerCountTime.Enabled = true;
            }
        }

        private void timerMusic_Tick(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = sender as System.Windows.Forms.Timer;
            System.Media.SoundPlayer soundPlayer = (System.Media.SoundPlayer)timer.Tag;
            soundPlayer.Stop();
            (sender as System.Windows.Forms.Timer).Enabled = false;
        }

        private double timeToEnd;
        private double timeSpeed = 1;
        private int timeToAppCountTimer = 0;
        private Complication complication;
        private Matrix matrix;
        private static Random getRandom = new Random();
        private System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();

        private void timerEndMusic_Tick(object sender, EventArgs e)
        {
            timerEndMusic.Enabled = false;
            soundPlayer.Stop();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        
}

