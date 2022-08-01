using System;
using System.Text;

namespace SF_Module18_Practice
{
    public class YoutubeMaster
    {
        ICommand _command;

        public void SetCommand(ICommand command) => _command = command;

        public void Execute()
        {
            _command.Execute();
        }
    }
}
