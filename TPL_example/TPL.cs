using System.Diagnostics;

namespace TPL_example
{
    public class TPL
    {
        public void Request()
        {
            const int limit = 100;
            const string url = "https://jsonplaceholder.typicode.com/todos/";
            var httpClient = new HttpClient();
            var requests = Enumerable.Range(1, limit).ToList();

            var stopWatch = Stopwatch.StartNew();

            Parallel.ForEach(requests, async r =>
            {
                var response = await httpClient.GetAsync(url);
            });

            stopWatch.Stop();

            Console.WriteLine($"Time: {stopWatch}");
        }


    }
}
