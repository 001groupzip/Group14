using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WorkersLibrary;

namespace WorkersEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Worker> Workers { get; set; } 
        public MainWindow()
        {
            InitializeComponent();

            Workers = new ObservableCollection<Worker>();
            Workers.Add(new Manager("Manager1", 21, 161631, 10));
            Workers.Add(new Manager("Manager2", 27, 525732, 15));
            Workers.Add(new Manager("Manager3", 26, 752862, 20));
            Workers.Add(new Driver("Driver1", 45, 352133,"BMW", 256));
            Workers.Add(new Driver("Driver2", 32, 641534,"Audi", 144));

            DataContext = this;
        }

        private void workersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Worker worker = ((sender as ListBox).SelectedItem as Worker);
            if (worker != null)
            {
                detailsPanel.DataContext = worker;
                if (worker is Driver)
                {
                    managerInfo.Visibility = System.Windows.Visibility.Collapsed;
                    driverInfo.Visibility = System.Windows.Visibility.Visible;
                }
                if (worker is Manager)
                {
                    managerInfo.Visibility = System.Windows.Visibility.Visible;
                    driverInfo.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Worker delWorker = (workersList.SelectedItem as Worker);
            if (delWorker != null)
            {
                Workers.Remove(delWorker);
                workersList.SelectedIndex = 0;
            }
        }
    }
}
