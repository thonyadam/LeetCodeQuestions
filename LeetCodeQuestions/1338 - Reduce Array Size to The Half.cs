namespace LeetCodeQuestions
{
    internal class _1338___Reduce_Array_Size_to_The_Half
    {

        public int MinSetSize(int[] arr)
        {

            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach(int i in arr)
            {
                if (!dic.ContainsKey(i))
                {
                    dic.Add(i, 1);
                }
                else
                {
                    dic[i]++;
                }
            }

            var sortedList = dic.ToList();

            sortedList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            var actualSize = 0;
            var minSet = 0;
            foreach(KeyValuePair<int,int> pair in sortedList)
            {
                if (actualSize  < (arr.Length /2))
                {
                    actualSize = actualSize + pair.Value;
                    minSet++;
                }
            }


            return minSet;
        }
        
    }
}
