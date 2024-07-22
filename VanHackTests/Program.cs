using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VanHackTests
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Largest Matriz
            //    TextWriter textWriter = new StreamWriter("../files/file.txt", true);

            //    //int arrRows = Convert.ToInt32(Console.ReadLine().Trim());
            //    //int arrColumns = Convert.ToInt32(Console.ReadLine().Trim());

            //    List<List<int>> arr = new List<List<int>>();

            //    //for (int i = 0; i < arrRows; i++)
            //    //{
            //    //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //    //}


            //    #region Testes de Arrays

            //    arr.Clear();
            //    arr.Add(new List<int>() { 1, 1, 1, 1, 1 });
            //    arr.Add(new List<int>() { 1, 1, 1, 0, 0 });
            //    arr.Add(new List<int>() { 1, 1, 1, 0, 0 });
            //    arr.Add(new List<int>() { 1, 1, 1, 0, 0 });
            //    arr.Add(new List<int>() { 1, 1, 1, 1, 1 });
            //    int result = Result.largestMatrix(arr);

            //    Console.WriteLine("Result 5x5.: " + result.ToString());

            //    arr.Clear();
            //    arr.Add(new List<int>() { 1, 1, 1 });
            //    arr.Add(new List<int>() { 1, 0, 0 });
            //    arr.Add(new List<int>() { 0, 1, 1 });
            //    result = Result.largestMatrix(arr);

            //    Console.WriteLine("Result 3x3.: " + result.ToString());

            //    arr.Clear();
            //    arr.Add(new List<int>() { 1, 1, 1 });
            //    arr.Add(new List<int>() { 1, 1, 0 });
            //    arr.Add(new List<int>() { 1, 0, 1 });
            //    result = Result.largestMatrix(arr);

            //    Console.WriteLine("Result 3x3.: " + result.ToString());

            //    arr.Clear();
            //    arr.Add(new List<int>() { 0, 1, 1 });
            //    arr.Add(new List<int>() { 1, 1, 1 });
            //    arr.Add(new List<int>() { 1, 0, 1 });
            //    result = Result.largestMatrix(arr);

            //    Console.WriteLine("Result 3x3.: " + result.ToString());

            //    arr.Clear();
            //    arr.Add(new List<int>() { 1, 1, 1, 1 });
            //    arr.Add(new List<int>() { 0, 1, 1, 1 });
            //    arr.Add(new List<int>() { 1, 1, 1, 1 });
            //    arr.Add(new List<int>() { 1, 1, 1, 1 });
            //    result = Result.largestMatrix(arr);

            //    Console.WriteLine("Result 4x4.: " + result.ToString());

            //    #endregion

            //    textWriter.WriteLine(result);

            //    textWriter.Flush();
            //    textWriter.Close();

            //    Environment.Exit(0);

            #endregion

            #region Angry Animals

            //TextWriter textWriter = new StreamWriter("../files/file.txt", true);

            int n = 0;
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            long result = 0;

            n = 8;
            a.Add(2);
            a.Add(3);
            a.Add(4);
            a.Add(3);

            b.Add(8);
            b.Add(5);
            b.Add(6);
            b.Add(4);

            result = Result.angryAnimals(n, a, b);
            //textWriter.WriteLine(result);

            Console.WriteLine(result.ToString());

            //n = 9;
            //a = new List<int>();
            //a.Add(2);
            //a.Add(3);
            //a.Add(4);
            //a.Add(3);
            //a.Add(5);
            //b = new List<int>();
            //b.Add(8);
            //b.Add(5);
            //b.Add(6);
            //b.Add(4);
            //b.Add(9);
            //result = Result.angryAnimals(n, a, b);

            //n = 8;
            //a = new List<int>();
            //a.Add(2);
            //a.Add(3);
            //a.Add(4);
            //a.Add(3);
            //b = new List<int>();
            //b.Add(8);
            //b.Add(5);
            //b.Add(6);
            //b.Add(4);

            ////result = Result.angryAnimals(n, a, b);
            //Result.openAndClosePrices("1-January-2000", "22-February-2000", "Monday");
            //textWriter.WriteLine(result);

            //Console.WriteLine(result.ToString());

            //textWriter.Flush();
            //textWriter.Close();

            #endregion

            //int[] t = new int[] { 0, 0, 1, 5 };
            //int[] d = new int[] { 0, 1, 1, 0 };

            //var res = Result.turnstile(t, d);

            //t = new int[] { 0, 1, 1, 3, 3 };
            //d = new int[] { 0, 1, 0, 0, 1 };

            //res = Result.turnstile(t, d);
            //int[] ranks = new int[] { 3, 4, 3, 0, 2, 2, 3, 0, 0 };
            //int[] ranks = new int[] { 3, 5, 6, 3, 3, 5 };
            //var res = Result.solution(ranks);

            //var res = Result.testar(213);

            //var res = Result.stack("13 DUP 4 POP 5 DUP + DUP + -");
            //var res = Result.stack("5 6 + -");

            //int[] nails = new int[] { 1, 1, 3, 3, 3, 4, 5, 5, 5, 5 };
            //var res = Result.solution(nails, 2);
        }       
    }

    class Result
    {

        /*
         * Complete the 'largestMatrix' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int largestMatrix(List<List<int>> arr)
        {
            // Get Dimensions for matrix, rows and columns
            int rows = arr.Count();
            int cols = arr.FirstOrDefault().Count();
            
            // Auxiliar Matrix
            int[,] matrix = new int[rows, cols];

            // Iterators
            int i, j;

            int largestPossible = 0;

            // Transform list to Matrix
            for (int x = 0; x < rows; x++)
                for (int y = 0; y < cols; y++)
                    matrix[x, y] = arr[x][y];

            /* 
             * Iterate matrix and set values to anothers positions
             */
            for (i = 1; i < rows; i++)
                for (j = 1; j < cols; j++)
                    matrix[i, j] = (arr[i][j] == 1) ? (Math.Min(matrix[i, j - 1], Math.Min(matrix[i - 1, j], matrix[i - 1, j - 1])) + 1) : matrix[i, j] = 0;

            /*
             Iterate and check de largest possible matrix
             */
            for (i = 0; i < rows; i++)
                for (j = 0; j < cols; j++)
                    largestPossible = largestPossible < matrix[i, j] ? matrix[i, j] : largestPossible;

            return largestPossible;
        }

        public static long angryAnimals(int n, List<int> a, List<int> b)
        {
            /// Count all Groups possible
            int groups = 0;

            /// Saves the enemies
            var enemies = new Dictionary<int, int>();

            /// Run friendship animal
            for (int i = 0; i < a.Count; i++)
            {
                /// The animal can't be enemy yourself
                if (a[i] == b[i])
                    continue;

                ///Get the min animal enemy
                int min = Math.Min(a[i], b[i]);

                ///Get the max animal enemy
                int max = Math.Max(a[i], b[i]);

                /// Add as enemy pair
                if (!enemies.TryGetValue(min, out var current))
                    enemies.Add(min, max);

                /// Add as enemy pair case current enemy is greater than max
                if (current > max)
                    enemies[min] = max;
            }

            /// The last enemy
            int lEnemy = n + 1;

            /// Run to count possible groups
            for (int i = n; i >= 1; i--)
            {
                /// Check enemies
                int added = lEnemy;

                /// Has enemy and last enemy is greater than enemy verified
                if (enemies.TryGetValue(i, out var enemy) && (lEnemy > enemy))
                {
                    lEnemy = enemy;
                    added = enemy;
                }

                groups += (added - i);
            }

            return groups;
        }

            /*
         * Complete the function below.
         */
        public static void openAndClosePrices(string firstDate, string lastDate, string weekDay)
        {
            DateTime? fDate = null, lDate = null;
            string url = string.Format("https://jsonmock.hackerrank.com/api/stocks/?weekDay={0}", weekDay);
            Double totalDays;
            List<string> dates = new List<string>();

            if (!string.IsNullOrEmpty(firstDate) && !string.IsNullOrEmpty(lastDate))
            {
                fDate = DateTime.Parse(firstDate);
                fDate = DateTime.Parse(firstDate);
                lDate = DateTime.Parse(lastDate);
            }
            else if (!string.IsNullOrEmpty(firstDate))
            {
                fDate = DateTime.Parse(firstDate);
                lDate = DateTime.Now;
            }
            else if (!string.IsNullOrEmpty(lastDate))
            {
                lDate = DateTime.Parse(lastDate);
                fDate = new DateTime(2000, 1, 1);
            }

            if (lDate.HasValue && fDate.HasValue)
            {
                if (fDate.Value.ToString("dddd", CultureInfo.CreateSpecificCulture("en")) == weekDay)
                {
                    dates.Add(fDate.Value.ToString("d-MMMM-yyyy", CultureInfo.CreateSpecificCulture("en")));
                }
                else
                {
                    while (fDate.Value.ToString("dddd", CultureInfo.CreateSpecificCulture("en")) != weekDay && fDate.Value.Date <= lDate.Value.Date)
                    {
                        fDate = fDate.Value.AddDays(1);
                    }
                    dates.Add(fDate.Value.ToString("d-MMMM-yyyy", CultureInfo.CreateSpecificCulture("en")));
                }

                while (fDate.Value.Date <= lDate.Value.Date)
                {
                    fDate = fDate.Value.AddDays(7);
                    if (fDate.Value.Date <= lDate.Value)
                    {
                        dates.Add(fDate.Value.ToString("d-MMMM-yyyy", CultureInfo.CreateSpecificCulture("en")));
                    }
                }                
            }

            List<JObject> responses = new List<JObject>();

            if (dates.Count > 0)
            {
                foreach (var date in dates)
                {
                    string nurl = string.Format("{0}&date={1}", url, date);
                    using (var client = new WebClient())
                    {
                        var response = client.DownloadString(nurl);
                        JObject obj = JObject.Parse(response);
                        int page = (int)obj["page"];

                        if ((int)obj["page"] >= 1)
                        {
                            if((int)obj["total"] > 0)
                                responses.Add(obj);

                            if (page > 1)
                            {
                                for (page = 2; page < (int)obj["page"]; page++)
                                {
                                    response = client.DownloadString(string.Format("{0}&page={1}", url, page));
                                    if (!string.IsNullOrEmpty(response))
                                    {
                                        obj = JObject.Parse(response);
                                        if ((int)obj["total"] > 0)
                                            responses.Add(obj);
                                    }
                                }
                            }
                            
                        }
                    }
                }
            }
            else
            {
                using (var client = new WebClient())
                {
                    var response = client.DownloadString(url);
                    JObject obj = JObject.Parse(response);
                    int page = (int)obj["page"];

                    if ((int)obj["page"] >= 1)
                    {
                        if ((int)obj["total"] > 0)
                            responses.Add(obj);

                        if (page > 1)
                        {
                            for (page = 2; page < (int)obj["page"]; page++)
                            {
                                response = client.DownloadString(string.Format("{0}&page={1}", url, page));
                                if (!string.IsNullOrEmpty(response))
                                {
                                    obj = JObject.Parse(response);
                                    if ((int)obj["total"] > 0)
                                        responses.Add(obj);
                                }
                            }
                        }

                    }
                }
            }

            foreach (var resp in responses)
            {
                Console.WriteLine(string.Format("{0} {1} {2}", resp["data"][0]["date"], resp["data"][0]["open"], resp["data"][0]["close"]));

            }
        }

        public static int[] turnstile(int[] time, int[] direction)
        {
            // Write your code here
            var returnTimes = new int [time.Length];
            var beforePass = -1;
            var ticks = 0;
            /*
            n = 4
            time = [0, 0, 1, 5]
            direction = [0, 1, 1, 0]

            n = 5
            time = [0, 1, 1, 3, 3]
            direction = [0, 1, 0, 0, 1]
             */
            for (var i = 0; i < time.Length; i++)
            {
                ticks = 0;

                var timeNow = time[i];
                var dirNow = direction[i];
                int lio = Array.LastIndexOf(time, i) == i ? -1 : Array.LastIndexOf(time, i);

                if (lio == -1 || (lio > 0 && beforePass == -1 && dirNow == 1) || (lio > 0 && dirNow == beforePass && dirNow == 1))
                {
                    returnTimes[i] = timeNow;
                    beforePass = dirNow;
                }
                else
                {
                    ticks++;
                    if (ticks < timeNow)
                    {
                        ticks = timeNow;
                    }

                    var dirT = dirNow;
                    for (int t = i+1; t <= lio; t++)
                    {
                        var timeAft = time[t];
                        dirT = direction[t];
                        if (timeAft == timeNow)
                        {
                            ticks++;
                        } 
                    }
                    returnTimes[i] = ticks;
                    beforePass = dirT;
                }
            }

            return returnTimes;
        }

        //public static int solution(int[] ranks)
        //{
        //    // write your code in C# 6.0 with .NET 4.5 (Mono)
        //    int reports = 0;
        //    foreach (var rank in ranks.ToList())
        //        if (ranks.Contains(rank + 1))
        //            reports++;
        //    return reports;

        //    int ans = 0;
        //}

        public static int solution(int[] A)
        {
            int n = A.Length;
            int[] arr = A;
            int ans = 0;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)

                    // finding the index with same 
                    // value but different index. 
                    if (arr[i] == arr[j])
                        ans++;
            return ans;
        }

        public static int testar(int N)
        {
            int result = -1;
            if (N > 100000000)
            {
                return result;
            }
            else
            {
                List<int> orderedNum = new List<int>();
                string num = N.ToString();

                for (int i = 0; i < num.Length; i++)
                {
                    orderedNum.Add(Convert.ToInt32(num.Substring(i, 1)));
                }

                string res = "";

                foreach (var number in orderedNum.OrderByDescending(x => x))
                {
                    res += number.ToString();
                }

                result = Convert.ToInt32(res);
            }
            return result;
        }

        public static int stack(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string[] commands = S.Split(' ');
            Stack sts = new Stack(commands.Length);

            foreach (string com in commands)
            {
                Console.WriteLine(com);
                if (com == "DUP" || com == "POP")
                {
                    if (sts.Count > 0)
                    {
                        if (com == "DUP")
                        {
                            Int32 top = (Int32)sts.Peek();
                            sts.Push(top);
                        }
                        else
                        {
                            sts.Pop();
                        }
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (com == "+" || com == "-")
                {
                    if (sts.Count >= 2)
                    {
                        Int32 v1 = (Int32)sts.Pop();
                        Int32 v2 = (Int32)sts.Pop();
                        if (com == "+")
                        {
                            sts.Push(v1 + v2);
                        }
                        else
                        {
                            sts.Push(v1 - v2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else
                {
                    try
                    {                    
                        Int32 num = 0;
                        Int32.TryParse(com, out num);
                        sts.Push(num);
                    }
                    catch
                    {
                        return -1;
                    }
                }
            }

            return Convert.ToInt32(sts.Peek());
        }

        public static int solution(int[] A, int K)
        {
            int n = A.Length;
            int best = 0;
            int count = 1;
            for (int i = 0; i < n - K - 1; i++)
            {
                if (A[i] == A[i + 1])
                    count = count + 1;
                else
                    count = 0;
                if (count > best)
                    best = count;
            }
            int result = best + 1 + K;

            return result;
        }
    }

}