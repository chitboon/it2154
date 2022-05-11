using System;
using Xunit;
using TDDConsole;
namespace TDDTest {
    public class UnitTest1 {
        [Fact]
        public void Test1Int() {
            int [] arr = {1};
            // int expected = 1;
            Nullable<int> expected = 1;
            Assert.Equal(expected, TDDConsole.Program.FirstInt(arr));
        }
        [Fact] 
        public void Test2Int() {
            int [] arr = {1,2};
            // int expected = 1;
            Nullable<int> expected = 1;
            Assert.Equal(expected, TDDConsole.Program.FirstInt(arr));
        }

        /*
        [Fact]
        public void Test0Int() {
            int [] arr = {};
            Assert.Throws<System.IndexOutOfRangeException>(() => TDDConsole.Program.FirstInt(arr));
        }
        */
        [Fact]
        public void Test0Int() {
            int [] arr = {};
            Nullable<int> expected = null;
            Assert.Equal(expected, TDDConsole.Program.FirstInt(arr));
        }

        
    }
}
