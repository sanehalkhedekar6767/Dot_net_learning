using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    internal interface IPlayable
    {
        void Play();
    }

    class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing Video.....");
        }

    }

    class MusicPlayer: IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing Music....");
        }
    }


    internal interface AssignInterface
    {
        static void Main()
        {
            IPlayable vd = new VideoPlayer();
            vd.Play();
            IPlayable ms = new MusicPlayer();
            ms.Play();

        }
    }
}
