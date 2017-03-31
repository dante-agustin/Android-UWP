using Android.App;
using Android.Widget;
using Android.OS;

namespace CapturePhotoAndroid
{
    [Activity(Label = "CapturePhotoAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Cambiar si es un edit
            this.Title = "Agregar trago";

            /*
            Spinner spinnerCategoria = FindViewById<Spinner>()

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem) {

            @Override
            public View getView(int position, View convertView, ViewGroup parent)
        {

            View v = super.getView(position, convertView, parent);
            if (position == getCount())
            {
                ((TextView)v.findViewById(android.R.id.text1)).setText("");
                ((TextView)v.findViewById(android.R.id.text1)).setHint(getItem(getCount())); //"Hint to be displayed"
            }

            return v;
        }

        
            public int getCount()
        {
            return super.getCount() - 1; // you dont display last item. It is used as hint.
        }

    };

        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            adapter.add("Daily");
            adapter.add("Two Days");
            adapter.add("Weekly");
            adapter.add("Monthly");
            adapter.add("Three Months");
            adapter.add("HINT_TEXT_HERE"); //This is the text that will be displayed as hint.


            spinner.setAdapter(adapter);
            spinner.setSelection(adapter.getCount()); //set the hint the default selection so it appears on launch.
            spinner.setOnItemSelectedListener(this);
        */
        }

    }
}

