using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;
using Banking.PropertyClass;
using Banking.TTS;
using Syn.Bot;
using Syn.Bot.Siml;
namespace Banking.ChatBot
{
  public  class ChatBotFun
    {
        public async void TTSInitialize()
        {
            //for (int i = 0; i <= 3; i++)
            //{

            await Task.Run(() =>
            {
                // TextToSpeechProperty.Text = "Please Speak after beep";
                TextToSpeechProperty.Text = "Hi, How can I help You " ;
                TTSClass ttsclass = new TTSClass();
                ttsclass.initialize();
                // this.Wait(10);
            });
            //}
        }

        public void chatMessage()
        {
            TTSInitialize();
            SimlBot chatbot = ChatBotClass.chatMessage();
            Console.WriteLine("Input is "+VoiceRecognizationOutput.VoiceResult);
        var result=    chatbot.Chat(VoiceRecognizationOutput.VoiceResult);
            Console.WriteLine("Result is "+result.ToString());

        }

    }
}