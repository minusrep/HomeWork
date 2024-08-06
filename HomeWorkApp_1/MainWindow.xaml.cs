using HomeWorkApp.Source;
using HomeWorkApp.Source._Analytics;
using Microsoft.Win32;
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

namespace HomeWorkApp
{
    public partial class MainWindow : Window
    {
        private MathHelper _mathHelper;

        private Analytics _analytics;

        private AnalyticsView _analyticsView;

        public MainWindow()
        {
            InitializeComponent();

            _mathHelper = new MathHelper();

            _analytics = new Analytics();

            View();
        }
        private void View()
        {
            var factorialTaskView = new FactorialTaskView(Task_1, _mathHelper);
            
            var fibonacciTaskView = new FibonacciView(Task_2, _mathHelper);

            var binaryCountOnesView = new BinaryCountOnesView(Task_3, _mathHelper);

            var pallidromeView = new PallidromeView(Task_4, _mathHelper);

            _analyticsView = new AnalyticsView(Task_5, _analytics);
        }

        private void OnUploadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text files (*.txt) | *.txt";

            openFileDialog.InitialDirectory = @"C:\";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                // Здесь можно выполнить действия с выбранным файлом
                MessageBox.Show($"Выбран файл: {filePath}");

                _analyticsView.Update(filePath);
            }
        }
    }
}