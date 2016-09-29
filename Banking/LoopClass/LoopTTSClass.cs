using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using System.Timers;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Speech.Tts;
using Android.Util;
using Banking.PropertyClass;
using System.Threading.Tasks;
//using Java.Util;
using Banking.LoopClass;
using System.Collections;

namespace Banking.LoopClass
{
    public class LoopTTSClass : Java.Lang.Object, TextToSpeech.IOnInitListener
    {
        LoopUtteranceProgress upl;
        TextToSpeech tts;
        Intent ttsintent;
        ArrayList ar = new ArrayList();
        public void initialize()
        {

            tts = new TextToSpeech(SetActivity.setContext, this);

            Intent ttsintent = new Intent();
            ttsintent.SetAction(TextToSpeech.Engine.ActionCheckTtsData);
            ar = ClassForReading.arrayatble;
            //  var x= ttsintent.Flags ;
            //ttsintent.Wait(500);
        }


        public void OnInit([GeneratedEnum] OperationResult status)
        {
            try
            {
                //initialize();

                if (status.Equals(OperationResult.Success))
                {
                    //Speak();
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    dictionary.Add(TextToSpeech.Engine.KeyParamUtteranceId, "utteranceId");
                    upl = new LoopUtteranceProgress(this);
                    //  foreach (DictionaryEntry item in ht)
                    //{


                   // TextToSpeechProperty.Text = "Hi";
                    tts.Speak(TextToSpeechProperty.Text, QueueMode.Flush, dictionary);

                    var result = tts.SetOnUtteranceProgressListener(upl);
                    //  var result1 = tts.SetOnUtteranceCompletedListener(upl);
                }
                else
                {

                    Log.Debug("There is an error", "Error Found");
                }
                //throw new NotImplementedException();
            }
            catch (Exception ex)
            { Log.Debug("Exception is", ex.ToString()); }
        }


        public async void Speak()
        {
            await Task.Run(() =>
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                dictionary.Add(TextToSpeech.Engine.KeyParamUtteranceId, "utteranceId");
                upl = new LoopUtteranceProgress(this);


                tts.Speak(TextToSpeechProperty.Text, QueueMode.Flush, dictionary);
                var result = tts.SetOnUtteranceProgressListener(upl);
            });

        }

        protected override void Dispose(bool disposing)
        {
            if (tts != null)
            {
                tts.Shutdown();
                tts.Stop();
                tts.Dispose();
            }
            base.Dispose(disposing);
            Log.Debug("Disposing", "Disposed");
        }

    }
}