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

            station = new ChargingStation(initialChargeLevel: 0);
            var dialog = new Dialog();
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK && dialog.UseTimer)
            {
                UpdateInfoLabel.Text = "Timer";

                Timer.Interval = 1000; // 1 sekunda
                Timer.Tick += Timer_Tick;
                Timer.Enabled = true;           
            }
            else
            {
                UpdateInfoLabel.Text = "Event";
                station.OnEntryLightStateChange += Station_OnEntryLightStateChange;
                station.OnExitLightStateChange += Station_OnExitLightStateChange;
                station.OnCarLocationStateChange += Station_OnCarLocationStateChange;
                station.OnChargeLevelChange += Station_OnChargeLevelChange;
            }

           
            // Simulace spuštìní procesu
            station.State = ChargingStation.StationState.CarArrived;
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
                Invoke((MethodInvoker)delegate
                {
                    // Update UI elements
                    labelStavStanice.Text = station.State.ToString();
                    labelVstupniSemafor.Text = station.EntryLightState.ToString();
                    labelVystupniSemafor.Text = station.ExitLightState.ToString();
                    labelCarLocation.Text = station.CarLocationState.ToString();
                    labelChargeLevel.Text = station.ChargeLevel.ToString();
                });
            }
            else
            {
                // Update UI elements
                labelStavStanice.Text = station.State.ToString();
                labelVstupniSemafor.Text = station.EntryLightState.ToString();
                labelVystupniSemafor.Text = station.ExitLightState.ToString();
                labelCarLocation.Text = station.CarLocationState.ToString();
                labelChargeLevel.Text = station.ChargeLevel.ToString();
            }
        }
    }
}
