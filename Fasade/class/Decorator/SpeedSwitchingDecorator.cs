using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasade
{
    public class SpeedSwitchingDecorator : IEngine
    {
        private IEngine _engine;
        private ITransmission _speedChange;
        public SpeedSwitchingDecorator(IEngine engine, ITransmission speedChange)
        {
            _engine = engine;
            _speedChange = speedChange; 
        }
        public void StartTheEngine()
        {
            _engine.StartTheEngine();
            _speedChange.SpeedSwitching();
        }
    }
}
