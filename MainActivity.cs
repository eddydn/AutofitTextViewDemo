using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Grantland.Widget;
using Android.Text;
using Java.Lang;
using System;

namespace AutofitTextViewDemo
{
    [Activity(Label = "AutofitTextViewDemo", MainLauncher = true, Icon = "@drawable/icon",Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity,ITextWatcher
    {

        AutofitTextView autoFitTextView;
        EditText editText;

        public void AfterTextChanged(IEditable s)
        {
            
        }

        public void BeforeTextChanged(ICharSequence s, int start, int count, int after)
        {
           
        }

        public void OnTextChanged(ICharSequence s, int start, int before, int count)
        {
            autoFitTextView.Text = s.ToString();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            autoFitTextView = FindViewById<AutofitTextView>(Resource.Id.txtView);
            editText = FindViewById<EditText>(Resource.Id.editText);

            editText.AddTextChangedListener(this);


        }
    }
}

