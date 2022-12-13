using System;
using System.Collections.Generic;

class Program {
  
  public static void Main (string[] args) {
    List<ulong> monkey0 = new List<ulong>{84, 66, 62, 69, 88, 91, 91};
    List<ulong> monkey1 = new List<ulong>{98, 50, 76, 99};
    List<ulong> monkey2 = new List<ulong>{72, 56, 94};
    List<ulong> monkey3 = new List<ulong>{55, 88, 90, 77, 60, 67};
    List<ulong> monkey4 = new List<ulong>{69, 72, 63, 60, 72, 52, 63, 78};
    List<ulong> monkey5 = new List<ulong>{89, 73};
    List<ulong> monkey6 = new List<ulong>{78, 68, 98, 88, 66};
    List<ulong> monkey7 = new List<ulong>{70};

    ulong activity0 = 0;
    ulong activity1 = 0;
    ulong activity2 = 0;
    ulong activity3 = 0;
    ulong activity4 = 0;
    ulong activity5 = 0;
    ulong activity6 = 0;
    ulong activity7 = 0;
    
    // Rounds
    for (int i=0; i<10000; i++) {
      // Monkey 0
      for (int item=monkey0.Count-1; item>= 0; item--){
        activity0++;
        monkey0[item] *= 11;
        //monkey0[item] /= 3;
        monkey0[item] = monkey0[item] % 9699690;
        if (monkey0[item]%2 == 0) {
          monkey4.Add(monkey0[item]); 
        } else {
          monkey7.Add(monkey0[item]);
        }
        monkey0.RemoveAt(item);
      } // End Monkey 0

      // Monkey 1
      for (int item=monkey1.Count-1; item>= 0; item--){
        activity1++;
        monkey1[item] *= monkey1[item];
        //monkey1[item] /= 3;
        monkey1[item] = monkey1[item] % 9699690;
        if (monkey1[item]%7 == 0) {
          monkey3.Add(monkey1[item]); 
        } else {
          monkey6.Add(monkey1[item]);
        }
        monkey1.RemoveAt(item);
      } // End Monkey 1

      // Monkey 2
      for (int item=monkey2.Count-1; item>= 0; item--){
        activity2++;
        monkey2[item] += 1;
        //monkey2[item] /= 3;
        monkey2[item] = monkey2[item] % 9699690;
        if (monkey2[item]%13 == 0) {
          monkey4.Add(monkey2[item]); 
        } else {
          monkey0.Add(monkey2[item]);
        }
        monkey2.RemoveAt(item);
      } // End Monkey 2

      // Monkey 3
      for (int item=monkey3.Count-1; item>= 0; item--){
        activity3++;
        monkey3[item] += 2;
        //monkey3[item] /= 3;
        monkey3[item] = monkey3[item] % 9699690;
        if (monkey3[item]%3 == 0) {
          monkey6.Add(monkey3[item]); 
        } else {
          monkey5.Add(monkey3[item]);
        }
        monkey3.RemoveAt(item);
      } // End Monkey 3

      // Monkey 4
      for (int item=monkey4.Count-1; item>= 0; item--){
        activity4++;
        monkey4[item] *= 13;
        //monkey4[item] /= 3;
        monkey4[item] = monkey4[item] % 9699690;
        if (monkey4[item]%19 == 0) {
          monkey1.Add(monkey4[item]); 
        } else {
          monkey7.Add(monkey4[item]);
        }
        monkey4.RemoveAt(item);
      } // End Monkey 4

      // Monkey 5
      for (int item=monkey5.Count-1; item>= 0; item--){
        activity5++;
        monkey5[item] += 5;
        //monkey5[item] /= 3;
        monkey5[item] = monkey5[item] % 9699690;
        if (monkey5[item]%17 == 0) {
          monkey2.Add(monkey5[item]); 
        } else {
          monkey0.Add(monkey5[item]);
        }
        monkey5.RemoveAt(item);
      } // End Monkey 5

      // Monkey 6
      for (int item=monkey6.Count-1; item>= 0; item--){
        activity6++;
        monkey6[item] += 6;
        //monkey6[item] /= 3;
        monkey6[item] = monkey6[item] % 9699690;
        if (monkey6[item]%11 == 0) {
          monkey2.Add(monkey6[item]); 
        } else {
          monkey5.Add(monkey6[item]);
        }
        monkey6.RemoveAt(item);
      } // End Monkey 6

      // Monkey 7
      for (int item=monkey7.Count-1; item>= 0; item--){
        activity7++;
        monkey7[item] += 7;
        //monkey7[item] /= 3;
        monkey7[item] = monkey7[item] % 9699690;
        if (monkey7[item]%5 == 0) {
          monkey1.Add(monkey7[item]); 
        } else {
          monkey3.Add(monkey7[item]);
        }
        monkey7.RemoveAt(item);
      } // End Monkey 7
      
      /*Console.WriteLine("Round {0}", i);
      
      Console.WriteLine("Monkey 0");
      foreach(int item in monkey0) {
        Console.WriteLine(item);
      }
      Console.WriteLine("Monkey 1");
      foreach(int item in monkey1) {
        Console.WriteLine(item);
      }
      Console.WriteLine("Monkey 2");
      foreach(int item in monkey2) {
        Console.WriteLine(item);
      }
      Console.WriteLine("Monkey 3");
      foreach(int item in monkey3) {
        Console.WriteLine(item);
      }*/
    }
    List<ulong> activity = new List<ulong>{activity0, activity1, activity2, activity3, activity4, activity5, activity6, activity7};
    activity.Sort();
    Console.WriteLine("Highest are {0} and {1}, with a monkey business of {2}", activity[activity.Count-1], activity[activity.Count-2], activity[activity.Count-1]*activity[activity.Count-2]);
  }
}