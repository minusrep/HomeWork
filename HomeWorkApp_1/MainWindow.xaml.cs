using HomeWorkApp.Source;
using HomeWorkApp.Source._Analytics;
using HomeWorkApp.Source.View;
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

        private MathFunction _mathFunction;

        private Analytics _analytics;

        private ArrayHandler _arrayHandler;

        private AnalyticsView _analyticsView;

        public MainWindow()
        {
            InitializeComponent();

            _mathHelper = new MathHelper();

            _mathFunction = new MathFunction();

            _analytics = new Analytics();

            _arrayHandler = new ArrayHandler();

            View();
        }
        private void View()
        {
            var factorialTaskView = new FactorialTaskView(Task_1, _mathHelper);
            
            var fibonacciTaskView = new FibonacciView(Task_2, _mathHelper);

            var binaryCountOnesView = new BinaryCountOnesView(Task_3, _mathHelper);

            var pallidromeView = new PallidromeView(Task_4, _mathHelper);

            _analyticsView = new AnalyticsView(Task_5, _analytics);

            var maxView = new MaxView(Task_6, _arrayHandler);

            var rotateInverseView = new RotateInverseView(Task_7, _arrayHandler);

            var sortByEvenView = new SortByEvenView(Task_8, _arrayHandler);

            var addView = new AddView(Task_9, _arrayHandler);

            var bubbleSortView = new BubbleSortView(Task_10, _mathFunction);

            var selectionSortView = new SelectionSortView(Task_11, _mathFunction);

            var recursiveSum = new RecursiveSumView(Task_12, _mathFunction);

            var recursiveEvenSum = new RecursiveEvenSumView(Task_13, _mathFunction);

            var recursiveMax = new RecursiveMaxView(Task_14, _mathFunction);

            var reverseView = new ReverseView(Task_15, _mathFunction);

            var isPallidromeView = new IsPallidromeView(Task_16, _mathFunction);

            var isFibonnaci = new IsFibonacciView(Task_17, _mathFunction);

            var digitsSum = new DigitsSumView(Task_18, _mathFunction);
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