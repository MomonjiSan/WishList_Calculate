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

namespace Calculator
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
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double receipts, expenses, itemprice, DateCalculate;

            receipts = Convert.ToInt32(Receipts.Text);
            expenses = Convert.ToInt32(Expenses.Text);
            itemprice = Convert.ToInt32(ItemPrice.Text);
            if(receipts > expenses)
            {
                DateCalculate = itemprice / (receipts - expenses);
                DayUse.Text = DateCalculate.ToString();
            }
            else if(receipts < expenses)
            {
                MessageBox.Show("Are you kidding me?");
            }
            else if(receipts == expenses)
            {
                MessageBox.Show("Find a seccond jobs.");
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Receipts.Text = "";
            Expenses.Text = "";
            ItemPrice.Text = "";
            DayUse.Text = "";
        }
    }
}
