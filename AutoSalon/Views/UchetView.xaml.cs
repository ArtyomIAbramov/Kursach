using AutoSalon.Interface;
using AutoSalon.Services;
using AutoSalon.ViewModel;
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

namespace AutoSalon.Views
{
    /// <summary>
    /// Interaction logic for UchetView.xaml
    /// </summary>
    public partial class UchetView : Window
    {
        public UchetView(IOrderClientEmployeeService orderClientEmployeeService)
        {
            InitializeComponent();

            DataContext = new UchetViewModel(orderClientEmployeeService);
        }
    }
}
