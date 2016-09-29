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
using Android.Util;

namespace Banking.VoiceActivity
{
   public class VoiceActivityForBenificiary
    {
        private static EditText BnfcrNameet, BnfcrAcntet;
        private static Button AddBnfcrBtn, InvsblBnfcrBtn;
        public static void FindComponent()
        {
            BnfcrNameet = SetActivity.setActivity.FindViewById<EditText>(Resource.Id.Nameedittext);
            BnfcrAcntet = SetActivity.setActivity.FindViewById<EditText>(Resource.Id.Acntnumeredittext);
            AddBnfcrBtn = SetActivity.setActivity.FindViewById<Button>(Resource.Id.AddBenfcrBtn);
            InvsblBnfcrBtn = SetActivity.setActivity.FindViewById<Button>(Resource.Id.InvisibleBnfcrBtn);

        }

        public static void SetUsernameAccountNumber()
        {
            BnfcrNameet.Text = AddBenificiaryClass.user;
            BnfcrAcntet.Text = AddBenificiaryClass.accountnumber;
            
            //SetActivity.setActivity.OnSaveInstanceState(SetBundle.stateOfActivity);
        }
        public static void AddBenfcrMethod()
        {
            string user = BnfcrNameet.Text;
            string acntnumber = BnfcrAcntet.Text;
            Log.Debug("user is", user);
            Log.Debug("account is", acntnumber);

        }



    }
}