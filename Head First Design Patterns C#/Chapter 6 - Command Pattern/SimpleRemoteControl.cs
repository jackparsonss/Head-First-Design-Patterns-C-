namespace Head_First_Design_Patterns.Chapter_6___Command_Pattern
{
    public class SimpleRemoteControl
    {
        private ICommand _slot;

        public SimpleRemoteControl() { }

        public void SetCommand(ICommand command)
        {
            _slot = command;
        }

        public void ButtonWasPressed()
        {
            _slot.Execute();
        }
    }
}