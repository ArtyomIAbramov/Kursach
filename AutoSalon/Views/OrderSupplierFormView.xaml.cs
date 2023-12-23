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
    /// Interaction logic for OrderSupplierFormView.xaml
    /// </summary>
    public partial class OrderSupplierFormView : Window
    {
        public OrderSupplierFormView(ICarService carService, IEmployeeService employeeService, ISupplierService supplierService, IOrderSupplierEmployeeService orderSupplierEmployeeService)
        {
            InitializeComponent();

            DataContext = new OrderViewModel(carService, employeeService, supplierService, orderSupplierEmployeeService);
        }
    }
}
