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
using Banking.LoopClass;
using Banking.PropertyClass;
namespace Banking.ActivityClass
{

    [Activity(Label = "Benificiary")]
    public class Benificiary : Activity
    {

        private EditText BnfcrNameet, BnfcrAcntet;
        private Button AddBnfcrBtn,InvsblBnfcrBtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Benificiary);
            BnfcrNameet = FindViewById<EditText>(Resource.Id.Nameedittext);
            BnfcrAcntet = FindViewById<EditText>(Resource.Id.Acntnumeredittext);
            AddBnfcrBtn = FindViewById<Button>(Resource.Id.AddBenfcrBtn);
            InvsblBnfcrBtn = FindViewById<Button>(Resource.Id.InvisibleBnfcrBtn);
            SetActivity.setActivity = this;
            SetActivity.setContext = Application.Context;
            SetBundle.stateOfActivity = savedInstanceState;
            InvsblBnfcrBtn.SetBackgroundColor(Android.Graphics.Color.Transparent);
            TextToSpeechProperty.Text = "In this, here you can add benificiary";
            InvsblBnfcrBtn.Click += (o, e) =>
              {
                  LoopTTSClass lts = new LoopTTSClass();
                  lts.initialize();

              };
            // Create your application here
        }
    }
}