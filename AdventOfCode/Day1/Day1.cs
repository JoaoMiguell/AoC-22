namespace AdventOfCode;

internal class Day1 {
  private List<int> ElfsCalories = new();

  public Day1() {
    using(StreamReader sr = new StreamReader("./Day1/Data.txt")) {
      int sum = 0;
      while(!sr.EndOfStream) {
        string? data = sr.ReadLine();
        if(data == "") {
          ElfsCalories.Add(sum);
          sum = 0;
        }
        else
          sum += int.Parse(data!);
      }
    }
  }

  public int GetBiggerAmount() {
    return ElfsCalories.Max();
  }

  public int GetThreeBiggers() {
    List<int> list = ElfsCalories;
    int sum = 0;
    for(int i = 0; i < 3; i++) {
      sum += list.Max();
      list.Remove(list.Max());
    }

    return sum;
  }
}

