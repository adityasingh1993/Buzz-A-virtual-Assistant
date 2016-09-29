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
using Banking.PropertyClass;
using Banking.ActivityClass;
using Banking.TTS;
using Banking.IntentClass;
namespace Banking.VoiceActivity
{
   public class VoiceActivityForMain
    {
        private static Button AccntSummaryBtn;
        private static Button FundTransferBtn;
        private static Button CardDetailsBtn;
        string voiceResult=null;

        public static void findComponents(string VoiceResult1)
        {
           
            AccntSummaryBtn = SetActivity.setActivity.FindViewById<Button>(Resource.Id.btnAccSummary);
            FundTransferBtn = SetActivity.setActivity.FindViewById<Button>(Resource.Id.btnFundTrnsfr);
            CardDetailsBtn = SetActivity.setActivity.FindViewById<Button>(Resource.Id.btnFundTrnsfr);
        }

        public static void startFunction()
        {
            string result =VoiceRecognizationOutput.VoiceResult;
            if (result.ToLower().Equals("account summary"))
            {
                ClassIntent.AccountSummaryIntent();

            }
            else if (result.ToLower().Equals("transfer"))
            {
                ClassIntent.FundTransferIntent();

            }
            else if (result.ToLower().Equals("card details"))
            {

                ClassIntent.CardDetailsIntent();
              //  SetActivity.setActivity.OnSaveInstanceState();
                //Intent carddetailsintent = new Intent(SetActivity.setContext, typeof(CardDetails));
                //SetActivity.setActivity.StartActivity(carddetailsintent);

            }
            else {
                TextToSpeechProperty.Text = "Please Say The Correct word";
                ItteratorClass.iter = 3;
                TTSClass tts = new TTSClass();
                tts.initialize();


            }
        }


    }
}