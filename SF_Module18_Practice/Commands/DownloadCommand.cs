using System;
using System.Text;
using System.Threading.Tasks;

namespace SF_Module18_Practice.Commands
{
    class DownloadCommand : ICommand
    {
        Video video;

        public DownloadCommand(Video video)
        {
            this.video = video;
        }

        public async Task Execute()
        {
            video.Download();
        }
    }
}
