using Android.Widget;
using Android.OS;
using System;
using SQLite.classes;
using System.IO;
using Android.App;
using Android;
using Android.Database;
using SQLitePCL;

namespace SQLite
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        EditText titleEditText, authorEditText;
        Button saveButton, show;
        TextView Datashow;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.main);
            titleEditText = FindViewById<EditText>(Resource.Id.titleEditText);
            authorEditText = FindViewById<EditText>(Resource.Id.authorEditText);
            saveButton = FindViewById<Button>(Resource.Id.saveButton);
            show = FindViewById<Button>(Resource.Id.showButton);
            Datashow = FindViewById<TextView>(Resource.Id.textView1);

            show.Click += Show_Click;
            saveButton.Click += SaveButton_Click;
        }

        private void Show_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs args)
        {
            string db_name = "books db. sqlite";
            string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string db_path = Path.Combine(folderPath, db_name);



            Book newBook = new Book()
            {
                Author = authorEditText.Text,
                Name = titleEditText.Text

            };

            if (Databasetelper.Insert(ref newBook, db_path))
                Console.WriteLine("SUCCESS");
            else
                Console.WriteLine("FAILURE");
        }
    }
}



