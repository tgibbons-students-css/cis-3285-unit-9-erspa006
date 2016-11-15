using System.Collections.Generic;
using System.IO;

using SingleResponsibilityPrinciple.Contracts;
using System.Net;

namespace SingleResponsibilityPrinciple
{
    public class URLTradeDataProvider : ITradeDataProvider //full disclosure i think it works but i dont fully understand why
    {
        public URLTradeDataProvider(string url)
        {
            var client = new WebClient();
            stream = client.OpenRead(url);
        }
        public IEnumerable<string> GetTradeData()
        {
            var tradeData = new List<string>();
            using (var reader = new StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    tradeData.Add(line);
                }
            }
            return tradeData;
        }

        private readonly Stream stream;
    }
}


