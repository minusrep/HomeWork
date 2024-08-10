using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HomeWorkApp.Source.View
{
    public class RotateInverseView : TaskView
    {
        public override string OperationPrefix => "RotateInverse";

        private ArrayHandler _arrayHandler;

        public RotateInverseView(StackPanel stackPanel, ArrayHandler arrayHandler) : base(stackPanel)
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

            if (secondArray == null || secondArray.Length != 1) return;

            var k = secondArray[0];

            var result = string.Empty;

            _arrayHandler.RotateInverse(firstArray, k).ToList().ForEach(x => result += $"{x}, ");

            _output.Text = result;
        }
    }
}
