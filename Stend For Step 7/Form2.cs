using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stend_For_Step_7
{
    public partial class Form2 : Form
    {
       // StendStep7 MainForm = new StendStep7();
        public S7PROSIMLib.S7ProSim PS = new S7PROSIMLib.S7ProSim();
        public static uint level;
        public static int startPositionOfPic, H;
        public static int valueToPIW352;
        public static float LevelInt;
        public static bool clikedButton2, clikedButton1, levelFromButton;


        public Form2()
        {
            InitializeComponent();
            startPositionOfPic = pictureBox3.Location.Y;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerLevelLicuide.Enabled = false;
            Form MainForm = Application.OpenForms[0];
            MainForm.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PS.Connect();
            PS.SetScanMode(S7PROSIMLib.ScanModeConstants.ContinuousScan);
            timerLevelLicuide.Enabled = true;
            pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + 50);
            H = pictureBox3.Location.Y - 110 - pictureBox1.Location.Y;

        }

        private void timerLevelLicuide_Tick(object sender, EventArgs e)
        {
            if (levelFromButton == true)
            {
                // Скан слова 
                object QW = new byte[1];
                PS.ReadOutputImage(226, 1, S7PROSIMLib.ImageDataTypeConstants.S7Word, ref QW);
                short[] t = (short[])QW;
                level = (UInt16)t[0];
            }
            else
            {
                level = (uint)valueToPIW352;
            }
            // Подгон слова под уровень жидкости в баке
            if (level >= 0)
            {
                level = level + 9000;
                LevelInt = (float)level / (65535+9000);
                int locationPic = startPositionOfPic - (int)(LevelInt * H);
                pictureBox3.Location = new Point(pictureBox3.Location.X, locationPic);
                pictureBox2.Image = (Image)Stend_For_Step_7.Properties.Resources.Tank05;
            }
            // Преобразоване в HEX и в показометр
            level = level - 9000;
            int number1FromOutputUnit = (int)(level % 16);
            int number2FromOutputUnit = (int)((level / 16) % 16);
            int number3FromOutputUnit = (int)(((level / 16) / 16) % 16);
            int number4FromOutputUnit = (int)(((level / 16) / 16) / 16);
            numberIndicator4.Text = convertIntToHex(number4FromOutputUnit);
            numberIndicator3.Text = convertIntToHex(number3FromOutputUnit);
            numberIndicator2.Text = convertIntToHex(number2FromOutputUnit);
            numberIndicator1.Text = convertIntToHex(number1FromOutputUnit);

            // работа лампочек
            object q5_1 = true; // initial
            PS.ReadOutputPoint(5, 1, S7PROSIMLib.PointDataTypeConstants.S7_Bit, ref q5_1);
            workingLamp(pictureBox5, (bool)q5_1);
            object q5_2 = true; // initial
            PS.ReadOutputPoint(5, 2, S7PROSIMLib.PointDataTypeConstants.S7_Bit, ref q5_2);
            workingLamp(pictureBox6, (bool)q5_2);
            //-----------------------------------


        }

        private void workingLamp (PictureBox picture, Boolean stateLamp)
        {
            if (stateLamp == true)
                picture.Image = (Image)Stend_For_Step_7.Properties.Resources.Red_Button_Poped;
            else
                picture.Image = (Image)Stend_For_Step_7.Properties.Resources.Green_Button_Poped;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            timerButtons.Enabled = true;
            clikedButton2 = true;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            timerButtons.Enabled = false;
            clikedButton2 = false;
        }

        private void timerButtons_Tick(object sender, EventArgs e)
        {
            if (clikedButton2 == true & valueToPIW352 >= 0 & valueToPIW352 <= 65300)
            {
                valueToPIW352 = valueToPIW352 + 100;
                writeWordToPLC(valueToPIW352, 352);
            }
            if (clikedButton1 == true & valueToPIW352 >= 100 & valueToPIW352 <= 65400)
            {
                valueToPIW352 = valueToPIW352 - 100;
                writeWordToPLC(valueToPIW352, 352);
            }

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            timerButtons.Enabled = true;
            clikedButton1 = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            timerButtons.Enabled = false;
            clikedButton1 = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (levelFromButton == false)
            {
                levelFromButton = true;
                button3.Text = "Level from PQW 226";
                SourceOfInput.Text = "PQW 226";
            }
            else
            {
                levelFromButton = false;
                button3.Text = "Level from button";
                SourceOfInput.Text = "PIW 352";
            }
        }

        // конвертирование в буквы HEX
        private string convertIntToHex(int a)
        {
            if (a < 10) return a.ToString();
            if (a == 10) return "A";
            if (a == 11) return "B";
            if (a == 12) return "C";
            if (a == 13) return "D";
            if (a == 14) return "E";
            if (a == 15) return "F";
            if (a == 16) return "G";
            return "0";
        }

        // передать значение в IW
        public void writeWordToPLC(int value, int addres)
        {
            byte[] IW = BitConverter.GetBytes(value);
            byte temp = IW[0];
            IW[0] = IW[1];
            IW[1] = temp;
            PS.WriteInputImage(addres, IW);
        }

    }
}
