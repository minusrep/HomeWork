using System.IO;

namespace HomeWorkApp.Source
{
    public class Analytics
    {
        public Dictionary<DateOnly, int> Data { get; private set; }

        public DateOnly BestDay
        {
            get
            {
                if (Data.Count == 0) return DateOnly.MaxValue;

                return Data.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            }
        }

        public DateOnly WorstDay
        {
            get
            {
                if (Data.Count == 0) return DateOnly.MaxValue;

                return Data.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
            }
        }

        public void Upload(string path)
        {
            Data = new Dictionary<DateOnly, int>();

            var data = File.ReadAllText(path);

            string[] lines = data.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.None);

            foreach(var line in lines)
            {
                var index = line.IndexOf(',');

                if (index == -1) return;

                var date = line.Substring(0, index).Split(new string[] { "-"}, StringSplitOptions.None);

                var year = Convert.ToInt32(date[0]);

                var month = Convert.ToInt32(date[1]);

                var day = Convert.ToInt32(date[2]);

                Data.Add(new DateOnly(year, month, day), Convert.ToInt32(line.Substring(index + 1)));
            }
        }
    }
}
