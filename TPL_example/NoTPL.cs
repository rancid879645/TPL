using System.Diagnostics;

namespace TPL_example
{
    public class NoTPL
    {
        public void Request()
        {
            const int limit = 100;
            const string url = "https://jsonplaceholder.typicode.com/todos/";
            var httpClient = new HttpClient();
            var stopWatch = Stopwatch.StartNew();

            for (var i = 0; i < limit; i++)
            {
                var response = httpClient.GetAsync(url).Result;
            }
            stopWatch.Stop();

            Console.WriteLine($"Time: {stopWatch}");
        }

    }
}
