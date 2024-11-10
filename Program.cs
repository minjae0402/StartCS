using System;
using System.Collections;

class Program {
  static void Main() {
    ArrayList al = new ArrayList();
    Queue qu = new Queue();
    Stack st = new Stack();
    Hashtable ht = new Hashtable();

    al.Add(1);
    al.Add("Hello");
    al.Add(1.1);
    al.Add(true);

    qu.Enqueue(1);
    qu.Enqueue(2);
    qu.Enqueue(3);

    st.Push(1);
    st.Push(2);
    st.Push(3);

    ht["apple"] = "사과";
    ht["banana"] = "바나나";
    ht["orange"] = "오렌지";

    foreach(var item in al) {
      Console.WriteLine("ArrayList : " + item);
    }

    while (qu.Count > 0) {
      Console.WriteLine("Queue : " + qu.Dequeue());
    }

    while (st.Count > 0) {
      Console.WriteLine("Stack : " + st.Pop());
    }

    Console.WriteLine(ht["apple"]);
    Console.WriteLine(ht["banana"]);
    Console.WriteLine(ht["orange"]);
  }
}