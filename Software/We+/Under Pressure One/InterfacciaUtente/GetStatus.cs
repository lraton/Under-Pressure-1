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
        public double Flux;
        public int Volt;
        public bool StateAir;
        public bool StatePistonUp;
        public bool AutomaticSelector;
        public bool StatePistonDown;


        public GetStatus()
        {
            StateDoor = true;
            StateInjector = false;
            StateStart = false;
            StateReset = false;
            StateEmergency = false;
            Flux = 0;
            Volt=0;
            StateAir = false;
            StatePistonUp = false;
            StatePistonDown = false;
            AutomaticSelector = false;
        }

    }
}
