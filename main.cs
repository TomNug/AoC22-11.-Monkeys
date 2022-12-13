using System;
using System.Collections.Generic;

class Program {
  
  public static void Main (string[] args) {
    List<int> monkey0 = new List<int>{84, 66, 62, 69, 88, 91, 91};
    List<int> monkey1 = new List<int>{98, 50, 76, 99};
    List<int> monkey2 = new List<int>{72, 56, 94};
    List<int> monkey3 = new List<int>{55, 88, 90, 77, 60, 67};
    List<int> monkey4 = new List<int>{69, 72, 63, 60, 72, 52, 63, 78};
    List<int> monkey5 = new List<int>{89, 73};
    List<int> monkey6 = new List<int>{78, 68, 98, 88, 66};
    List<int> monkey7 = new List<int>{70};

    int activity0 = 0;
    int activity1 = 0;
    int activity2 = 0;
    int activity3 = 0;
    int activity4 = 0;
    int activity5 = 0;
    int activity6 = 0;
    int activity7 = 0;
    
    // Rounds
    for (int i=0; i<10000; i++) {
      // Monkey 0
      for (int item=monkey0.Count-1; item>= 0; item--){
        activity0++;
        monkey0[item] *= 11;
        monkey0[item] /= 3;
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
        monkey1[item] /= 3;
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
        monkey2[item] /= 3;
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
        monkey3[item] /= 3;
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
        monkey4[item] /= 3;
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
        monkey5[item] /= 3;
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
        monkey6[item] /= 3;
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
        monkey7[item] /= 3;
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
    List<int> activity = new List<int>{activity0, activity1, activity2, activity3, activity4, activity5, activity6, activity7};
    activity.Sort();
    Console.WriteLine("Highest are {0} and {1}, with a monkey business of {2}", activity[activity.Count-1], activity[activity.Count-2], activity[activity.Count-1]*activity[activity.Count-2]);
  }
}