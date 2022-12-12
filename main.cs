using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    string[] cmds = System.IO.File.ReadAllLines(@"input.txt");
    List<int> pipelineAtStart = new List<int>();
    
    int x = 1;
    int cycle = 0;
    pipelineAtStart.Add(x);
    foreach(string cmd in cmds) {
      if (cmd == "noop") {
        // a noop
        pipelineAtStart.Add(x);
        //cycle++;
      } else {
        // add
        int addX = Convert.ToInt32(cmd.Substring(5, cmd.Length -5));
        pipelineAtStart.Add(x);
        //cycle++;
        x = x + addX;
        pipelineAtStart.Add(x);
        //cycle++;
      }
    }
    int[] cycles = {20, 60, 100, 140, 180, 220};
    for(int i=0; i<pipelineAtStart.Count; i++) {
      Console.WriteLine("{0}:\t{1}", i+1, pipelineAtStart[i]);
    }
    int sumStrength = 0;
    foreach (int c in cycles) {
      int strength = pipelineAtStart[c-1]*c;
      Console.WriteLine("{0}: {1} = Strength: {2}", c, pipelineAtStart[c-1], strength);
      sumStrength += strength; 
    }
    Console.WriteLine("Strength: {0}", sumStrength);
    
  }
}