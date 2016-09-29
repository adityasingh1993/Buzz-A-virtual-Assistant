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


namespace Banking.IntentClass
{
   public class ClassIntent
    {
        public static void LoginMethod()
        {
            Type t = SetActivity.setActivity.GetType();
            Intent Mainlayoutintent = new Intent(SetActivity.setContext, typeof(MainLayout));
            SetActivity.setActivity.StartActivity(Mainlayoutintent);
        }
        public static void AccountSummaryIntent()
        {
            Type t = SetActivity.setActivity.GetType();
            Intent accountsumrintent = new Intent(SetActivity.setContext,typeof(AccountSummary));
            SetActivity.setActivity.StartActivity(accountsumrintent);

        }
        public static void FundTransferIntent()
        {
            Type t = SetActivity.setActivity.GetType();
            Intent fundtrnsfrintent = new Intent(SetActivity.setContext, typeof(FundTransfer));
            SetActivity.setActivity.StartActivity(fundtrnsfrintent);

        }

        public static void CardDetailsIntent()
        {
            Type t = SetActivity.setActivity.GetType();
            Intent carddetailsintent = new Intent(SetActivity.setContext, typeof(CardDetails));
            SetActivity.setActivity.StartActivity(carddetailsintent);

        }
        
        public static void LoginBack()
        {
            Type t = SetActivity.setActivity.GetType();
            Intent loginbackintent = new Intent(SetActivity.setContext, typeof(LoginActivity));
            SetActivity.setActivity.StartActivity(loginbackintent);

        }

        public static void MinLayoutback()
        {
            Type t = SetActivity.setActivity.GetType();
            Intent mainlayout = new Intent(SetActivity.setContext,typeof(MainLayout));
            SetActivity.setActivity.StartActivity(mainlayout);

        }

        public static void AccountSummaryBack()
        {
            Type t = SetActivity.setActivity.GetType();
            Intent AccntSummarylayout = new Intent(SetActivity.setContext, typeof(AccountSummary));
            SetActivity.setActivity.StartActivity(AccntSummarylayout);



        }

        public static void fundTransferBack()
        {
            Type t = SetActivity.setActivity.GetType();
            Intent fundtransferbck = new Intent(SetActivity.setContext,typeof(FundTransfer));
            SetActivity.setActivity.StartActivity(fundtransferbck);

        }

        public static void cardDetails()
        {
            Type t = SetActivity.setActivity.GetType();
            Intent carddetailsbck = new Intent(SetActivity.setContext, typeof(FundTransfer));
            SetActivity.setActivity.StartActivity(carddetailsbck);
            
        }

        public static void TransactionDetail()
        {
            Type t = SetActivity.setActivity.GetType();
            Intent transactiondetailsintent = new Intent(SetActivity.setContext, typeof(TransactionLayoutActivity));
            SetActivity.setActivity.StartActivity(transactiondetailsintent);

        }

        public static void AddBneificiaryMethod()
        {
            Type t = SetActivity.setActivity.GetType();
            Intent addbnfcrintent = new Intent(SetActivity.setContext, typeof(Benificiary));
            SetActivity.setActivity.StartActivity(addbnfcrintent);

        }


        public static void CreditAnddebitBack()
        {
            Type t = SetActivity.setActivity.GetType();
            Intent creditanddebitback = new Intent(SetActivity.setContext, typeof(CreditAndDebitCard));

            SetActivity.setActivity.StartActivity(creditanddebitback);



        }


    }
}