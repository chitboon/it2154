using System;
namespace TDDConsole {
    public class Program  {
        static void Main(string[] args) {
            int [] arr = {};
            Console.WriteLine(FirstInt(arr));
        }

        // public static int FirstInt(int[] nums) { return nums[0]; }
        public static Nullable<int> FirstInt(int[] nums) {
            if (nums.Length > 0) {
                return nums[0]; 
            } else {
                return null;
            }
        }


    }
}
