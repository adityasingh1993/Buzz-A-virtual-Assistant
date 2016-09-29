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
using Banking.VoiceActivity;

namespace Banking.FindingActivity
{
  public  class FindActivity
    {
        public void Findactivity()
        {
            Type t = SetActivity.setActivity.GetType();
            if (t.Equals(typeof(MainLayout)))
            {
                //VoiceActivityForMain mainlayout = new VoiceActivityForMain();
                ///mainlayout.
                ///
                VoiceActivityForMain.findComponents(VoiceRecognizationOutput.VoiceResult);
                VoiceActivityForMain.startFunction();

            }
            else if (t.Equals(typeof(CardDetails)))
            {


            }

            else if (t.Equals(typeof(FundTransfer)))
            {

            }

            else if (t.Equals(typeof(AccountSummary)))
            {
                VoiceActivityForAccountSummary.startfunctionAcntSummary();
            }
            else if (t.Equals(typeof(Benificiary)))
            {


            }
            else if (t.Equals(typeof(TransactionLayoutActivity)))
            {
                VoiceActivityForTransaction.Transactiontoback();
            }
        }

    }
}