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
using Banking.IntentClass;
using System.Collections;
using Banking.TTS;

namespace Banking.VoiceActivity
{
   public class VoiceActivityForTransaction
    {
        public static void Transactiontoback()
        {
            string result = VoiceRecognizationOutput.VoiceResult;

            if (result.ToLower().Equals("Back"))
            {
                ClassIntent.AccountSummaryBack();

            }
            else {

                ArrayList ar = ClassForReading.arrayatble;
                TextToSpeechProperty.Text = "Please Say The Correct word";
                ItteratorClass.iter = ar.Count;
                TTSClass tts = new TTSClass();
                tts.initialize();
                }
        }
    }
}