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
using Banking.LoopClass;

namespace Banking.LoopClass
{
    public class LoopUtteranceProgress : UtteranceProgressListener
    {

        LoopTTSClass textToSpeechClass;
        Activity Acv = SetActivity.setActivity;
        Activity Acv1;
        public LoopUtteranceProgress(LoopTTSClass textToSpeechClassees)
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

            Log.Debug("Utterence Completed", "Completion Of Utterence");

            if (TextToSpeechProperty.Text.Equals("In this, here you can add benificiary"))
            {
                TextToSpeechProperty.Text = "please speak benificiary name";
                LoopTTSClass tts = new LoopTTSClass();
                tts.initialize();

            }
            else
            {
                Acv.RunOnUiThread(() =>
                {
                    LoopVoiceRecognize vr = new LoopVoiceRecognize(SetActivity.setContext);

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