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


        private LightState _entryLightState = LightState.Green;

        public ChargingMode _chargingMode;
        public ChargingMode ChargeMode
        {
            get
            {
                return _chargingMode;
            }
            set
            {
                bool flag = value != _chargingMode;
                _chargingMode = value;

                switch (_chargingMode)
                {
                    case ChargingMode.Standard:
                        ChargeStep = 5;
                        break;
                    case ChargingMode.Fast:
                        ChargeStep = 10;
                        break;
                    case ChargingMode.SuperFast:
                        ChargeStep = 20;
                        break;
                    default:
                        ChargeStep = 5;
                        break;

                }
                if (flag)
                {
                    this.OnChargingModeChange?.Invoke(this, _chargingMode);
                }
            }
        }
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
        private int _maxChargeLevel;
        private int _chargeStep;
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

        public int MaxChargeLevel
        {
            get
            {
                return _maxChargeLevel;
            }
            private set
            {
                bool flag = value != _maxChargeLevel;
                _maxChargeLevel = value;
                if (flag)
                {
                    this.OnMaxChargeLevelChange?.Invoke(this, _chargeLevel);
                }
            }
        }
        public int ChargeStep
        {
            get
            {
                return _chargeStep;
            }
            private set
            {
                bool flag = value != _chargeStep;
                
                _chargeStep = value;
                if (flag)
                {
                    this.OnChargeStepChange?.Invoke(this, _chargeLevel);
                }
            }
        }
        public delegate void ChangedLightStateHandler(object sender, LightState LightState);
        public delegate void ChangedCarLocationStateHandler(object sender, CarLocation carLocationState);
        public delegate void ChangedChargingModeHandler(object sender, ChargingMode chargingMode);
        public delegate void ChangedChargeLevelHandler(object sender, int chargeLevel);
        public delegate void ChangedMaxChargeLevelHandler(object sender, int maxChargeLevel);
        public delegate void ChangedChargeStepHandler(object sender, int chargeStep);
        public event ChangedLightStateHandler OnEntryLightStateChange;
        public event ChangedLightStateHandler OnExitLightStateChange;
        public event ChangedCarLocationStateHandler OnCarLocationStateChange;
        public event ChangedChargeLevelHandler OnChargeLevelChange;
        public event ChangedMaxChargeLevelHandler OnMaxChargeLevelChange;
        public event ChangedChargeStepHandler OnChargeStepChange;
        public event ChangedChargingModeHandler OnChargingModeChange;

        public ChargingStation(int initialChargeLevel, int maxChargeLevel, ChargingMode Mode = ChargingMode.Standard)
        {
            State = StationState.Start;
            CarLocationState = CarLocation.InFront;
            _chargingMode = Mode;        
            _chargeLevel = initialChargeLevel;
            _maxChargeLevel = maxChargeLevel;
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
                        if(chargingStation.ChargeLevel <= chargingStation.MaxChargeLevel)
                        {
                            chargingStation.ChargeLevel += chargingStation.ChargeStep;
                            Thread.Sleep(1000); // Simulace nabíjení
                        }
                        
                        break;
                    case StationState.Finished:
                        chargingStation.ChargeLevel = 0;
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
