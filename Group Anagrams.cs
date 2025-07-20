namespace Algorithms
{
    internal class Group_Anagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var tempArray = new List<string>(strs);
            var result = new List<IList<string>>();
            var dict = new Dictionary<string, List<int>>();

            for(int i = 0; i < tempArray.Count; i++)
            {
                tempArray[i] = new string(tempArray[i].OrderBy(x => x).ToArray());
            }

            for(int i =0;i < tempArray.Count; i++)
            {
                if (!dict.ContainsKey(tempArray[i]))
                {
                    dict[tempArray[i]] = new List<int>();
                }
                dict[tempArray[i]].Add(i);
            }

            foreach(var item in dict.Values)
            {
                var group = new List<string>();
                foreach(var index in item)
                {
                    group.Add(strs[index]);
                }
                result.Add(group);
            }

            return result;
        }


    }
}
