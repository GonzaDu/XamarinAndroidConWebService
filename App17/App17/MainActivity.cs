using Android.App;
using Android.Widget;
using Android.OS;
using Android;

namespace App17
{
    [Activity(Label = "App17", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            

            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            com.somee.pruebaserviciowen.WebServiceGonza servicio = new com.somee.pruebaserviciowen.WebServiceGonza();
            var nombre = FindViewById<EditText>(Resource.Id.textView1);
            var apellido = FindViewById<EditText>(Resource.Id.textView2);

            servicio.InsertarUsuario(nombre.Text, apellido.Text, "bosta");
        }
    }
}

