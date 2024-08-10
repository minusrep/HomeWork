using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HomeWorkApp.Source.View
{
    public class SortByEvenView : TaskView
    {
        public override string OperationPrefix => "SortByEven";

        private ArrayHandler _arrayHandler;

        public SortByEvenView(StackPanel stackPanel, ArrayHandler arrayHandler) : base(stackPanel)
        {
            _arrayHandler = arrayHandler;
        }
        protected override void OnInputChange(object sender, TextChangedEventArgs e)
        {
            var input = GetInput(sender);

            if (input.Count(c => c == '[') != 1 || input.Count(c => c == ']') != 1) return;

            var regex = new Regex(@"\[(.*?)\]");

            var matches = regex.Matches(input);

            if (matches.Count != 1) return;

            int[] firstArray = matches[0].Groups[1].Value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse).ToArray();

            var result = string.Empty;

            _arrayHandler.SortByEven(firstArray.ToList()).ToList().ForEach(x => result += $"{x}, ");

            _output.Text = result;
        }
    }
}
