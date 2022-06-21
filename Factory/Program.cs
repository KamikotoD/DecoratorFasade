namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TechniqueFactory> techniqueFactories = new List<TechniqueFactory> { new KettleFactory(), new WashingMachineFactory() };
            var techniquePriceInfo = new StoreTechnique(techniqueFactories);
            techniquePriceInfo.Get();
            List<int> prise = techniquePriceInfo.Prise;
            foreach (var techniquePrice in prise)
            {
                Console.WriteLine(techniquePrice);
            }
        }
    }
    public abstract class Technique
    {
        public abstract string Name { get; }
        public abstract string Type { get; }
        public abstract int Price { get; }
    }
    public abstract class TechniqueFactory
    {
        public abstract Technique Create();
    }
    public class WashingMachineFactory : TechniqueFactory
    {
        public override Technique Create()
        {
            return new WashingMachine();
        }
    }
    public class KettleFactory : TechniqueFactory
    {
        public override Technique Create()
        {
            return new Kettle();
        }
    }
    public class Kettle : Technique
    {
        private string _name;
        private string _type;
        private int _price;
        public Kettle()
        {
            _name = "kety";
            _type = "kettle";
            _price = 1200;
        }
        public Kettle(string name, string type, int price)
        {
            _name = name;
            _type = type;
            _price = price;

        }
        public override string Name => _name;

        public override string Type => _type;

        public override int Price => _price;
    }
    public class WashingMachine : Technique
    {
        private string _name;
        private string _type;
        private int _price;
        public WashingMachine()
        {
            _name = "DontDirty";
            _type = "washing machine";
            _price = 7000;
        }
        public WashingMachine(string name, string type, int price)
        {
            _name = name;
            _type = type;
            _price = price;
        }
        public override string Name => _name;

        public override string Type => _type;

        public override int Price => _price;
    }
    public class StoreTechnique
    {
        private List<TechniqueFactory> _techniqueFactories;
        private List<int> _price = new List<int>();
        public List<int> Prise { get => _price; }
        public StoreTechnique(List<TechniqueFactory> techniqueFactories)
        {
            _techniqueFactories = techniqueFactories;
        }
        public void Get()
        {
            foreach (var techniqueFactory in _techniqueFactories)
            {
                var technique = techniqueFactory.Create();
                _price.Add(technique.Price);
            }
        }

    }


}