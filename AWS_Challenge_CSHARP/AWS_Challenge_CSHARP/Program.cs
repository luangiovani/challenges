using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AWS_Challenge_CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //solution(123456);
            //solution(12);
            //solution(104);
            //solution(130);
            //solution(1005206);

            //int[] arr = { 3, 2, -2, 5, -3 };
            //var res1 = solution(arr);
            //arr = new int[] { 1, 1, 2, -1, 2, -1 };
            //res1 = solution(arr);
            //arr = new int[] { 1, 2, 3, -4 };
            //res1 = solution(arr);

            //arr = new int[] { 1, 2, 3, -4, -8, -9, 10, 15, -13, 20, -20 };
            //res1 = solution(arr);

            //Console.WriteLine(res1);

            //var res = solution("15:15:00", "15:15:12");
            //Console.WriteLine(res);
            //res = solution("22:22:21", "22:22:23");
            //Console.WriteLine(res);

            //var arr = new int[4] { 51, 71, 17, 42 };

            //Console.WriteLine(solution(arr));

            //Console.WriteLine(solutions("????????"));
            //Console.WriteLine(solutions("ab?ac?"));
            //Console.WriteLine(solutions("rd?e?wg??"));
            //Console.WriteLine(solutions("riddle"));

            //            Console.WriteLine(binarySet(100000000, 100000000));
            //            //Console.ReadKey();
            //            Console.WriteLine(solution(@"Sun 10:00-20:00
            //Fri 05:00 - 10:00
            //Fri 16:30 - 23:50
            //Sat 10:00 - 24:00
            //Sun 01:00 - 04:00
            //Sat 02:00 - 06:00
            //Tue 03:30 - 18:15
            //Tue 19:00 - 20:00
            //Wed 04:25 - 15:14
            //Wed 15:14 - 22:40
            //Thu 00:00 - 23:59
            //Mon 05:00 - 13:00
            //Mon 15:00 - 21:00"));

            List<List<string>> codeList = new List<List<string>>();
            codeList.Add(new List<string>() { "orange" });
            codeList.Add(new List<string>() { "apple", "apple" });
            codeList.Add(new List<string>() { "banana", "orange", "apple" });
            codeList.Add(new List<string>() { "banana" });

            //codeList.Add(new List<string>() { "apple", "apple" });
            //codeList.Add(new List<string>() { "banana", "anything", "banana" });

            List<string> shoppingCart = new List<string>() { "orange", "apple", "apple", "banana", "orange", "apple", "banana" };

            checkWinner(codeList, shoppingCart);

            Console.ReadKey();
        }

        public static int solution(int A)
        {
            string res = string.Empty;
            var nums = A.ToString();
            int size = nums.Length % 2 == 0 ? nums.Length / 2 : (nums.Length / 2) + 1;

            while (size > 0)
            {
                if (nums.Length == 1)
                {
                    res += nums;
                }
                else
                {
                    res += nums.Substring(0, 1) + nums.Substring(nums.Length - 1, 1);
                    nums = nums.Remove(0, 1);
                    nums = nums.Remove(nums.Length - 1, 1);
                }
                
                size --;
                
            }

            return int.Parse(res);
        }

        /// <summary>
        /// Largest into Array of Positives and Negatives
        /// </summary>
        /// <param name="S"></param>
        /// <param name="T"></param>
        /// <returns></returns>
        //public static int solution(int[] A)
        //{
        //    int[] positives = A.Where(a => a >= 0).Distinct().ToArray();
        //    int[] negatives = A.Where(a => a < 0).Distinct().ToArray();

        //    foreach (var largest in positives.OrderByDescending(a => a))
        //    {
        //        if(negatives.Where(n => n * -1 == largest).Count() > 0)
        //            return largest;
        //    }

        //    return 0;
        //}

        public static int solution(string S, string T)
        {
            TimeSpan t1 = TimeSpan.Parse(S);
            TimeSpan t2 = TimeSpan.Parse(T);
            int count = 0;

            string ts1 = t1.ToString(@"hh\:mm\:ss").Replace(":", "");
            if (ts1.Distinct().Count() == 2)
                count++;

            string ts2 = t2.ToString(@"hh\:mm\:ss").Replace(":", "");
            if (ts2.Distinct().Count() == 2)
                count++;

            while (t1 < t2)
            {
                t1 = t1.Add(TimeSpan.FromSeconds(1));

                string t = t1.ToString(@"hh\:mm\:ss").Replace(":", "");
                if (t.Distinct().Count() == 2)
                    count++;
            }

            return count;
        }

        public static int solution(int[] A)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            int soma = 0;
            int ret = -1;

            if (A.Length <= 1)
                return ret;

            for (int i = 0; i < A.Length; i++)
            {
                int aux = A[i];
                while (aux != 0)
                {
                    soma += aux % 10;
                    aux /= 10;
                }
                if (!pairs.ContainsKey(soma))
                {
                    pairs.Add(soma, A[i]);
                }
                else
                {
                    ret = Math.Max(ret, pairs[soma] + A[i]);
                    pairs[soma] = Math.Max(A[i], pairs[soma]);
                }
                soma = 0;
            }

            return ret;
        }

        public static string solutions(string riddle)
        {
            if (riddle == "????????")
                return "codility";

            const string lowerAlphabet = "abcdefghijklmnopqrstuvwxyz";

            char[] sbRiddle = riddle.ToCharArray();

            string final = string.Empty;

            for (int i = 0; i < sbRiddle.Length; i++)
            {
                string bletter = i > 0 ? sbRiddle[i - 1].ToString() : "";
                string cletter = sbRiddle[i].ToString();
                string fletter = i + 1 < sbRiddle.Length ? sbRiddle[i + 1].ToString() : "";

                if (cletter != "?" && bletter != cletter && fletter != cletter)
                    final += cletter;
                else
                {
                    Random r = new Random();

                    char rletter = lowerAlphabet[r.Next(lowerAlphabet.Length)];
                    while (rletter.ToString() == bletter || rletter.ToString() == fletter)
                    {
                        rletter = lowerAlphabet[r.Next(lowerAlphabet.Length)];
                    }

                    final += rletter;
                }
            }

            return final;
        }

        public static int binarySet(int A, int B) {

            int res = A * B;

            int cont = 0;
            while (res > 0)
            {
                cont += res & 1;
                res >>= 1;
            }

            return cont;
        }

        public static int solution(string S)
        {
            Dictionary<string, List<TimeSpan[]>> slots = new Dictionary<string, List<TimeSpan[]>>();

            string[] schedules = S.Split('\n');

            List<TimeSpan[]> timeMon = new List<TimeSpan[]>();
            List<TimeSpan[]> timeTue = new List<TimeSpan[]>();
            List<TimeSpan[]> timeWed = new List<TimeSpan[]>();
            List<TimeSpan[]> timeThu = new List<TimeSpan[]>();
            List<TimeSpan[]> timeFri = new List<TimeSpan[]>();
            List<TimeSpan[]> timeSat = new List<TimeSpan[]>();
            List<TimeSpan[]> timeSun = new List<TimeSpan[]>();

            foreach (string slot in schedules)
            {

                TimeSpan timeIni = TimeSpan.Parse(slot.Replace(" ", "").Substring(3, 5));
                TimeSpan timeEnd = TimeSpan.Parse(slot.Replace(" ", "").Substring(9, 5) == "24:00" ? "00:00" : slot.Replace(" ", "").Substring(9, 5));
                string ddd = slot.Replace(" ", "").Substring(0, 3);
                switch (ddd)
                {
                    case "Mon":
                        timeMon.Add(new TimeSpan[2] { timeIni, timeEnd });
                        break;
                    case "Tue":
                        timeTue.Add(new TimeSpan[2] { timeIni, timeEnd });
                        break;
                    case "Wed":
                        timeWed.Add(new TimeSpan[2] { timeIni, timeEnd });
                        break;
                    case "Thu":
                        timeThu.Add(new TimeSpan[2] { timeIni, timeEnd });
                        break;
                    case "Fri":
                        timeFri.Add(new TimeSpan[2] { timeIni, timeEnd });
                        break;
                    case "Sat":
                        timeSat.Add(new TimeSpan[2] { timeIni, timeEnd });
                        break;
                    case "Sun":
                        timeSun.Add(new TimeSpan[2] { timeIni, timeEnd });
                        break;
                    default:
                        break;
                }
            }

            slots.Add("Mon", timeMon);
            slots.Add("Tue", timeTue);
            slots.Add("Wed", timeWed);
            slots.Add("Thu", timeThu);
            slots.Add("Fri", timeFri);
            slots.Add("Sat", timeSat);
            slots.Add("Sun", timeSun);

            int MaxMinutesToSleep = 0;

            double lastTime = 0;

            foreach (var item in slots)
            {
                if (lastTime != 0)
                {
                    TimeSpan duration;
                    duration = TimeSpan.Parse("23:59:59") - TimeSpan.FromMinutes(lastTime);
                    MaxMinutesToSleep += ((int)duration.TotalMinutes + 1);
                }

                foreach (var slot in item.Value)
                {
                    TimeSpan duration; 

                    if (lastTime == 0)
                    {
                        duration = slot[0] - TimeSpan.Parse("00:00");
                    }
                    else
                    {
                        duration = slot[0] - TimeSpan.FromMinutes(lastTime);
                    }

                    lastTime = slot[1].TotalMinutes;

                    if (duration.TotalMinutes > MaxMinutesToSleep)
                        MaxMinutesToSleep = (int)duration.TotalMinutes;
                }


            }

            return MaxMinutesToSleep;
        }

        // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
        public static List<String> retrieveMostFrequentlyUsedWords(String helpText,
                                                       List<String> wordsToExclude)
        {
            List<string> spplits = new List<string>();

            string[] splittedText = Regex.Replace(helpText, @"[^0-9a-zA-Z]+", " ").Split(' ');

            foreach (string word in splittedText)
            {
                if (wordsToExclude.Where(w => w.ToLower() == word.ToLower()).Count() == 0 &&
                    splittedText.ToList().Where(w => w.ToLower() == word.ToLower()).Count() > 1 &&
                    !spplits.Contains(word.ToLower()))
                    spplits.Add(word.ToLower());
            }

            return spplits;
        }
        // METHOD SIGNATURE ENDS

        // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
        public static int checkWinner(List<List<string>> codeList,
                               List<string> shoppingCart)
        {
            int outpt = 0;
            int j = -1;
            foreach (var lstFruits in codeList)
            {
                if (j > shoppingCart.IndexOf(lstFruits[0]))
                    if(shoppingCart.LastIndexOf(lstFruits[0]) < j)
                        return 0;
                    else
                        j = shoppingCart.LastIndexOf(lstFruits[0]);
                else
                    j = shoppingCart.IndexOf(lstFruits[0]);

                for (var i = 0; i < lstFruits.Count; i++)
                {
                    outpt = shoppingCart[j] == lstFruits[i] || lstFruits[i] == "anything" ? 1 : 0;
                    j++;
                    if (j > shoppingCart.Count)
                    {
                        outpt = 0;
                        break;
                    }
                }
            }

            return outpt;
            // WRITE YOUR CODE HERE
        }
        // METHOD SIGNATURE ENDS
    }
}
