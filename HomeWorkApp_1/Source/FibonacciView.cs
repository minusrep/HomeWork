using System.Windows.Controls;

namespace HomeWorkApp.Source
{
    public class FibonacciView : TaskView
    {
        public override string OperationPrefix => "Fibonacci";

        private MathHelper _mathHelper;

        public FibonacciView(StackPanel stackPanel, MathHelper mathHelper) : base(stackPanel) 
            => _mathHelper = mathHelper;


        protected override void OnInputChange(object sender, TextChangedEventArgs e)
        {
            var input = GetInput(sender, InputType.OnlyDigits);

            if (IsInputIncorrect(input, _output)) return;

            var n = Convert.ToInt32(input);

            _output.Text = String.Join(", ", _mathHelper.Fibonacci(n));
        }
    }
}
