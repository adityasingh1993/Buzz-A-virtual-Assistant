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
using Banking.ChatBot;
using Android.Content.Res;
using System.Threading.Tasks;

namespace Banking.ActivityClass
{
    [Activity(Label = "Banking", MainLauncher = true, Icon = "@drawable/icon")]
    //[Activity(Label = "LoginActivity")]

    public class LoginActivity : Activity
    {
        private static Button LoginBtn;
        private static TextView wrongIdpassword;
        private static EditText useridet, passwordet;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LoginLayout);
            useridet = FindViewById<EditText>(Resource.Id.UserNameEt);
            wrongIdpassword = FindViewById<TextView>(Resource.Id.Wrong);
            passwordet = FindViewById<EditText>(Resource.Id.PasswordEt);
            LoginBtn = FindViewById<Button>(Resource.Id.Login);
            SetActivity.setActivity = this;
            SetActivity.setContext = Application.Context;
            LoginBtn.Click += (o, e) => {
                LoginPropClass.username = useridet.Text;
                LoginPropClass.password = passwordet.Text;
                if (LoginPropClass.username.ToLower().Equals("username") && LoginPropClass.password.ToLower().Equals("password"))
                {
                    AssetManager asset1 = this.Assets;
                    ChatBotClass chatbot = new ChatBotClass();
                    chatbot.ChatLoad(asset1);

                    SetBAnkingDetails.setName = "Aditya";
                    SetBAnkingDetails.setAccountnumber = "012345";
                    SetBAnkingDetails.setBalance = "10000";
                    ClassIntent.LoginMethod();

                }
                else if (LoginPropClass.username.ToLower().Equals("user1") && LoginPropClass.password.ToLower().Equals("pass123"))
                {
                    AssetManager asset1 = this.Assets;
                   // ChatBotClass chatbot = new ChatBotClass();
                 //  chatbot.ChatLoad(asset1);
                    SetBAnkingDetails.setName = "Sattam";
                    SetBAnkingDetails.setAccountnumber = "033345";
                    SetBAnkingDetails.setBalance = "30000";
                    ClassIntent.LoginMethod();
                }
                else {
                    wrongIdpassword.Text = "Wrong user Name or password";

                }

            };
            // Create your application here
        }

        
        protected override void OnStart()
        {
            base.OnStart();
        }


        protected override void OnPause()
        {
            base.OnPause();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnStop()
        {
            base.OnStop();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }
        protected override void OnRestart()
        {
            base.OnRestart();
        }
    }
}