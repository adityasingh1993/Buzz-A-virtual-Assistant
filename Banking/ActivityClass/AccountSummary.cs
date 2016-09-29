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
using Banking.IntentClass;
using Banking.PropertyClass;
using System.Threading.Tasks;
using Banking.TTS;
using System.Collections;

namespace Banking.ActivityClass
{
    [Activity(Label = "AccountSummary")]
    public class AccountSummary : Activity
    {
        private TextView AccntNumbertv, Accntdetailstv;
        private Button backbtn,InvisibleAcntsumrybtn,transactiondetailsbtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AccountSummary);
            SetActivity.setActivity = this;
            SetActivity.setContext = Application.Context;
            backbtn = FindViewById<Button>(Resource.Id.BackbtnAcntSumry1);
            InvisibleAcntsumrybtn = FindViewById<Button>(Resource.Id.InvisibleAcntSumry1);
            transactiondetailsbtn = FindViewById<Button>(Resource.Id.transactionDetails1);
            AccntNumbertv = FindViewById<TextView>(Resource.Id.AccntNumbertv);
            Accntdetailstv = FindViewById<TextView>(Resource.Id.AccountDetailstv);
            InvisibleAcntsumrybtn.Click += (o1, e1) => { TTSInitialize(); };
            AccntNumbertv.Text = SetBAnkingDetails.setAccountnumber;
            Accntdetailstv.Text = SetBAnkingDetails.setBalance;

            ArrayList ar = new ArrayList();
            ar.Add("To Go Back Please Say Back");
            ar.Add("To Go to Transaction say Transaction Details");
            ar.Add("Account Balance"+Accntdetailstv.Text);
            ar.Add("Your account Number is" + AccntNumbertv.Text);
            backbtn.Click += (o, e) => {
                ClassIntent.MinLayoutback();
                this.Finish();           
        };
            ClassForReading.arrayatble = ar;
            CallClass.Val = 4;
            ItteratorClass.iter = 3;
            transactiondetailsbtn.Click += (o1, e1) =>
            {
                ClassIntent.TransactionDetail();

            };
        // Create your application here
    }


        public async void TTSInitialize()
        {
            //for (int i = 0; i <= 3; i++)
            //{

            await Task.Run(() =>
            {
                // TextToSpeechProperty.Text = "Please Speak after beep";
                TextToSpeechProperty.Text = "Please Speak After The Beep ";
                TTSClass ttsclass = new TTSClass();
                ttsclass.initialize();
                // this.Wait(10);
            });
            //}
        }

    }
}