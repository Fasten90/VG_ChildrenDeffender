using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenDeffenderForm
{
    public static class Common
    {

        public static void PlaySound(String sound)
        {

            if (sound != null)        // TODO - külön függvénybe !!!!!!!!!!!!!!!!!!
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(sound);
                player.Play();
            }

        }



    }
}
