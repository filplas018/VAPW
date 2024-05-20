using plass_elektroStanice;
using static System.Collections.Specialized.BitVector32;

namespace plass_vapw
{
    public partial class Form1 : Form
    {
        private ChargingStation station;
        private System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();

            station = new ChargingStation(initialChargeLevel: 0, maxChargeLevel: 100);
            var dialog = new Dialog();
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK && dialog.UseTimer)
            {
                //UpdateInfoLabel.Text = "Timer";

                Timer.Interval = 1000; // 1 sekunda
                Timer.Tick += Timer_Tick;
                Timer.Enabled = true;
            }
            else
            {
                //UpdateInfoLabel.Text = "Event";
                station.OnEntryLightStateChange += Station_OnEntryLightStateChange;
                station.OnExitLightStateChange += Station_OnExitLightStateChange;
                station.OnCarLocationStateChange += Station_OnCarLocationStateChange;
                station.OnChargeLevelChange += Station_OnChargeLevelChange;
            }


            // Simulace spuštìní procesu
            station.State = ChargingStation.StationState.Start;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // This event handler is empty because no specific initialization is needed
        }

        private void Station_OnEntryLightStateChange(object sender, ChargingStation.LightState e)
        {
            VykreslitStav();
        }

        private void Station_OnExitLightStateChange(object sender, ChargingStation.LightState e)
        {
            VykreslitStav();
        }

        private void Station_OnCarLocationStateChange(object sender, ChargingStation.CarLocation e)
        {
            VykreslitStav();
        }

        private void Station_OnChargeLevelChange(object sender, int e)
        {
            VykreslitStav();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            VykreslitStav();
        }

        private void VykreslitStav()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { UpdateUI(); });
            }
            else
            {
                UpdateUI();
            }
        }


        private void NormalButton_CheckedChanged(object sender, EventArgs e)
        {

            progressBar1.BackColor = Color.Yellow;
            
            station._chargingMode = ChargingStation.ChargingMode.Standard;
        }

        private void FastButton_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.BackColor = Color.Green;
            
            station._chargingMode = ChargingStation.ChargingMode.Fast;
        }

        private void SuperFastButton_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.BackColor = Color.Blue;
            
            station._chargingMode = ChargingStation.ChargingMode.SuperFast;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void UpdateUI()
        {
            // Update UI elements based on the station's state and properties
            textBox2.Text = station.State.ToString();

            switch (station.State)
            {
                case ChargingStation.StationState.Start:
                    panel1.BackColor = Color.Green;
                    pictureBox1.Location = new Point(800, 348);
                    break;
                case ChargingStation.StationState.CarArrived:
                    
                    pictureBox1.Location = new Point(520, 348);
                    break;
                case ChargingStation.StationState.CarInside:
                    panel1.BackColor = Color.Red;
                    pictureBox1.Location = new Point(240, 348);
                    break;
                case ChargingStation.StationState.Charging:
                    progressBar1.Value = station.ChargeLevel;
                    break;
                case ChargingStation.StationState.Finished:
                    panel1.BackColor = Color.Green;
                    pictureBox1.Location = new Point(10, 348);
                    break;
                case ChargingStation.StationState.CarLeaving:
                    panel1.BackColor = Color.Green;
                    pictureBox1.Location = new Point(-200, 348);
                    break;
                default:
                    panel1.BackColor = SystemColors.Control;
                    break;
            }

            // Update other UI elements as needed
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            switch (station.State)
            {
                case ChargingStation.StationState.Start:
                    station.State = ChargingStation.StationState.CarArrived;
                    break;
                case ChargingStation.StationState.CarArrived:
                    station.State = ChargingStation.StationState.CarInside;
                    break;
                case ChargingStation.StationState.CarInside:
                    station.State = ChargingStation.StationState.Charging;
                    break;
                case ChargingStation.StationState.Charging:
                    station.State = ChargingStation.StationState.Finished;
                    break;
                case ChargingStation.StationState.Finished:
                    station.State = ChargingStation.StationState.CarLeaving;
                    break;
                case ChargingStation.StationState.CarLeaving:
                    station.State = ChargingStation.StationState.Start;
                    break;
            }
            VykreslitStav();

        }
    }
}
