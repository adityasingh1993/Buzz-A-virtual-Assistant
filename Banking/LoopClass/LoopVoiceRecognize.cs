using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Speech;
using Android.Util;
using Banking.PropertyClass;
using Banking.FindingActivity;
using Banking.LoopClass;
using Banking.VoiceActivity;
namespace Banking.LoopClass
{
    public class LoopVoiceRecognize : Activity, IRecognitionListener
    {
        private SpeechRecognizer speechRecognizer = null;
        Intent Voiceintent;
        public string listen;
        Context context;
        public LoopVoiceRecognize(Context context1)
        {
            context1 = Application.Context;
            speechRecognizer = SpeechRecognizer.CreateSpeechRecognizer(context1);
            speechRecognizer.SetRecognitionListener(this);
            Log.Debug("Inside main", context1.ToString());
            Speak();

        }


        public void Speak()
        {
            //TextToSpeechClasses tc = new TextToSpeechClasses(SetActivity.setActivity);
            //tc.Dispose();

            try
            {
                Voiceintent = new Intent(RecognizerIntent.ActionRecognizeSpeech);
                //sc.BeginningOfSpeech;
                //     Toast.MakeText(this, "inside speak", ToastLength.Short).Show();
                //    var uri = Android.Net.Uri.Parse("http://www.xamarin.com");
                //  Intent myIntent = new Intent(Intent.ActionView, uri);
                //        Intent Voiceintent = new Intent(RecognizerIntent.ActionRecognizeSpeech);

                Voiceintent.PutExtra(RecognizerIntent.ExtraLanguage, RecognizerIntent.LanguageModelFreeForm);
                Log.Debug("Intent", "Intent created");
                Voiceintent.PutExtra(RecognizerIntent.ExtraPrompt, "Voice Regognition Demo");
                Voiceintent.PutExtra(RecognizerIntent.ExtraSpeechInputCompleteSilenceLengthMillis, 1500);
                Voiceintent.PutExtra(RecognizerIntent.ExtraSpeechInputPossiblyCompleteSilenceLengthMillis, 1500);
                Voiceintent.PutExtra(RecognizerIntent.ExtraSpeechInputMinimumLengthMillis, 1500);
                Voiceintent.PutExtra(RecognizerIntent.ExtraMaxResults, 5);
                Voiceintent.PutExtra(RecognizerIntent.ExtraLanguage, Java.Util.Locale.Uk);
                speechRecognizer.StartListening(Voiceintent);
                //    Toast.MakeText(this, "At Last", ToastLength.Short).Show();
                //SetResult(Result.Ok, Voiceintent);
                //  Toast.MakeText(this, mSpinner.SelectedItem.ToString(), ToastLength.Short).Show();
                //if (mSpinner.SelectedItem != null && mSpinner.SelectedItem.ToString()!="Default")
                //    Voiceintent.PutExtra(RecognizerIntent.ExtraLanguage, mSpinner.SelectedItem.ToString());
                // mc.StartActivityIfNeeded(Voiceintent, 1);
                //StartActivityForResult(Voiceintent, 1);

                // Toast.MakeText(this, "After Activity", ToastLength.Short).Show();
                //mc.StartActivityForResult(Voiceintent, 1);
                // RecognizerIntent ri = new RecognizerIntent();
                //    OnActivityResult(1, Result.Ok, Voiceintent);
                // Toast.MakeText(this.mc, "Inside voice class", ToastLength.Short).Show();
                // Toast.MakeText(this.mc, Voiceintent.ToArray<string>().ToString(),ToastLength.Long).Show();
                //var matches = Voiceintent.GetStringArrayListExtra(RecognizerIntent.ExtraResults);
                // Toast.MakeText(this, matches[0], ToastLength.Short).Show();
                //Toast.MakeText(this.mc, matches.ToString(), ToastLength.Short).Show();
                //if (matches.Count == 0)
                //{
                //    Toast.MakeText(this.mc, "Nodata", ToastLength.Short).Show();

                //}
                //else {

                //    Toast.MakeText(this.mc, "data" + matches[0], ToastLength.Short).Show();
                //}
            }

            catch (ActivityNotFoundException ae)
            {
                Log.Debug("Error occured", "Error");
                //Toast.MakeText(this, "Inide Catch", ToastLength.Short).Show();
                //Toast.MakeText(this, ae.ToString(), ToastLength.Long).Show();
                string s = "com.google.android.googlequicksearchbox";
                try
                {
                    var uri = Android.Net.Uri.Parse("market://details?id=" + s);
                    Intent it = new Intent(Intent.ActionView, uri);



                }
                catch (ActivityNotFoundException anfe)
                {
                    //  StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("https://play.google.com/store/apps/details?id=" + s)));
                }
            }

        }








