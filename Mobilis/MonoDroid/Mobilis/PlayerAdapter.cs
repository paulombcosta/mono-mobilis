using Mobilis.Lib;
using Android.Media;
using System.Threading;

namespace Mobilis
{
    public class PlayerAdapter : MediaPlayer,IAsyncPlayer
    {
        /*Implementa��o do player de posts na plataforma Android 
          
         * O player deve ter conhecimento do endere�o dos blocos a
         * serem tocados e tocar o pr�ximo bloco se j� tiver sido
         * baixado.
         * 
         * Os posts estar�o localizados na pasta Mobilis/TTS/:(id do post)
         * onde haver� um arquivo para cada bloco.
         * 
         * A pasta, juntamente com os arquivos da mesma, devem ser deletados
         * ao terminar de tocar um bloco.
         * 
         */
        //public void init()

        public override void Start()
        {
            base.Reset();
            ThreadPool.QueueUserWorkItem(state => 
            {
                base.Start();
            });
        }

        public void play() 
        {
            base.Start();
        }

        /*
        public void pause() 
        {
            base.Pause();
        }
        */
        public void stop() 
        {
            base.Stop();
        }
        public void previous() 
        { 
        }
        public void next() 
        { 
        }
    }
}