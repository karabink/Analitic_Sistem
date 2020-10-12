using System;
using System.Collections.Generic;

namespace Analytics_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Analytics obj = Analytics.getInstance();
            Console.WriteLine("************************");
            obj.addUrl("https://mail.google.com/");
            obj.addUrl("https://mail.google.com/");
            obj.addUrl("https://mail.google.com/");
            obj.addUrl("https://www.richdad.com/");
            obj.addUrl("https://www.richdad.com/");
            obj.print();
            Console.WriteLine("*************************");
            obj.clearHistory();
            Console.WriteLine("*************************");
            obj.print();
            Console.WriteLine("*************************");
        }
    }
    class Analytics
    {
        private Dictionary<string, int> UrlList;
        private static Analytics _instance;
        private Analytics()
        {
            UrlList = new Dictionary<string, int>();
        }
        public static Analytics getInstance()
        {
            if (_instance == null)
            {
                _instance = new Analytics();
            }
            return _instance;
        }
        public void addUrl(string url)
        {
            if (UrlList.ContainsKey(url))
            {
                UrlList[url] += 1;
            }
            else
            {
                UrlList.Add(url, 1);
            }
        }
        public void print()
        {
            if (UrlList.Count != 0)
            {
                foreach (var item in UrlList)
                {
                    Console.WriteLine("Url: {0}, clicksNumber: {1}", item.Key, item.Value);
                }
            }
            else
            {
                Console.WriteLine("Url history is empty!");
            }
        }
        public void clearHistory()
        {
            UrlList.Clear();
            Console.WriteLine("History has been cleared!");
        }
    }
}
