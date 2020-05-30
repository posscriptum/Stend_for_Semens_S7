using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stend_For_Step_7
{
    public partial class StendStep7 : Form
    {

        // декларации
        public S7PROSIMLib.S7ProSim PS = new S7PROSIMLib.S7ProSim();
        public static Boolean Switch6, Switch7, Switch9;
        public static Boolean LampH1, LampH2, LampH3, LampH4;
        public static Boolean ButtonS1, ButtonS2, ButtonS3, ButtonS4;
        public static Boolean buttonOnOff;
        public static Boolean buttonEmergence = true;
        //public static Image ButtonBluePush = (Image)Stend_For_Step_7.Properties.Resources.Blue_Button_Pushed;;
        public Image pathToButtonBluePush = (Image)Stend_For_Step_7.Properties.Resources.Blue_Button_Pushed;
        public Image pathToButtonBluePop = (Image)Stend_For_Step_7.Properties.Resources.Blue_Button_Poped;
        public Image pathToButtonRedPush = (Image)Stend_For_Step_7.Properties.Resources.Red_Button_Pushed;
        public Image pathToButtonRedPop = (Image)Stend_For_Step_7.Properties.Resources.Red_Button_Poped;
        public Image pathToButtonGreenPush = (Image)Stend_For_Step_7.Properties.Resources.Green_Button_Pushed;
        public Image pathToButtonGreenPop = (Image)Stend_For_Step_7.Properties.Resources.Green_Button_Poped1;
        public Image pathToButtonYellowePush = (Image)Stend_For_Step_7.Properties.Resources.Yellow_Button_Pushed;
        public Image pathToButtonYellowPop = (Image)Stend_For_Step_7.Properties.Resources.Yellow_Button_Poped;
        public static Int32 number1FromInputUnit, number2FromInputUnit, number3FromInputUnit, number4FromInputUnit, numberOfInputUnit, numberOfIndicator;
        public static Int32 number1FromOutputUnit, number2FromOutputUnit, number3FromOutputUnit, number4FromOutputUnit;
        public static bool ToggleIX_0, ToggleIX_1, ToggleIX_2, ToggleIX_3, ToggleIX_4, ToggleIX_5, ToggleIX_6, ToggleIX_7;
        public static bool ToggleIY_0, ToggleIY_1, ToggleIY_2, ToggleIY_3, ToggleIY_4, ToggleIY_5, ToggleIY_6, ToggleIY_7;
        public static double speed, speedAuto;
        public static bool conveyerDerection, autoOrManual, badPacket, randomEnable;
        public static bool sensor1, sensor2, sensor3, sensor4, conveyerRunning, RelayK1, RelayK2, RelayK3, badPacketOnConveyer;
        public static int storeStartPositionOfPacket, varForMoveConv, firstLocationOfPicConveyer, tempForResetTimer, tempForDisconnectConnect, varForTurnWheel;
        public static bool modeOfWorkSensorB4;
       // public string n1, n2, n3, n4;


        
        // конструктор класса
        public StendStep7()
        {
            InitializeComponent();
            transferNumberFromIndicator();
        }

        // кнопка S4;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //if (ButtonS4 == false)
            //    ButtonS4 = true;
            //else

            //    ButtonS4 = false;
        }

        // временная кнопка вкл. лампочек
        private void button1_Click(object sender, EventArgs e)
        {
            if (LampH2 == false)
                LampH2 = true;
            else
                LampH2 = false;
            if (LampH1 == false)
                LampH1 = true;
            else
                LampH1 = false;
            if (LampH3 == false)
                LampH3 = true;
            else
                LampH3 = false;
            if (LampH4 == false)
                LampH4 = true;
            else
                LampH4 = false;
        }

        // опрост кнопок
        private void Buttons_Tick(object sender, EventArgs e)
        {
            buttonWithLampView(ButtonS4, LampH2, pictureBox2, pathToButtonGreenPop, pathToButtonGreenPush);
            buttonWithLampView(ButtonS3, LampH4, buttonS3H4, pathToButtonBluePop, pathToButtonBluePush);
            buttonWithLampView(ButtonS2, LampH3, buttonS2H3, pathToButtonRedPop, pathToButtonRedPush);
            buttonWithLampView(ButtonS1, LampH1, butonS1H1, pathToButtonYellowPop, pathToButtonYellowePush);
        }

        // кнопка S2
        private void buttonS2H3_Click(object sender, EventArgs e)
        {
            //if (ButtonS2 == false)
            //    ButtonS2 = true;
            //else

            //    ButtonS2 = false;
        }
        // кнопка S1
        private void butonS1H1_Click(object sender, EventArgs e)
        {
            if (ButtonS1 == false)
                ButtonS1 = true;
            else

                ButtonS1 = false;
        }

        private void Toggle_1_Click(object sender, EventArgs e)
        {
            ToggleIX_1 = ToggleButton(0, 1, ToggleIX_1, Toggle_1);
            //PS.WriteInputPoint(0, 1, ToggleIX_1);
        }

        private void Toggle_2_Click(object sender, EventArgs e)
        {
            ToggleIX_2 = ToggleButton(0, 2, ToggleIX_2, Toggle_2);
            //PS.WriteInputPoint(0, 2, ToggleIX_2);
        }

        private void Toggle_3_Click(object sender, EventArgs e)
        {
            ToggleIX_3 = ToggleButton(0, 3, ToggleIX_3, Toggle_3);
            //PS.WriteInputPoint(0, 3, ToggleIX_3);
        }

        private void Toggle_4_Click(object sender, EventArgs e)
        {
            ToggleIX_4 = ToggleButton(0, 4, ToggleIX_4, Toggle_4);
            //PS.WriteInputPoint(0, 4, ToggleIX_4);
        }

        private void Toggle_5_Click(object sender, EventArgs e)
        {
            ToggleIX_5 = ToggleButton(0, 5, ToggleIX_5, Toggle_5);
            //PS.WriteInputPoint(0, 5, ToggleIX_5);
        }

        private void Toggle_6_Click(object sender, EventArgs e)
        {
            ToggleIX_6 = ToggleButton(0, 6, ToggleIX_6, Toggle_6);
            //PS.WriteInputPoint(0, 6, ToggleIX_6);
        }

        private void Toggle_7_Click(object sender, EventArgs e)
        {
            ToggleIX_7 = ToggleButton(0, 7, ToggleIX_7, Toggle_7);
            //PS.WriteInputPoint(0, 7, ToggleIX_7);
        }

        private void Toggle1_0_Click(object sender, EventArgs e)
        {
            ToggleIY_0 = ToggleButton(1, 0, ToggleIY_0, Toggle1_0);
            //PS.WriteInputPoint(1, 0, ToggleIY_0);
        }

        private void Toggle1_1_Click(object sender, EventArgs e)
        {
            ToggleIY_1 = ToggleButton(1, 1, ToggleIY_1, Toggle1_1);
           // PS.WriteInputPoint(1, 1, ToggleIY_1);
        }

        private void timerForReset_Tick(object sender, EventArgs e)
        {
            tempForResetTimer = tempForResetTimer + 1;
            if (tempForResetTimer>1)
            {
                tempForResetTimer = 0;
                timerForReset.Enabled = false;
                PS.SetState("RUN_P");
            }
        }

        // temp-------------------------------------------
        private int numtemp;

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            numtemp = numtemp + 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, MouseEventArgs e)
        {
            numtemp = numtemp + 1;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            numtemp = numtemp + 1;
        }

        //-----------------------------------------------------------
        private void buttonReconnect_Click(object sender, EventArgs e)
        {
            PS.Connect();
        }

        private void buttonPlus_MouseDown(object sender, MouseEventArgs e)
        {
            functionForIncrementSpeed();
            timerIncSpeed.Enabled = true;
        }

        private void buttonPlus_MouseUp(object sender, MouseEventArgs e)
        {
            timerIncSpeed.Enabled = false;
        }

        private void timerIncSpeed_Tick(object sender, EventArgs e)
        {
            functionForIncrementSpeed();
        }

        private void buttonResetCPU_Click(object sender, EventArgs e)
        {
            PS.SetState("STOP");
            timerForReset.Enabled = true;
        }

        private void buttonMinus_MouseDown(object sender, MouseEventArgs e)
        {
            functionForDecrementSpeed();
            timerDecSpeed.Enabled = true;
        }

        private void buttonS3H4_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonS3 = true;
        }

        private void buttonS3H4_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonS3 = false;
        }

        private void buttonS2H3_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonS2 = true;
        }

        private void buttonS2H3_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonS2 = false;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonS4 = true;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonS4 = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           if(modeOfWorkSensorB4 == false)
            {
                buttonModeB4.Text = "Normal work";
                modeOfWorkSensorB4 = true;
            }
            else
            {
                buttonModeB4.Text = "Check bad packet only";
                modeOfWorkSensorB4 = false;
            }
        }

        private void buttonMinus_MouseUp(object sender, MouseEventArgs e)
        {
            timerDecSpeed.Enabled = false;
        }

        private void timerSetSpeedAutoMode_Tick(object sender, EventArgs e)
        {
            setSpeedInAutoMode();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            packet.Location = new Point(groupBox3.Size.Width + 2, packet.Location.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Tank = new Form2();
            this.Hide();
            Tank.ShowDialog();
            // this.Enabled = false;
            
        }


        private void timerDecSpeed_Tick(object sender, EventArgs e)
        {
            functionForDecrementSpeed();
        }


        private void Toggle1_2_Click(object sender, EventArgs e)
        {
            ToggleIY_2 = ToggleButton(1, 2, ToggleIY_2, Toggle1_2);
            //PS.WriteInputPoint(1, 2, ToggleIY_2);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

        }

        private void buttonPutPacketOnStation2_Click(object sender, EventArgs e)
        {
            getPacketOnConveyer(pictureBox8.Location.X + pictureBox8.Size.Width / 2 - packet.Size.Width + 2);
        }

        private void buttonPutPacketOnStation3_Click(object sender, EventArgs e)
        {
            getPacketOnConveyer(pictureBox9.Location.X + pictureBox9.Size.Width / 2 - packet.Size.Width + 2);
        }

        private void Toggle1_3_Click(object sender, EventArgs e)
        {
            ToggleIY_3 = ToggleButton(1, 3, ToggleIY_3, Toggle1_3);
            //PS.WriteInputPoint(1, 3, ToggleIY_3);
        }

        private void randomChoosePacket_Click(object sender, EventArgs e)
        {
            if (buttonGoodBad.Enabled == true)
                buttonGoodBad.Enabled = false;
            else
            {
                buttonGoodBad.Enabled = true;
                if (buttonGoodBad.Text == "Good Packet")
                {
                    badPacket = false;
                }
                else
                {
                    badPacket = true;
                }
            }
            //Random rnd = new Random();
            if (randomEnable == true)
                randomEnable = false;
            else
                randomEnable = true;

        }

        private void Toggle1_4_Click(object sender, EventArgs e)
        {
            ToggleIY_4 = ToggleButton(1, 4, ToggleIY_4, Toggle1_4);
            //PS.WriteInputPoint(1, 4, ToggleIY_4);
        }

        private void Toggle1_5_Click(object sender, EventArgs e)
        {
            ToggleIY_5 = ToggleButton(1, 5, ToggleIY_5, Toggle1_5);
            //PS.WriteInputPoint(1, 5, ToggleIY_5);
        }

        private void Toggle1_6_Click(object sender, EventArgs e)
        {
            ToggleIY_6 = ToggleButton(1, 6, ToggleIY_6, Toggle1_6);
            //PS.WriteInputPoint(1, 6, ToggleIY_6);
        }

        private void Toggle1_7_Click(object sender, EventArgs e)
        {
            ToggleIY_7 = ToggleButton(1, 7, ToggleIY_7, Toggle1_7);
            //PS.WriteInputPoint(1, 7, ToggleIY_7);
        }

        private void conveyer_Tick(object sender, EventArgs e)
        {
            if ((speed > 0 & autoOrManual == false) || (speedAuto > 0 & autoOrManual == true))
            {
                if (packet.Location.X <= groupBox3.Size.Width & packet.Location.X >= -packet.Size.Width)
                //    conveyer.Enabled = false;
               // else
                    if (conveyerDerection == false)
                        packet.Location = new Point(packet.Location.X + 1, packet.Location.Y);
                    else
                        packet.Location = new Point(packet.Location.X - 1, packet.Location.Y);
            }

            // датчики на конвейере
            sensor1 = sensorLight(pictureBox7.Location.X + (pictureBox7.Size.Width / 2) - packet.Size.Width, pictureBox7.Location.X + (pictureBox7.Size.Width / 2), picSensor1, 5);
            sensor2 = sensorLight(pictureBox8.Location.X + (pictureBox8.Size.Width / 2) - packet.Size.Width, pictureBox8.Location.X + (pictureBox8.Size.Width / 2), picSensor2, 6);
            sensor3 = sensorLight(pictureBox9.Location.X + (pictureBox9.Size.Width / 2) - packet.Size.Width, pictureBox9.Location.X + (pictureBox9.Size.Width / 2), picSensor3, 7);
            //if (badPacketOnConveyer == true)
                sensor4 = sensorInvertLight(pictureBox10.Location.X + (pictureBox10.Size.Width / 2) - packet.Size.Width, pictureBox10.Location.X + (pictureBox10.Size.Width / 2), picSensor4, 0);


            if (RelayK1 == true & RelayK2 ==false)
                    conveyerDerection = false;
            if (RelayK2 == true & RelayK1 == false)
                conveyerDerection = true;

            if (((speed > 0 & autoOrManual == false) || (speedAuto > 0 & autoOrManual == true)) & (conveyerDerection == false) & (conveyerRunning == true))
            {
                // вперед
                varForMoveConv = varForMoveConv + 1;
                if (varForMoveConv <= 80)
                {
                    ConveyerLine.Location = new Point(ConveyerLine.Location.X + 1, ConveyerLine.Location.Y);
                }
                else
                {
                    ConveyerLine.Location = new Point(firstLocationOfPicConveyer, ConveyerLine.Location.Y);
                    varForMoveConv = 0;
                }

                varForTurnWheel = varForTurnWheel + 1;
                if (varForTurnWheel == 11) varForTurnWheel = 1;
                string temp = "Wheel" + varForTurnWheel.ToString();
                pictureWheels1.Image = (Image)Properties.Resources.ResourceManager.GetObject(temp);
                pictureWheels2.Image = (Image)Properties.Resources.ResourceManager.GetObject(temp);
            }

            if (((speed > 0 & autoOrManual == false) || (speedAuto > 0 & autoOrManual == true)) & (conveyerDerection == true) & (conveyerRunning == true))
            {
                // назад
                varForMoveConv = varForMoveConv + 1;
                if (varForMoveConv <= 80)
                {
                    ConveyerLine.Location = new Point(ConveyerLine.Location.X - 1, ConveyerLine.Location.Y);
                }
                else
                {
                    ConveyerLine.Location = new Point(firstLocationOfPicConveyer, ConveyerLine.Location.Y);
                    varForMoveConv = 0;
                }

                varForTurnWheel = varForTurnWheel - 1;
                if (varForTurnWheel <= 0) varForTurnWheel = 10;
                string temp = "Wheel" + varForTurnWheel.ToString();
                pictureWheels1.Image = (Image)Properties.Resources.ResourceManager.GetObject(temp);
                pictureWheels2.Image = (Image)Properties.Resources.ResourceManager.GetObject(temp);
            }

        }

        private bool sensorLight (int start, int stop, PictureBox pictureLED, int bit)
        {
            if (packet.Location.X > start & packet.Location.X < stop)
            {
                pictureLED.Image = (Image)Stend_For_Step_7.Properties.Resources.Red_LED_Light;
                PS.WriteInputPoint(16, bit, true);
                return true;
            }
            else
            {
                pictureLED.Image = (Image)Stend_For_Step_7.Properties.Resources.Red_LED_NoLight1;
                PS.WriteInputPoint(16, bit, false);
                return false;
            }
        }

        private bool sensorInvertLight(int start, int stop, PictureBox pictureLED, int bit)
        {
            if (packet.Location.X > start & packet.Location.X < stop & (badPacketOnConveyer == true || modeOfWorkSensorB4 == true))
            {
                pictureLED.Image = (Image)Stend_For_Step_7.Properties.Resources.Red_LED_NoLight1;
                PS.WriteInputPoint(16, bit, false);
                return false;
            }
            else
            {
                pictureLED.Image = (Image)Stend_For_Step_7.Properties.Resources.Red_LED_Light;
                PS.WriteInputPoint(16, bit, true);
                return true;
            }
        }


        private void getPacket_Click(object sender, EventArgs e)
        {
            getPacketOnConveyer(storeStartPositionOfPacket);
        }

        private void getPacketOnConveyer(int position)
        {

            if ((packet.Location.X >= groupBox3.Width || packet.Location.X <= -packet.Size.Width))// & conveyer.Enabled == false)
            {
                if (badPacket == false)
                {
                    packet.Image = (Image)Stend_For_Step_7.Properties.Resources.PacketGood;
                    badPacketOnConveyer = false;
                }
                else
                {
                    packet.Image = (Image)Stend_For_Step_7.Properties.Resources.PacketBad;
                    badPacketOnConveyer = true;
                }
                packet.Location = new Point(position, packet.Location.Y);
                if (conveyerRunning == true)
                    conveyer.Enabled = true;
            }
        }

        private void buttonGoodBad_Click(object sender, EventArgs e)
        {
            if (badPacket == false)
            {
                badPacket = true;
                buttonGoodBad.Text = "Bad Packet";
            }
            else
            {
                badPacket = false;
                buttonGoodBad.Text = "Good Packet";
            }
        }

        private void AutoManualButton_Click(object sender, EventArgs e)
        {
            if (autoOrManual == false)
            {
                timerSetSpeedAutoMode.Enabled = true;
            }
            else
            {
                timerSetSpeedAutoMode.Enabled = false;
                AutoManualButton.Text = "Manual";
                autoOrManual = false;
                if (speed > 0)
                    conveyer.Interval = 100 - (int)(speed * 9.5);
            }
        }

        private void setSpeedInAutoMode()
        {
            AutoManualButton.Text = "Auto";
            autoOrManual = true;
            // Задание скорости в автоматическом режиме
            object QW = new byte[1];
            PS.ReadOutputImage(224, 1, S7PROSIMLib.ImageDataTypeConstants.S7Word, ref QW);
            short[] t = (short[])QW;
            uint numberTemp = (UInt16)t[0];
            double temp1 = (numberTemp * 10) / 65535;
            speedAuto = Math.Round(temp1, 1);
            if (speedAuto > 0)
                conveyer.Interval = 100 - (int)(speedAuto * 9.5);
        }

        private void directionOfConveyer_Click(object sender, EventArgs e)
        {

        }

        private void changeConditionOfLED (int addresByte, int addresBit, PictureBox picture)
        {
            object value = true; // initial
            PS.ReadOutputPoint(addresByte, addresBit, S7PROSIMLib.PointDataTypeConstants.S7_Bit, ref value);
            if ((bool)value == true)
            {
                picture.Image = (Image)Stend_For_Step_7.Properties.Resources.Red_LED_Light;
            }
            else
            {
                picture.Image = (Image)Stend_For_Step_7.Properties.Resources.Red_LED_NoLight1;
            }
        }

        // кнопка S3
        private void buttonS3H4_Click(object sender, EventArgs e)
        {
           // if (ButtonS3 == false)
           //     ButtonS3 = true;
           // else
           //     ButtonS3 = false;
        }

        // аварийка
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (buttonEmergence == false)
            {
                buttonEmergence = true;
                pictureBox4.Image = (Image)Stend_For_Step_7.Properties.Resources.Red_Button_Open;
            }
            else
            {
                buttonEmergence = false;
                pictureBox4.Image = (Image)Stend_For_Step_7.Properties.Resources.Red_Button_Closed;
            }
        }

        // вторая кнопка сверху задатчика
        private void buttonUpNumber2_Click(object sender, EventArgs e)
        {
            number2FromInputUnit = Add(number2FromInputUnit, number2);
            transferNumberFromIndicator();
        }

        // третья кнопка сверху задатчика
        private void buttonUpNumber3_Click(object sender, EventArgs e)
        {
            number3FromInputUnit = Add(number3FromInputUnit, number3);
            transferNumberFromIndicator();
        }

        // четвертая кнопка сверху задатчика
        private void buttonUpNumber4_Click(object sender, EventArgs e)
        {
            number4FromInputUnit = Add(number4FromInputUnit, number4);
            transferNumberFromIndicator();
        }

        private void transferNumberFromIndicator()
        {
            //индикатор с кнопками получение числа и передача его в IW2
            numberOfInputUnit = number1FromInputUnit + (number2FromInputUnit * 10) + (number3FromInputUnit * 100) + (number4FromInputUnit * 1000);
           // label18.Text = numberOfInputUnit.ToString();
            byte[] IW = BitConverter.GetBytes(numberOfInputUnit);
            byte temp = IW[0];
            IW[0] = IW[1];
            IW[1] = temp;
            //byte[] IW;
            //IW = new byte[2];
            //IW[0] = 0;
            //IW[1] = (byte)numberOfInputUnit;
            PS.WriteInputImage(2, IW);
          //  label19.Text = IW[0].ToString();
           // label20.Text = IW[1].ToString();
        }

        // таймер опроса выходов и записи входов
        private void ScanIO_Tick(object sender, EventArgs e)
        {
            //Скан входов
            PS.WriteInputPoint(17, 1, Switch6);
            PS.WriteInputPoint(17, 2, Switch7);
            PS.WriteInputPoint(17, 3, buttonOnOff);
            PS.WriteInputPoint(17, 4, Switch9);
            PS.WriteInputPoint(16, 1, ButtonS1);
            PS.WriteInputPoint(16, 2, ButtonS2);
            PS.WriteInputPoint(16, 3, ButtonS3);
            PS.WriteInputPoint(16, 4, ButtonS4);
            PS.WriteInputPoint(17, 0, buttonEmergence);
   //         PS.WriteInputPoint(0, 0, ToggleIX_0);
   //         PS.WriteInputPoint(0, 1, ToggleIX_1);
   //         PS.WriteInputPoint(0, 2, ToggleIX_2);
   //         PS.WriteInputPoint(0, 3, ToggleIX_3);
   //         PS.WriteInputPoint(0, 4, ToggleIX_4);
   //         PS.WriteInputPoint(0, 5, ToggleIX_5);
   //         PS.WriteInputPoint(0, 6, ToggleIX_6);
   //         PS.WriteInputPoint(0, 7, ToggleIX_7);
   //         PS.WriteInputPoint(1, 0, ToggleIY_0);
   //         PS.WriteInputPoint(1, 1, ToggleIY_1);
   //         PS.WriteInputPoint(1, 2, ToggleIY_2);
   //         PS.WriteInputPoint(1, 3, ToggleIY_3);
   //         PS.WriteInputPoint(1, 4, ToggleIY_4);
   //         PS.WriteInputPoint(1, 5, ToggleIY_5);
   //         PS.WriteInputPoint(1, 6, ToggleIY_6);
   //         PS.WriteInputPoint(1, 7, ToggleIY_7);
   
            // random функция
            if (randomEnable & (packet.Location.X >= groupBox3.Width || packet.Location.X <= -packet.Size.Width))
            {
                Random rnd = new Random();
                int val = rnd.Next(0, 100);
                if (val < 50)
                    badPacket = false;
                else
                    badPacket = true;
                getPacketOnConveyer(storeStartPositionOfPacket);
               // randomEnable = false;
            }

            // Скан выходов
            object q4_0 = true; // initial
            PS.ReadOutputPoint(4, 0, S7PROSIMLib.PointDataTypeConstants.S7_Bit, ref q4_0);
            LampH1 = (bool)q4_0;

            object q4_4 = true; // initial
            PS.ReadOutputPoint(4, 4, S7PROSIMLib.PointDataTypeConstants.S7_Bit, ref q4_4);
            LampH2 = (bool)q4_4;

            object q4_5 = true; // initial
            PS.ReadOutputPoint(4, 5, S7PROSIMLib.PointDataTypeConstants.S7_Bit, ref q4_5);
            LampH3 = (bool)q4_5;

            object q4_6 = true; // initial
            PS.ReadOutputPoint(4, 6, S7PROSIMLib.PointDataTypeConstants.S7_Bit, ref q4_6);
            LampH4 = (bool)q4_6;

            object q5_6 = true; // initial
            PS.ReadOutputPoint(5, 6, S7PROSIMLib.PointDataTypeConstants.S7_Bit, ref q5_6);
            RelayK1 = (bool)q5_6;

            object q5_5 = true; // initial
            PS.ReadOutputPoint(5, 5, S7PROSIMLib.PointDataTypeConstants.S7_Bit, ref q5_5);
            RelayK2 = (bool)q5_5;

            object q5_0 = true; // initial
            PS.ReadOutputPoint(5, 0, S7PROSIMLib.PointDataTypeConstants.S7_Bit, ref q5_0);
            RelayK3 = (bool)q5_0;

            if (RelayK3 == true & !(RelayK1 & RelayK2) & !(!RelayK1 & !RelayK2))
            {
                conveyer.Enabled = true;
                conveyerRunning = true;
            }
            else
            {
                conveyer.Enabled = false;
                conveyerRunning = false;
            }

            // светодиоды на имитаторе
            int tempBytes;
            Int32.TryParse(firstInputBoxInImitator.Text,out tempBytes);
            ////////
            changeConditionOfLED(tempBytes, 0, LED_16_0);
            changeConditionOfLED(tempBytes, 1, LED_16_1);
            changeConditionOfLED(tempBytes, 2, LED_16_2);
            changeConditionOfLED(tempBytes, 3, LED_16_3);
            changeConditionOfLED(tempBytes, 4, LED_16_4);
            changeConditionOfLED(tempBytes, 5, LED_16_5);
            changeConditionOfLED(tempBytes, 6, LED_16_6);
            changeConditionOfLED(tempBytes, 7, LED_16_7);

            Int32.TryParse(secondInputBoxInImitator.Text, out tempBytes);

            changeConditionOfLED(tempBytes, 0, LED_17_0);
            changeConditionOfLED(tempBytes, 1, LED_17_1);
            changeConditionOfLED(tempBytes, 2, LED_17_2);
            changeConditionOfLED(tempBytes, 3, LED_17_3);
            changeConditionOfLED(tempBytes, 4, LED_17_4);
            changeConditionOfLED(tempBytes, 5, LED_17_5);
            changeConditionOfLED(tempBytes, 6, LED_17_6);
            changeConditionOfLED(tempBytes, 7, LED_17_7);

            // Скан слова и передача его в показометр
            object QW = new byte[1];
            PS.ReadOutputImage(6,1,S7PROSIMLib.ImageDataTypeConstants.S7Word,ref QW);
            short[] t = (short[])QW;
            uint numberTemp = (UInt16)t[0];
            number1FromOutputUnit = (int)(numberTemp % 16);
            number2FromOutputUnit = (int)((numberTemp / 16) % 16);
            number3FromOutputUnit = (int) (((numberTemp / 16) / 16) % 16);
            number4FromOutputUnit = (int)(((numberTemp / 16) / 16) / 16);
            numberIndicator4.Text = convertIntToHex(number4FromOutputUnit);
            numberIndicator3.Text = convertIntToHex(number3FromOutputUnit);
            numberIndicator2.Text = convertIntToHex(number2FromOutputUnit);
            numberIndicator1.Text = convertIntToHex(number1FromOutputUnit);
            //label20.Text = t[0].ToString();
                //Console.Write(number4FromOutputUnit);



        }

        // конвертирование в буквы HEX
        private string convertIntToHex (int a)
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

        // задание скорости в +
        private void functionForIncrementSpeed()
        {
            if (speed < 10 & autoOrManual == false)
                speed = Math.Round(speed + 0.1, 1);
            if (speed == 0 || speed == 1 || speed == 2 || speed == 3 || speed == 4 || speed == 5 || speed == 6 || speed == 7 || speed == 8 || speed == 9 || speed == 10)
                labelValueSpeed.Text = speed.ToString() + ",0";
            else
                labelValueSpeed.Text = speed.ToString();
            writeWordToPLC(speed, 350);

            if (speed > 0 & autoOrManual == false)
                conveyer.Interval = 100 - (int)(speed * 9.5);
        }

        // задание скорости в -
        private void functionForDecrementSpeed()
        {
            if ((int)(speed * 10) > 0 & autoOrManual == false)
                speed = Math.Round(speed - 0.1, 1);
            if (speed == 0 || speed == 1 || speed == 2 || speed == 3 || speed == 4 || speed == 5 || speed == 6 || speed == 7 || speed == 8 || speed == 9 || speed == 10)
                labelValueSpeed.Text = speed.ToString() + ",0";
            else
                labelValueSpeed.Text = speed.ToString();
            writeWordToPLC(speed, 350);

            if (speed > 0 & autoOrManual == false)
                conveyer.Interval = 100 - (int)(speed * 9.5);
        }

        // передать значение в IW
        public void writeWordToPLC(double value, int addres)
        {
            byte[] IW = BitConverter.GetBytes(convertVoltToUnit(value));
            byte temp = IW[0];
            IW[0] = IW[1];
            IW[1] = temp;
            PS.WriteInputImage(addres, IW);
        }

        // пересчет в еденицы модуля из вольт
        private UInt16 convertVoltToUnit (double x)
        {
            return (UInt16)((65535 * x) / 10);
        }

        // работа переключателя на панели индикатора
        private bool ToggleButton (int numberOfByte, int numberOfBit, bool toggleValue, PictureBox picture)
        {
            if (toggleValue == false)
            {
                toggleValue = true;
                PS.WriteInputPoint(numberOfByte, numberOfBit, true);
                picture.Image = (Image)Stend_For_Step_7.Properties.Resources.ToggleON;
            }
            else
            {
                toggleValue = false;
                PS.WriteInputPoint(numberOfByte, numberOfBit, false);
                picture.Image = (Image)Stend_For_Step_7.Properties.Resources.ToggleOFF;
            }
            return toggleValue;
        }

        private void Toggle_0_Click(object sender, EventArgs e)
        {

            ToggleIX_0 = ToggleButton(0, 0, ToggleIX_0, Toggle_0);
            
        }



        //// первая кнопка снизу задатчика
        private void buttonDownNumber1_Click(object sender, EventArgs e)
        {
            number1FromInputUnit = Minus(number1FromInputUnit, number1);
            transferNumberFromIndicator();
        }

        // вторая кнопка снизу задатчика
        private void buttonDownNumber2_Click(object sender, EventArgs e)
        {
            number2FromInputUnit = Minus(number2FromInputUnit, number2);
            transferNumberFromIndicator();
        }

        // третья кнопка снизу задатчика
        private void buttonDownNumber3_Click(object sender, EventArgs e)
        {
            number3FromInputUnit = Minus(number3FromInputUnit, number3);
            transferNumberFromIndicator();
        }

        // четвертая кнопка снизу задатчика
        private void buttonDownNumber4_Click(object sender, EventArgs e)
        {
            number4FromInputUnit = Minus(number4FromInputUnit, number4);
            transferNumberFromIndicator();
        }

        // кнопка вкл. стенда
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (buttonOnOff == false)
            {
                buttonOnOff = true;
                pictureBox3.Image = (Image)Stend_For_Step_7.Properties.Resources.SwitchON;
            }
            else
            {
                buttonOnOff = false;
                pictureBox3.Image = (Image)Stend_For_Step_7.Properties.Resources.SwitchOFF;
            }
        }

        // первая кнопка сверху задатчика
        private void buttonUpNumber1_Click(object sender, EventArgs e)
        {
            number1FromInputUnit = Add(number1FromInputUnit, number1);
            transferNumberFromIndicator();
        }

        // Увеличение цифры на 1 и отображение в индикаторе
        private Int32 Add (Int32 numberOfInputUnit, Label label)
        {
            if (numberOfInputUnit < 9)
                numberOfInputUnit = numberOfInputUnit + 1;
            else
                numberOfInputUnit = 0;
            label.Text = numberOfInputUnit.ToString();
            return numberOfInputUnit;
        }

        // Уменьшение цифры на 1 и отображение в индикаторе
        private Int32 Minus(Int32 numberOfInputUnit, Label label)
        {
            if (numberOfInputUnit > 0)
                numberOfInputUnit = numberOfInputUnit - 1;
            else
                numberOfInputUnit = 9;
            label.Text = numberOfInputUnit.ToString();
            return numberOfInputUnit;
        }


        // функция анимации кнопок с лампочками
        private void buttonWithLampView (Boolean button, Boolean lamp, PictureBox picture, Image pathToPopClolr, Image pathToPushColor)
        {
            if (button == false)
            {
                if (lamp == false)
                    picture.Image = (Image)Stend_For_Step_7.Properties.Resources.Green_Button_Poped;
                else
                    picture.Image = pathToPopClolr;
            }
            else
            {
                if (lamp == false)
                    picture.Image = (Image)Stend_For_Step_7.Properties.Resources.Gray_Button_Pushed;
                else
                    picture.Image = pathToPushColor;
            }
        }

        // загрузка окна
        private void StendStep7_Load(object sender, EventArgs e)
        {
            PS.Connect();
            //PS.SetState("RUN");
            //label_CPUState.Text = PS.GetState();
            PS.SetScanMode(S7PROSIMLib.ScanModeConstants.ContinuousScan);
            //label_Scan.Text = PS.GetScanMode().ToString();
            //PS.WriteInputPoint(17, 0, true);
            storeStartPositionOfPacket = packet.Location.X;
            // инициализация кнопок на имитаторе
            byte[] IW = new byte[2];
            IW[0] = 0;
            IW[1] = 0;
            PS.WriteInputImage(0, IW);
            firstLocationOfPicConveyer = ConveyerLine.Location.X;
            // датчик В4 при включении должен быть включен
            picSensor4.Image = (Image)Stend_For_Step_7.Properties.Resources.Red_LED_Light;
            PS.WriteInputPoint(16, 0, true);

            modeOfWorkSensorB4 = true;

        }

        // светодиоды контроллера
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Работа светодиодов
            if (PS.GetState() == "RUN" || PS.GetState() == "RUN_P")
                RUN.BackColor = Color.FromArgb(0, 192, 0);
            else
                RUN.BackColor = Color.FromArgb(192, 255, 192);

            if (PS.GetState() == "STOP")
                STOP.BackColor = Color.FromArgb(255, 128, 0);
            else
                STOP.BackColor = Color.FromArgb(255, 224, 192);

            if (PS.GetState() == "ERROR")
                SF.BackColor = Color.Red;
            else
                SF.BackColor = Color.FromArgb(255, 192, 192);

                DC5V.BackColor = Color.FromArgb(0, 192, 0);
        }


        // Переключатель S6
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Switch6 = switchering(Switch6, pictureBox1);
        }

        // Переключатель S9
        private void Switch09_Click(object sender, EventArgs e)
        {
            //Switch9 = switchering(Switch9, Switch09);
        }


        private void Switch09_MouseDown(object sender, MouseEventArgs e)
        {
            Switch9 = true;
            Switch09.Image = (Image)Stend_For_Step_7.Properties.Resources.Switch_knobs1;
        }


        private void Switch09_MouseUp(object sender, MouseEventArgs e)
        {
            Switch9 = false;
            Switch09.Image = (Image)Stend_For_Step_7.Properties.Resources.Switch_knobs0;
        }



        // Переключатель S7
        private void Switch07_Click(object sender, EventArgs e)
        {
            Switch7 = switchering(Switch7, Switch07);
        }
        
        // Работа переключателей в функции
        private Boolean switchering (Boolean numberOfSwitch, PictureBox picture)
        {
            if (numberOfSwitch == false)
            {
                numberOfSwitch = true;
                picture.Image = (Image)Stend_For_Step_7.Properties.Resources.Switch_knobs1;
            }
            else
            {
                numberOfSwitch = false;
                picture.Image = (Image)Stend_For_Step_7.Properties.Resources.Switch_knobs0;
            }
            return numberOfSwitch;
        }

    }
}
