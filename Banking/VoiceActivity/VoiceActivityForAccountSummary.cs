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
using Banking.VoiceActivity;
using Banking.VoiceRecognization;
using Banking.PropertyClass;
using Banking.IntentClass;
using Banking.TTS;
using System.Collections;

namespace Banking.VoiceActivity
{
   public class VoiceActivityForAccountSummary
    {
        public static void startfunctionAcntSummary()
        {
            string result = VoiceRecognizationOutput.VoiceResult;
            if (result.ToLower().Equals("transaction"))
            {
                ClassIntent.TransactionDetail();

            }
            else if (result.ToLower().Equals("Back"))
            {
                ClassIntent.AccountSummaryBack();

            }
           
            else
            {
                ArrayList ar = ClassForReading.arrayatble;
                TextToSpeechProperty.Text = "Please Say The Correct word";
                ItteratorClass.iter = ar.Count;
                TTSClass tts = new TTSClass();
                tts.initialize();


            }

        }
    }
    
}