using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasade
{
    public class StartTheEngineFasade : IEngine
    {
        private KeyInIgnition _keyInIgnition;
        private StartTheCar _startTheCar;
        public StartTheEngineFasade(KeyInIgnition keyInIgnition,StartTheCar startTheCar)
        {
            _keyInIgnition = keyInIgnition;
            _startTheCar = startTheCar; 
        }
        public void StartTheEngine()
        {
            _keyInIgnition.TurnOnTheIgnition();
            _startTheCar.TurnOnTheIgnition();
            _startTheCar.ScanOfSystem();
            _startTheCar.TurnOnStarter();
            _startTheCar.CrankShaftInMotion();
            _startTheCar.CamShaftInMotion();
            _startTheCar.CylindersInMotion();
            _keyInIgnition.EngineStarted();
        }
    }
}
