using Android.App;
using Android.OS;
using Android.Widget;

namespace LV_Array
{
    [Activity(Label = "ListView Array", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //DECLARATIONS
        private ListView lv;
        private ArrayAdapter<string> adapter;
        private readonly string[] spacecrafts = { "Columbia", "Challenger", "Spitzer", "Kepler", "Casini", "Voyager", "Pioneer", "Enterprise", "Rosetter" };


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //REFERENCES
            lv = FindViewById<ListView>(Resource.Id.lv);

            //ADAPTER
            adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, spacecrafts);
            lv.Adapter = adapter;

            //ITEMC CLICKS
            lv.ItemClick += Lv_ItemClick;

        }

        private void Lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            //SHOW MSG
            Toast.MakeText(this, adapter.GetItem(e.Position), ToastLength.Short).Show();
        }
    }
}

