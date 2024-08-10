using System.Windows.Controls;

namespace HomeWorkApp.Source
{
    public class PallidromeView : TaskView
    {
        public override string OperationPrefix => "Pallidrome";

        private MathHelper _mathHelper;

        public PallidromeView(StackPanel stackPanel, MathHelper mathHelper) : base(stackPanel)
            => _mathHelper = mathHelper;

        protected override void OnInputChange(object sender, TextChangedEventArgs e)
        {
            var input = GetInput(sender, InputType.OnlyDigits);

            if (IsInputIncorrect(input, _output)) return;

            var n = Convert.ToInt32(input);

            _output.Text = _mathHelper.IsPallidrome(n).ToString();
        }
    }
}
