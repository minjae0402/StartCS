using System;

class Program {
  static void Main() {
    int[] arr = new int[] {
      1, 2, 3
    };
    for (int i = 0; i < arr.Length; i++) {
      arr[i] = i+i;
    }

    
    for (int i = 0; i < arr.Length; i++) {
      Console.WriteLine(arr[i]);
    }
    foreach (var i in arr) {
      Console.WriteLine(i);
    }
  }
}