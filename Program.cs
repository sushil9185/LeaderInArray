namespace LeaderInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = [10, 22, 12, 3, 0, 6];
            PrintArray(FindLeader2(myArray));

        }

        static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static int[] FindLeader1(int[] nums)
        {
            int n = nums.Length;
            List<int> ans = new List<int>();
            for(int i = 0; i < n; i++)
            {
                bool isLeader = true;
                for(int j = i + 1; j < n; j++)
                {
                    if (nums[i] <= nums[j])
                    {
                        isLeader = false;
                        break;
                    }
                }
                if(isLeader)
                {
                    ans.Add(nums[i]);
                }
            }

            return ans.ToArray();
        }

        static int[] FindLeader2(int[] nums)
        {
            int n = nums.Length;
            List<int> ans = new List<int>();
            int maxFromRight = nums[n - 1];
            ans.Add(maxFromRight);
            for(int i = n - 2; i >= 0; i--)
            {
                if (nums[i] > maxFromRight)
                {
                    maxFromRight = nums[i];
                    ans.Add(maxFromRight);
                }
            }

            return ans.ToArray();


        }
    }
}
