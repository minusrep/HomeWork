using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HomeWorkApp.Source.View
{
    public class BubbleSortView : TaskView
    {
        public override string OperationPrefix => "BubbleSort";

        private MathFunction _mathFunction;

        public BubbleSortView(StackPanel panel, MathFunction mathFunction) : base(panel)
        {
            _mathFunction = mathFunction;
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

            _mathFunction.BubbleSort(firstArray, (a, b) => a > b);
            
            firstArray.ToList().ForEach(x => result += $"{x}, ");

            _output.Text = result;
        }
    }

    public class SelectionSortView : TaskView
    {
        public override string OperationPrefix => "SelectionSort";

        private MathFunction _mathFunction;

        public SelectionSortView(StackPanel panel, MathFunction mathFunction) : base(panel)
        {
            _mathFunction = mathFunction;
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

            var comparisonCount = 0;

            _mathFunction.SelectionSort(firstArray, out comparisonCount, out int swapCount);

            firstArray.ToList().ForEach(x => result += $"{x}, ");

            result += $" C: {comparisonCount} | S: {swapCount}";

            _output.Text = result;
        }
    }

    public class RecursiveSumView : TaskView
    {
        public override string OperationPrefix => "RecursiveSum";

        private MathFunction _mathFunction;

        public RecursiveSumView(StackPanel panel, MathFunction mathFunction) : base(panel)
        {
            _mathFunction = mathFunction;
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

            var result = _mathFunction.RecursiveSum(firstArray);

            _output.Text = $"{result}";
        }
    }

    public class RecursiveEvenSumView : TaskView
    {
        public override string OperationPrefix => "RecursiveEvenSum";

        private MathFunction _mathFunction;

        public RecursiveEvenSumView(StackPanel panel, MathFunction mathFunction) : base(panel)
        {
            _mathFunction = mathFunction;
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

            var result = _mathFunction.RecursiveEvenSum(firstArray);

            _output.Text = $"{result}";
        }
    }

    public class RecursiveMaxView : TaskView
    {
        public override string OperationPrefix => "RecursiveMax";

        private MathFunction _mathFunction;

        public RecursiveMaxView(StackPanel panel, MathFunction mathFunction) : base(panel)
        {
            _mathFunction = mathFunction;
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

            var result = _mathFunction.RecursiveMax(firstArray);

            _output.Text = $"{result}";
        }
    }

    public class ReverseView : TaskView
    {
        public override string OperationPrefix => "Reverse";

        private MathFunction _mathFunction;

        public ReverseView(StackPanel panel, MathFunction mathFunction) : base(panel)
        {
            _mathFunction = mathFunction;
        }

        protected override void OnInputChange(object sender, TextChangedEventArgs e)
        {
            var input = GetInput(sender);

            var result = _mathFunction.Reverse(input);

            _output.Text = $"{result}";
        }
    }

    public class IsPallidromeView : TaskView
    {
        public override string OperationPrefix => "IsPallidrome";

        private MathFunction _mathFunction;

        public IsPallidromeView(StackPanel panel, MathFunction mathFunction) : base(panel)
        {
            _mathFunction = mathFunction;
        }

        protected override void OnInputChange(object sender, TextChangedEventArgs e)
        {
            var input = GetInput(sender);

            var result = _mathFunction.IsPallidrome(input);

            _output.Text = $"{result}";
        }
    }

    public class IsFibonacciView : TaskView
    {
        public override string OperationPrefix => "IsFibonacci";

        private MathFunction _mathFunction;

        public IsFibonacciView(StackPanel panel, MathFunction mathFunction) : base(panel)
        {
            _mathFunction = mathFunction;
        }

        protected override void OnInputChange(object sender, TextChangedEventArgs e)
        {
            var input = GetInput(sender, InputType.OnlyDigits);

            if (IsInputIncorrect(input, _output)) return;

            var n = Convert.ToInt32(input);

            _output.Text = $"{_mathFunction.Fibonacci(n)}";
        }
    }
    public class DigitsSumView : TaskView
    {
        public override string OperationPrefix => "DigitsSum";

        private MathFunction _mathFunction;

        public DigitsSumView(StackPanel panel, MathFunction mathFunction) : base(panel)
        {
            _mathFunction = mathFunction;
        }

        protected override void OnInputChange(object sender, TextChangedEventArgs e)
        {
            var input = GetInput(sender, InputType.OnlyDigits);

            if (IsInputIncorrect(input, _output)) return;

            var n = Convert.ToInt32(input);

            _output.Text = $"{_mathFunction.DigitsSum(n)}";
        }
    }
}
