using System;
using System.Text;
using System.Threading.Tasks;

namespace SF_Module18_Practice.Commands
{
    class GetInfoCommand : ICommand
    {
        Video video;

        public GetInfoCommand(Video video)
        {
            this.video = video;
        }

        public async Task Execute()
        {
            video.GetInfo();
        }
    }
}
