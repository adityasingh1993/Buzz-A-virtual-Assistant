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
    [Activity(Label = "TransactionLayoutActivity")]
    public class TransactionLayoutActivity : Activity
    {
        private static Button backtrnsctbutton,invisibletnsctnbtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.TransactionLayout1);
            SetActivity.setActivity = this;
            SetActivity.setContext = Application.Context;
            backtrnsctbutton = FindViewById<Button>(Resource.Id.backtrnbutton1);
            invisibletnsctnbtn = FindViewById<Button>(Resource.Id.Invisibletrnbtn1);
            backtrnsctbutton.Click += (o, e) => { ClassIntent.AccountSummaryBack(); };
            invisibletnsctnbtn.Click += Invisibletnsctnbtn_Click;

            ArrayList ar = new ArrayList();
            ar.Add("To Go BAck Please say Back");
            // Create your application here
        }

        private void Invisibletnsctnbtn_Click(object sender, EventArgs e)
        {
            CallClass.Val = 1;
            ItteratorClass.iter = 1;
            TTSInitialize();
            //throw new NotImplementedException();
        }

        public async void TTSInitialize()
        {
            //for (int i = 0; i <= 3; i++)
            //{

            await Task.Run(() =>
            {
                // TextToSpeechProperty.Text = "Please Speak after beep";
                TextToSpeechProperty.Text = "In this You can see Your transaction details ";
                TTSClass ttsclass = new TTSClass();
                ttsclass.initialize();
                // this.Wait(10);
            });
            //}
        }
    }
}