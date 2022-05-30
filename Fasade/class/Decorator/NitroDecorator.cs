using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasade
{
    public class NitroDecorator : IEngine
    {
        private IEngine _engine;
        private Nitro _nitro;
        public NitroDecorator(IEngine engine, Nitro nitro)
        {
            _engine = engine;
            _nitro = nitro;
        }
        public void StartTheEngine()
        {
            _engine.StartTheEngine();
            _nitro.TurnOnNitro();
        }
    }
}
