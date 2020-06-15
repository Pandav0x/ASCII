using System.Collections.Generic;
using pulsee.engine.Events.Contracts;
using pulsee.engine.Utils;

namespace pulsee.engine.Events
{
    class EventManager
    {
        //try to use delegates
        private Dictionary<string, List<IEventListener>> listeners;

        public EventManager()
        {
            listeners = new Dictionary<string, List<IEventListener>>();
        }

        public void Initialize()
        {
            xConsole.WriteLine("Fetching event listeners", MessageType.Info);
            PopulateListeners();
            xConsole.WriteLine(string.Format("{0} event listeners found", listeners.Count), MessageType.Info);
        }

        private void PopulateListeners()
        {
            foreach (IEventListener eventListener in Reflexion.GetInstancesImplementing<IEventListener>())
            {
                for(int i = 0; i < eventListener.ListenedEvents().Length; i++){ 
                    Register(eventListener.ListenedEvents()[i], eventListener);
                }
            }
        }

        private void Register(string eventName, IEventListener listener)
        {
            if (listeners.ContainsKey(eventName)) {
                listeners[eventName].Add(listener);
                return;
            }

            listeners.Add(eventName, new List<IEventListener> { listener });
        }

        public void FireEvent(string eventName)
        {
            if (listeners.ContainsKey(eventName)) {
                foreach (IEventListener listener in listeners[eventName]) { 
                    listener.Notify();
                }
            }
        }
    }
}
