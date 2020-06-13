namespace pulsee.engine.Events.Contracts
{
    interface IEventListener
    {
        string[] ListenedEvents();

        //TODO - rajouter des eventArgs
        void Notify();
    }
}
