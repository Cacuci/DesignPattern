using System;

namespace DesignPattern_3_Behavioral_3_3_Observer {
    public class Observer : IObserver {
        public Observer (string name, Subject subject) {
            Name = name;
            _subjetc = subject;
        }
        private readonly Subject _subjetc;

        public Observer (string name) {
            this.Name = name;

        }
        public string Name { get; set; }

        public void Update (Subject subject) {
            if (subject == _subjetc) {
                Console.WriteLine ("{0} - Editora alterou o seu estado para: {1} ", Name, subject.GetEdition ());
            }
        }
    }
}