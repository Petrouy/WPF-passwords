using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace WPF_hesla
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static string Jmeno;
        static string Heslo;

        private void Button_ClickSignin(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^(?=.*\d).{6,25}$");
         
            if (reg.IsMatch(tboxHesloSignin.Text))
            {
                Jmeno = tboxJmenoSignin.Text;
                Heslo = tboxHesloSignin.Text;
                MessageBox.Show("Registrace byla úspěšná", "Registrace", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Registrace nebyla úspěšná, zkontrolujte si zda heslo odpovídá pravidlům", "Registrace", MessageBoxButton.OK);
            }
        }

        private void Button_ClickLogin(object sender, EventArgs e)
        {
            if (tboxJmenoLogin.Text == Jmeno && tboxHesloLogin.Text == Heslo)
            {
                MessageBoxResult result;

                result = MessageBox.Show("Přihlášení bylo úspěšné", "Přihlášení", MessageBoxButton.OK);
                if (result == MessageBoxResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Přihlášení nebylo úspěšné, zkontrolujte si jméno a heslo", "Přihlášení", MessageBoxButton.OK);
            }
        }
    }
}
