using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syn.Bot;
using Syn.Bot.Siml;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Banking.VoiceRecognization;
using Banking.PropertyClass;
using System.Threading.Tasks;

using Banking.TTS;
using Banking.IntentClass;
//using Java.Util;
using System.Collections;
using Banking.ChatBot;
namespace Banking.ActivityClass
{

    [Activity(Label = "MAinLAyout")]
    public class MainLayout : Activity
    {
        private TextView usernametv;
        private Button Acntsumrybtn, fundtrnsferbtn, carddetailsbtn, Invisiblebtn,Backbtn;
        //public Hashtable ht;
        public ArrayList ar;
        VoiceRecognize voicerecognize = null;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainLayout);
           
            //ForDemo();
            SetActivity.setActivity = this;
            SetActivity.setContext = Application.Context;
            SetBundle.stateOfActivity = savedInstanceState;
            usernametv = FindViewById<TextView>(Resource.Id.tvUsername);
            Invisiblebtn = FindViewById<Button>(Resource.Id.Invisible);
            Acntsumrybtn = FindViewById<Button>(Resource.Id.btnAccSummary);
            fundtrnsferbtn = FindViewById<Button>(Resource.Id.btnFundTrnsfr);
            Backbtn = FindViewById<Button>(Resource.Id.BackbtnMain);
            Invisiblebtn.SetBackgroundColor(Android.Graphics.Color.Transparent);
            carddetailsbtn = FindViewById<Button>(Resource.Id.btnCardDetails);
            usernametv.Text = SetBAnkingDetails.setName;
           Backbtn.Click += (o, e) => { ClassIntent.LoginBack();
               this.Finish();// Finish();
           };
             //   StartActivity(intu);
                Acntsumrybtn.Click += (o1, e1) => { ClassIntent.AccountSummaryIntent(); };
                fundtrnsferbtn.Click += (o2, e2) => { ClassIntent.FundTransferIntent(); };
                carddetailsbtn.Click += (o3, e3) => { ClassIntent.CardDetailsIntent(); };

                Invisiblebtn.Click += (o4, e4) => {
                    ChatBotFun chatbot = new ChatBotFun();
                    chatbot.chatMessage();
                Toast.MakeText(this, "Speech Mode is Activated", ToastLength.Short).Show();
            };
            
            ar = new ArrayList();
            
            
            ar.Add("To Go To card Details Please say Card details");
            ar.Add("To Go To Fund Transfer Please say Fund Transfer");
            ar.Add("To Go To Account Summary Please say Account Summary");
            //ar.Add("Hi " + usernametv.Text);

            //ht.Add(1,Acntsumrybtn.Text);
            //ht.Add(2, fundtrnsferbtn.Text);
            //ht.Add(3, carddetailsbtn.Text);
            ClassForReading.arrayatble = ar;
            ItteratorClass.iter = 2;
            CallClass.Val = 3;
            // Create your application here
        }

        public async void LoadSiml()
        {

            SimlBot siml = new SimlBot();

        }


        public async void TTSInitialize() {
            //for (int i = 0; i <= 3; i++)
            //{
            
                await Task.Run(() =>
                {
                    // TextToSpeechProperty.Text = "Please Speak after beep";
                    TextToSpeechProperty.Text = "Hi "+usernametv.Text;
                    TTSClass ttsclass = new TTSClass();
                    ttsclass.initialize();
                   // this.Wait(10);
                });
            //}
        }
        protected override void OnStart()
        {
           // TTSInitialize();
            base.OnStart();
 
        }






    }
}