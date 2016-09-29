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

namespace Banking.ActivityClass
{
    [Activity(Label = "FundTransfer")]
    public class FundTransfer : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.FundTransfer);
            Button fndbckbtn = FindViewById<Button>(Resource.Id.fndbckbtn);
            Button addbnfcr = FindViewById<Button>(Resource.Id.AddBenfcrBtn);
            SetActivity.setActivity = this;
            SetActivity.setContext = Application.Context;
            fndbckbtn.Click += (o, e) =>
            {

                ClassIntent.MinLayoutback();
            };
            addbnfcr.Click += (o1, e1) =>
            {
                ClassIntent.AddBneificiaryMethod();

            };

            // Create your application here
        }
    }
}