using System.Windows.Controls;

namespace HomeWorkApp.Source._Analytics
{
    public class AnalyticsView 
    {
        public const string BEST_DAY_KEY_OUTPUT = "BestDayOutput";

        public const string WORST_DAY_KEY_OUTPUT = "WorstDayOutput";

        private TextBlock _bestDay;

        private TextBlock _worstDay;

        private Analytics _analytics;

        public AnalyticsView(StackPanel stackPanel, Analytics analytics)
        {
            _analytics = analytics; 

            _bestDay = (TextBlock) stackPanel.FindName(BEST_DAY_KEY_OUTPUT);

            _worstDay = (TextBlock) stackPanel.FindName(WORST_DAY_KEY_OUTPUT);
        }

        public void Update(string path)
        {
            _analytics.Upload(path);

            _bestDay.Text = $"Best: {_analytics.BestDay}";

            _worstDay.Text = $"Worst: {_analytics.WorstDay}";
        }
    }
}
