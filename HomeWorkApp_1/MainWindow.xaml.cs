using HomeWorkApp.Source;
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

        public MainWindow()
        {
            InitializeComponent();

            _mathHelper = new MathHelper();

            View();
        }
        private void View()
        {
            var factorialTaskView = new FactorialTaskView(Task_1, _mathHelper);
            
            var fibonacciTaskView = new FibonacciView(Task_2, _mathHelper);

            var binaryCountOnesView = new BinaryCountOnesView(Task_3, _mathHelper);
        }
    }
}