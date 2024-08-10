using System.Windows.Controls;

namespace HomeWorkApp.Source
{
    public class BinaryCountOnesView : TaskView
    {
        public override string OperationPrefix => "BinaryCountOnes";

        private MathHelper _mathHelper;

        public BinaryCountOnesView(StackPanel stackPanel, MathHelper mathHelper) : base(stackPanel)
        {
            _mathHelper = mathHelper;
        }

        protected override void OnInputChange(object sender, TextChangedEventArgs e)
        {
            var input = GetInput(sender, InputType.OnlyDigits);

            if (IsInputIncorrect(input, _output)) return;

            var n = Convert.ToInt32(input);

            _output.Text = _mathHelper.BinaryCountOnes(n).ToString();
        }
    }
}
