using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace HomeWorkApp.Source.View
{
    public class MaxView : TaskView
    {
        public override string OperationPrefix => "Max";

        private ArrayHandler _arrayHandler;

        public MaxView(StackPanel stackPanel, ArrayHandler arrayHandler) : base(stackPanel)
        {
            _arrayHandler = arrayHandler;
        }

        protected override void OnInputChange(object sender, TextChangedEventArgs e)
        {
            var input = GetInput(sender);

            if (input.Count(c => c == '[') != 2 || input.Count(c => c == ']') != 2) return;

            var regex = new Regex(@"\[(.*?)\]");

            var matches = regex.Matches(input);

            if (matches.Count != 2) return;

            int[] firstArray = matches[0].Groups[1].Value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse).ToArray();

            int[] secondArray = matches[1].Groups[1].Value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse).ToArray();

            if (secondArray == null || secondArray.Length != 2) return;

            var start = secondArray[0];

            var end = secondArray[1];

            var result = _arrayHandler.Max(firstArray, out var i, out var abs, start, end);

            _output.Text = $"Max: {result}: i: {i}, abs: {abs}";
        }
    }
}
