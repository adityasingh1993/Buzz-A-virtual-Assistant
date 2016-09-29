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
using Syn.Bot;
using Syn.Bot.Siml;
using Android.Content.Res;
using System.IO;
using Banking.PropertyClass;
namespace Banking.ChatBot
{
  public  class ChatBotClass
    {
       private static  SimlBot chatbot=new SimlBot();
        public async void ChatLoad(AssetManager assets1)
        {

            // chatbot = new SimlBot();


            // string content="";
            AssetManager assets =assets1 ;
            using (StreamReader sr = new StreamReader(assets.Open("Buzz.simlpk")))
            {

           KnowledgeClass.knowledge     = sr.ReadToEnd();
            }
            chatbot.PackageManager.LoadFromString(KnowledgeClass.knowledge);

        }


        public static SimlBot chatMessage()
        {
            
            return chatbot;

        }



    }
}