using Microsoft.EntityFrameworkCore;
using MyCompanyProject.Data;
using MyCompanyProject.Models;
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
using System.Windows.Shapes;

namespace MyCompanyProject
{
    /// <summary>
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        public AdminPage()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            MessageBox.Show("hello");
            using (var db=new MyDbcontext())
            {
                var ShoeDate = db.Department
                     .Include(t => t.Car)
                     .Include(t => t.Employee)
                     .Select(w=>new
                     {
                  Department__Iff=  w.Department_ID,
                  Department__nameff=  w.Department_Name,               
                  Car__nameff=  w.Car.Car_Name,
                  Employee__nameff=  w.Employee.Employee_Name,          
                     }).ToList();
                data.ItemsSource=ShoeDate;  

            }
        }
    }
}
