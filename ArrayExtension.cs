namespace DotNetLab2
{
    public static class ArrayExtension
    {
        public static int CountOccurrence<T>(this T[] arr, T el)
        {
            int answer = 0;
            foreach (T item in arr) 
            {
                if(el == null)
                {
                    if (item == null) answer++;
                }
                else if (el.Equals(item)) answer++;
            }

            return answer;
        } 

        public static T[] ClearDuplicates<T>(this T[] arr)
        {
            HashSet<T> seen = new HashSet<T>();
            List<T> clean = new();
            
            for(int i = 0; i < arr.Length; i++)
            {
                if (seen.Contains(arr[i]) == false)
                {
                    seen.Add(arr[i]);
                    clean.Add(arr[i]);
                }
            }

            return clean.ToArray();
        }

    }
}
