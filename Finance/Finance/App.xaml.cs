using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using Finance.Data;
using System.IO;

namespace Finance
{
    public partial class App : Application
    {
        static FinanceDB financeDB;

        public static FinanceDB FinanceDB
        {
            get
            {
                if(financeDB == null)
                {
                    financeDB = new FinanceDB(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "FinanceDatabase.db2"));
                }
                return financeDB;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }  

        protected override void OnResume()
        {
        }
    }
}
