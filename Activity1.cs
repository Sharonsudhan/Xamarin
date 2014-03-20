using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AndroidApplication1
{
    [Activity(Label = "Hello World", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        Button buttonNext;
        Button buttonPrev;
        TextView textValue;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            buttonPrev=FindViewById<Button>(Resource.Id.buttonPrev);
            buttonNext=FindViewById<Button>(Resource.Id.buttonNext);
            textValue=FindViewById<TextView>(Resource.Id.textValue);

            buttonPrev.Click += buttonPrev_Click;
            buttonNext.Click += buttonNext_Click;
         }

        void buttonPrev_Click(object sender, EventArgs e)
        {
            textValue.Text = "Prev";
        }

        void buttonNext_Click(object sender, EventArgs e)
        {
           textValue.Text = "Next";
        }
    }
}

