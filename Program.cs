using System;

namespace HelloWorld {
  class Program {
    static void Main(string[] args) {
      int[,] arrs = new int[2, 3] {
        {1, 2, 3},
        {4, 5, 6}
      };

      foreach(var arrsin in arrs) {
        Console.WriteLine("arrs : " + arrsin);
      }


      int[] arr = new int[5];
      List<int> list = new List<int>() {
        1, 2, 3, 4
      };

      Dictionary<int, int> list2 = new Dictionary<int, int>() {
        {1, 2},
        {3, 4}
      };
      foreach(var lit2 in list2) {
        Console.WriteLine("List2 : " + lit2);
      }

      for (int i = 0; i < 5; i++) {
        arr[i] = i+1;
      }
      for (int i = 0; i < 5; i++) {
        Console.WriteLine(arr[i]);
      }
      
      foreach(var num in arr) {
        Console.WriteLine(num);
      }

      foreach(var lit in list) {
        Console.WriteLine("list : " + lit);
      }

      string HelloWorld = "HelloWorld";
      Console.WriteLine(HelloWorld);
    }
  }
}