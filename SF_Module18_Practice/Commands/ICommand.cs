using System;
using System.Text;
using System.Threading.Tasks;

namespace SF_Module18_Practice
{
    public interface ICommand
    {
        public Task Execute();
    }
}