        public void OnResults(Bundle results)
        {
            
            string user;
            // throw new NotImplementedException();
            Log.Debug("Inside Result", "Inside Result");
            IList<string> aaray = results.GetStringArrayList(SpeechRecognizer.ResultsRecognition);
            listen = aaray[0];
            //returnListen();
            VoiceRecognizationOutput.VoiceResult = listen;
            if (listen.Length > 0)
            {
                FindActivity fa = new FindActivity();
                fa.Findactivity();
                if (TextToSpeechProperty.Text.ToLower().Equals("please speak benificiary name"))
                {
                    AddBenificiaryClass.user = listen;
                    TextToSpeechProperty.Text = "please speak account number";
                    VoiceActivityForBenificiary.FindComponent();
                    VoiceActivityForBenificiary.SetUsernameAccountNumber();
                    LoopTTSClass tts = new LoopTTSClass();
                    tts.initialize();

                }
                else if (TextToSpeechProperty.Text.ToLower().Equals("please speak account number"))
                {
                    AddBenificiaryClass.accountnumber = listen;
                    TextToSpeechProperty.Text = "are you confirm say yes or no";
                    VoiceActivityForBenificiary.FindComponent();
                    VoiceActivityForBenificiary.SetUsernameAccountNumber();
                    LoopTTSClass tts = new LoopTTSClass();
                    tts.initialize();

                }
                else if (TextToSpeechProperty.Text.ToLower().Equals("are you confirm say yes or no"))
                {
                    if (listen.Equals("yes"))
                    {
                        VoiceActivityForBenificiary.FindComponent();
                        VoiceActivityForBenificiary.SetUsernameAccountNumber();
                        VoiceActivityForBenificiary.AddBenfcrMethod();
                        //start Adding Benificiary

                    }
                    if (listen.Equals("no"))
                    {
                        //go to previous activity

                    }



                }
            }
            else
            {

            }
            Log.Debug("Inside result", listen);
        }

        public void OnBeginningOfSpeech()
        {
            Log.Debug("Bc", "B OBC");
            //throw new NotImplementedException();
        }

        public void OnBufferReceived(byte[] buffer)
        {
            Log.Debug("Bc",buffer.ToString());

            //            throw new NotImplementedException();
        }

        public void OnEndOfSpeech()
        {
            Log.Debug("Bc", "OEC");

            //            throw new NotImplementedException();
        }

        public void OnError([GeneratedEnum] SpeechRecognizerError error)
        {
            Log.Debug("Bc", "ON ERROR");
            Log.Debug("Error is", error.ToString());

            //          throw new NotImplementedException();
        }

        public void OnEvent(int eventType, Bundle @params)
        {
            Log.Debug("Bc", "OEV");

            //  throw new NotImplementedException();
        }

        public void OnPartialResults(Bundle partialResults)
        {
            Log.Debug("Bc", "OPR");

            // throw new NotImplementedException();
        }

        public void OnReadyForSpeech(Bundle @params)
        {
            Log.Debug("Bc", "ORC");

            //  throw new NotImplementedException();
        }

        public void OnRmsChanged(float rmsdB)
        {
            Log.Debug("Bc", rmsdB.ToString());

            // throw new NotImplementedException();
        }
    }
}