using System.Windows.Controls;

namespace HomeWorkApp.Source
{
    public abstract class TaskView
    {
        protected const string INPUT_KEY = "Input";

        protected const string OUTPUT_KEY = "Output";

        public abstract string OperationPrefix { get; }

        protected StackPanel _panel;

        protected TextBox _input;

        protected TextBlock _output;

        public TaskView(StackPanel stackPanel)
        {
            _panel = stackPanel;

            _input = (TextBox) _panel.FindName($"{OperationPrefix}{INPUT_KEY}");

            _output = (TextBlock) _panel.FindName($"{OperationPrefix}{OUTPUT_KEY}");

            _input.TextChanged += OnInputChange;
        }

        protected abstract void OnInputChange(object sender, TextChangedEventArgs e);

        protected string GetInput(object sender)
        {
            if (sender is not TextBox) return string.Empty;

            var textBox = sender as TextBox;

            return textBox != null ? textBox.Text : string.Empty;
        }

        protected string GetInput(object sender, InputType inputType)
        {
            var input = GetInput(sender);

            switch (inputType)
            {
                case InputType.OnlyDigits:

                    return new string(input.Where(x => char.IsDigit(x)).ToArray());

                default:

                    return input;
            }
        }

        protected bool IsInputIncorrect(string value, TextBlock output)
        {
            var result = value == null || !value.Any();

            if (result) _output.Text = string.Empty;

            return result;
        }
    }

    public enum InputType
    {
        OnlyDigits
    }
}
