using Fasade;
#region Fasade
//KeyInIgnition keyInIgnition = new KeyInIgnition();
//StartTheCar startTheCar = new StartTheCar();
//StartTheEngineFasade startTheEngineFasade = new StartTheEngineFasade(keyInIgnition, startTheCar);
//startTheEngineFasade.StartTheEngine();
#endregion
#region Decorator
var keyInIgnition = new KeyInIgnition();
var startTheCar = new StartTheCar();

var startTheEngineFasade = new StartTheEngineFasade(keyInIgnition, startTheCar);

var speedChange = new FirstTransmission();
var switchingDecorator = new SpeedSwitchingDecorator(startTheEngineFasade, speedChange);
//switchingDecorator.StartTheEngine();
var nitro = new Nitro();
var nitroDecorator = new NitroDecorator(switchingDecorator, nitro);
nitroDecorator.StartTheEngine();

#endregion