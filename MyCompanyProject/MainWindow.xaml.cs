using MyCompanyProject.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyCompanyProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          if(string.IsNullOrWhiteSpace(txt_pass.Text))
                {
                MessageBox.Show("Enter User Password");
                return;
            }
            //var pass = txt_pass.Text.Trim();
            //if(!pass.All(char.IsDigit))
            //{
            //    MessageBox.Show("Please Enter User Password Digit");
            //    return;
            //}
            using (var db=new MyDbcontext())
            {
                //     var result = db.Admin.FirstOrDefault(t => t.AdminPassword==txt_pass.Text&&t.AdminName==txt_name.Text);
                var result = db.Admin.FirstOrDefault(t => t.AdminPassword==txt_pass.Text&&t.AdminName==txt_name.Text);
                if(result != null)
                {
                    AdminPage adminPage = new AdminPage();
                    adminPage.Show();

                }
                else
                {
                    MessageBox.Show("Admin Not Found");
                }
            }
        }
    }
}