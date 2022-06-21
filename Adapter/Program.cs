namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mark", "head", "body", "hangs", "legs");
            Lizard lizard = new Lizard("Lizard", "have head", "have body", "have hangs", "have legs", "have tail");
            var controllerExperiment1 = new ControllerExperiment(lizard);
            controllerExperiment1.Info();

            var adapter = new PersonToLizardAdapter(person);
            var controllerExperiment2 = new ControllerExperiment(adapter);
            controllerExperiment2.Info();
        }
        public interface ILizard
        {
            public Lizard GetLizard();
        }
        public interface IPerson
        {
            public Person GetPerson();
        }
        public class Lizard : ILizard
        {
            private string _name;
            private string _head;
            private string _body;
            private string _hands;
            private string _legs;
            private string _tail;
            public string Name { get { return _name; } set { _name = value; } }
            public string Head { get { return _head; } set { _head = value; } }
            public string Body { get { return _body; } set { _body = value; } }
            public string Hangs { get { return _hands; } set { _hands = value; } }
            public string Legs { get { return _legs; } set { _legs = value; } }
            public string Tail { get { return _tail; } set { _tail = value; } }
            public Lizard() { }
            public Lizard(string name, string head, string body, string hands, string legs, string tail)
            {
                _name = name;
                _head = head;
                _body = body;
                _hands = hands;
                _legs = legs;
                _tail = tail;
            }

            public override string ToString()
            {
                return $"Lizard {_name} have {_head},{_body},{_hands},{_legs},{_tail}; ";
            }

            public Lizard GetLizard()
            {
                return this;
            }
        }
        public class Person : IPerson
        {
            private string _name;
            private string _head;
            private string _body;
            private string _hands;
            private string _legs;
            public Person() { }
            public string Name { get { return _name; } set { _name = value; } }
            public string Head { get { return _head; } set { _head = value; } }
            public string Body { get { return _body; } set { _body = value; } }
            public string Hangs { get { return _hands; } set { _hands = value; } }
            public string Legs { get { return _legs; } set { _legs = value; } }
            public Person(string name, string head, string body, string hands, string legs)
            {
                _name = name;
                _head = head;
                _body = body;
                _hands = hands;
                _legs = legs;
            }

            public override string ToString()
            {
                return $"Person {_name} have {_head},{_body},{_hands},{_legs}; ";
            }

            public Person GetPerson()
            {
                return this;
            }
        }
        public class ControllerExperiment
        {

            private ILizard _lizard { get; }

            public ControllerExperiment(ILizard lizard)
            {
                _lizard = lizard;
            }

            public void Info()
            {
                Console.WriteLine(_lizard.GetLizard().ToString());
            }
        }
        public class PersonToLizardAdapter : ILizard
        {
            private IPerson _person { get; }

            public PersonToLizardAdapter(IPerson person)
            {
                _person = person;
            }

            public Lizard GetLizard()
            {
                var experimental = _person.GetPerson();

                var lizard = new Lizard
                {
                    Name = experimental.Name,
                    Head = experimental.Head,
                    Body = experimental.Body,
                    Hangs = experimental.Hangs,
                    Legs = experimental.Legs,
                    Tail = "хвост"
                };
                return lizard;

            }
        }
    }

}