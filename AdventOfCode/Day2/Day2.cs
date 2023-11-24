namespace AdventOfCode;

internal class Day2 {
  private List<string> Games = new();

  public Day2() {
    using(StreamReader sr = new StreamReader("./Day2/Data.txt")) {
      while(!sr.EndOfStream) {
        Games.Add(sr.ReadLine()!);
      }
    }
  }

  public int CalcScore() {
    int Score = 0;
    Games.ForEach(round => {
      string[] choices = round.Split(' ');
      switch(choices[0]) {
        case "A":
        if(choices[1] == "X") { Score += 4; }
        else if(choices[1] == "Y") { Score += 8; }
        else if(choices[1] == "Z") { Score += 3; }
        break;
        case "B":
        if(choices[1] == "X") { Score += 1; }
        else if(choices[1] == "Y") { Score += 5; }
        else if(choices[1] == "Z") { Score += 9; }
        break;
        case "C":
        if(choices[1] == "X") { Score += 7; }
        else if(choices[1] == "Y") { Score += 2; }
        else if(choices[1] == "Z") { Score += 6; }
        break;
      }
    });
    return Score;
  }

  // ELE A = Pedra | B = Papel | C = tesoura
  // EU  X = Pedra | Y = Papel | Z = tesoura
  // pt  1 = Pedra | 2 = Papel | 3 = Tesoura
  //Game 0 = Perdi | 3 = Empate| 6 = Vitoria 
  // X = Perder | Y = Empatar | Z = Ganhar
  public int ManipulatedScore() {
    int Score = 0;
    Games.ForEach(round => {
      string[] choices = round.Split(' ');
      switch(choices[0]) {
        case "A":
        if(choices[1] == "X") { Score += 3; }
        else if(choices[1] == "Y") { Score += 4; }
        else if(choices[1] == "Z") { Score += 8; }
        break;
        case "B":
        if(choices[1] == "X") { Score += 1; }
        else if(choices[1] == "Y") { Score += 5; }
        else if(choices[1] == "Z") { Score += 9; }
        break;
        case "C":
        if(choices[1] == "X") { Score += 2; }
        else if(choices[1] == "Y") { Score += 6; }
        else if(choices[1] == "Z") { Score += 7; }
        break;
      }
    });
    return Score;
  }
}

