using Mobilis.Lib.Model;
namespace Mobilis.Lib
{
    public class SmsManager
    {
        interface ManagerCallbacks 
        {
            /* Interface a ser implementada na view de posts para informar
             * o t�rmino de um bloco*/
            void endOfBlock();
        }

        private int blocks;
        private IAsyncPlayer player;

        public SmsManager(IAsyncPlayer player) 
        { 

        }

        public SmsManager() 
        {
            /* Para testar a chamada do Bing*/
        }
    
        public void start(Post post) 
        { 
            // separa em blocos e come�a as requisi��es
        }
      

        // public void separateBlocks()
        // public void makeRequests()
        // public void start()
    }
}