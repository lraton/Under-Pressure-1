using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacciaUtente
{
   public class GetStatus
    {
        public bool StateDoor;
        public bool StateInjector;
        public bool StateStart;
        public bool StateReset;
        public bool StateEmergency;
        public double Flow;
        public int Volt;
        public bool StateAir;
        public bool StatePistonUp;
        public bool AutomaticSelector;
        public bool StatePistonDown;
        public bool led;
        public int openVolt;
        public double MaxFlow;
        public bool firstStart;

        public int autoVelocity;
        public double minValueFlow;
        public int minRamp;
        public int maxRamp;

        public bool EmergencyIsOpen;
        public bool ErrorDoor;

        public int successTest;
        public GetStatus()
        {
            StateDoor = true;
            StateInjector = false;
            StateStart = false;
            StateReset = false;
            StateEmergency = false;
            Flow = 0;
            Volt=0;
            StateAir = false;
            StatePistonUp = false;
            StatePistonDown = false;
            AutomaticSelector = false;
            firstStart = false;

            maxRamp = 12;
            minValueFlow = 1;
            autoVelocity = 250;

            openVolt = 0;
            MaxFlow = 0;
            led = false;

            EmergencyIsOpen = false;
            successTest = 0;
        }

    }
}
