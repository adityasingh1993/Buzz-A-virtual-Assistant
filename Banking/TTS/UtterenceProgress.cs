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
using Android.Util;
using Android.Speech.Tts;
using Banking.PropertyClass;
using System.Collections;
using Banking.VoiceRecognization;
using Banking.PropertyClass;
namespace Banking.TTS
{
    public class UtteranceProgress : UtteranceProgressListener
    {
        private ArrayList ar;
        TTSClass textToSpeechClass;
        Activity Acv = SetActivity.setActivity;
        Activity Acv1;
        public UtteranceProgress(TTSClass textToSpeechClassees)
        {
            this.textToSpeechClass = textToSpeechClassees;
        }

        //public UtteranceProgress(TTSClass textToSpeechClassees, Activity acv)
        //{

        //    Acv1 = acv; 
        //    this.textToSpeechClass = textToSpeechClassees;
        //    //this.textToSpeechClass = textToSpeechClass;
        //}
        ////VoiceRecognizerClass vrc;

        //        VoiceRecognizerClass vc;
        //      IntentClass ic;
        public override void OnDone(string utteranceId)
        {
          //  ArrayList ar = new ArrayList();
            ar = ClassForReading.arrayatble;

            //   Hashtable ht ;
            Log.Debug("Count",ar.Count.ToString());
            Log.Debug("Utterence Completed", "Completion Of Utterence");
            if (CallClass.Val > 0)
            {
                TextToSpeechProperty.Text = ar[ItteratorClass.iter].ToString();
                ItteratorClass.iter = ItteratorClass.iter - 1;
                CallClass.Val = CallClass.Val - 1;
                TTSClass tts = new TTSClass();
                tts.initialize();
                   
                
                
            }

            else
            {

                Acv.RunOnUiThread(() =>
                {
                    VoiceRecognize vr = new VoiceRecognize(SetActivity.setContext);

                });
                // TextToSpeech.Engine.ActionCheckTtsData;
                // SecondActivity sc = new SecondActivity();

                //ChildVoiceRecognizer cvr = new ChildVoiceRecognizer();
            }
        }

        public override void OnError(string utteranceId)
        {
            Log.Debug("on Utterance Start", "Utterance Error");
            // throw new NotImplementedException();
        }

        public override void OnStart(string utteranceId)
        {
            Log.Debug("on Utterance Start", "Utterance Start");
            //throw new NotImplementedException();
        }
    }

}