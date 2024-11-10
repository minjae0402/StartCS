using System;

class Person {
  public string Name;
  public void Eat() {
    Console.WriteLine(Name + "(이)기 식사를 합니다.");
  }
}

class Program {
  static void Main(string[] args) {
      Person p1 = new Person();
      p1.Name = "민재";
      p1.Eat();
    }
}