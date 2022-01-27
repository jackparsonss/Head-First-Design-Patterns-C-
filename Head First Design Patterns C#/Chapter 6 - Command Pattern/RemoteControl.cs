namespace Head_First_Design_Patterns.Chapter_6___Command_Pattern
{
    public class RemoteControl
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;
        private int _remoteControlSize;

        public RemoteControl()
        {
            _onCommands = new ICommand[_remoteControlSize];
            _offCommands = new ICommand[_remoteControlSize];

            ICommand noCommand = new NoCommand();
            for(int i = 0; i < _remoteControlSize; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
        }
        
        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
        }
        
        public override string ToString()
        {
            var output = "";

            for (int i = 0; i < _remoteControlSize; i++)
            {
                output += $"[slot {i}] {_onCommands[i].GetType().Name}   {_offCommands[i].GetType().Name}\n";
            }

            return output;
        }
    }
}