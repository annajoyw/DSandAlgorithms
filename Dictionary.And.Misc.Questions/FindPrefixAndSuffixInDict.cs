using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.And.Misc.Questions
{
    class FindPrefixAndSuffixInDict
    {
        private Dictionary<string, HashSet<string>> prefix = new Dictionary<string, HashSet<string>>();
        private Dictionary<string, HashSet<string>> suffix = new Dictionary<string, HashSet<string>>();
        private Dictionary<string, int> weight = new Dictionary<string, int>();

        public FindPrefixAndSuffixInDict(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                var w = words[i];
                weight[w] = i;
                for (int j = 0; j <= w.Length; j++)
                {
                    var pre = w.Substring(0, j);
                    string suf = string.Empty;
                    if (j > 0)
                    {
                        suf = w.Substring(w.Length - j, j);
                    }
                    if (!prefix.ContainsKey(pre)) prefix[pre] = new HashSet<string>();
                    if (!suffix.ContainsKey(suf)) suffix[suf] = new HashSet<string>();
                    prefix[pre].Add(w);
                    suffix[suf].Add(w);
                }
            }
        }

        public int F(string p, string s)
        {
            int result = -1;
            if (!prefix.ContainsKey(p) || !suffix.ContainsKey(s)) return result;
            foreach (var w in prefix[p])
            {
                if (suffix[s].Contains(w))
                {
                    result = Math.Max(result, weight[w]);
                }
            }
            return result;
        }
    }
}
