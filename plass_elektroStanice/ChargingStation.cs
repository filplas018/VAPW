using System.Threading;

namespace plass_elektroStanice
{
    public class ChargingStation
    {
        public enum StationState
        {
            Start,
            CarArrived,
            CarInside,
            Charging,
            Finished,
            CarLeaving
        }

        public enum LightState
        {
            Green, // volno
            Red //zabráno
        }

        public enum ChargingMode
        {
            SuperFast,
            Fast,
            Standard,
        }

        public enum CarLocation
        {
            InFront,
            Inside,
            Charging,
            Outside,
            Away
        }

        private Thread _thread = new Thread(ThreadProcedure);
        public StationState State { get; set; }

        private LightState _lightState = LightState.Green;

        private LightState _entryLightState = LightState.Red;
        public LightState EntryLightState
        {
            get
            {
                return _entryLightState;
            }
            private set
            {
                bool flag = value != _entryLightState;
                _entryLightState = value;
                if (flag)
                {
                    this.OnEntryLightStateChange?.Invoke(this, _entryLightState);
                }
            }
        }

        private LightState _exitLightState = LightState.Red;
        public LightState ExitLightState
        {
            get
            {
                return _exitLightState;
            }
            private set
            {
                bool flag = value != _exitLightState;
                _exitLightState = value;
                if (flag)
                {
                    this.OnExitLightStateChange?.Invoke(this, _exitLightState);
                }
            }
        }

        private CarLocation _carLocationState;
        public CarLocation CarLocationState
        {
            get
            {
                return _carLocationState;
            }
            private set
            {
                bool flag = value != _carLocationState;
                _carLocationState = value;
                if (flag)
                {
                    this.OnCarLocationStateChange?.Invoke(this, _carLocationState);
                }
            }
        }

        private int _chargeLevel;
        public int ChargeLevel
        {
            get
            {
                return _chargeLevel;
            }
            private set
            {
                bool flag = value != _chargeLevel;
                _chargeLevel = value;
                if (flag)
                {
                    this.OnChargeLevelChange?.Invoke(this, _chargeLevel);
                }
            }
        }
        public delegate void ChangedLightStateHandler(object sender, LightState LightState);
        public delegate void ChangedCarLocationStateHandler(object sender, CarLocation carLocationState);
        public delegate void ChangedChargeLevelHandler(object sender, int chargeLevel);
        public event ChangedLightStateHandler OnEntryLightStateChange;
        public event ChangedLightStateHandler OnExitLightStateChange;
        public event ChangedCarLocationStateHandler OnCarLocationStateChange;
        public event ChangedChargeLevelHandler OnChargeLevelChange;

        public ChargingStation(int initialChargeLevel)
        {
            State = StationState.Start;
            CarLocationState = CarLocation.InFront;
            _chargeLevel = initialChargeLevel;
            _thread.Start(this);
        }
        private static void ThreadProcedure(object obj)
        {
            ChargingStation chargingStation = (ChargingStation)obj;
            while (true)
            {
                switch (chargingStation.State)
                {
                    case StationState.CarArrived:
                        chargingStation.EntryLightState = LightState.Green;
                        break;
                    case StationState.CarInside:
                        chargingStation.CarLocationState = CarLocation.Inside;
                        chargingStation.EntryLightState = LightState.Red;
                        break;
                    case StationState.Charging:
                        chargingStation.ChargeLevel++;
                        Thread.Sleep(1000); // Simulace nabíjení
                        break;
                    case StationState.Finished:
                        chargingStation.ExitLightState = LightState.Green;
                        break;
                    case StationState.CarLeaving:
                        chargingStation.CarLocationState = CarLocation.Outside;
                        chargingStation.ExitLightState = LightState.Red;
                        break;
                }
            }
        }

        public void Dispose()
        {
            try
            {
                _thread.Interrupt();
                _thread.Join();
            }
            catch (Exception)
            {
            }
        }

    }
}
