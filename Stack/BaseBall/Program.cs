
int number = 0000;
Solution.Increment();
//string [] ops = {"5","2","C","D","+"}; passed
//string[] ops = {"5","-2","4","C","D","9","+","+"};passed
// string[] ops = {"1","C"};
// int output = Solution.CalPoints(ops);
// Console.WriteLine(output);



public class Solution {

//   public static void InvokeIncrement()
//   {
//      for (int i = 0; i < 100; i++)
//      {
//         Increment();
//      }
//   }
    public static void Increment()
    {
     string s = "UK";
      int counter = 2;
      if (counter < 10000)
      {
         counter++;
          string result = s + counter.ToString().PadLeft(4, '0');
          Console.WriteLine(result);
      }
      
      else
     {
          string result = s + counter++.ToString();
          Console.WriteLine(result);
      }
   
    }
    public static int CalPoints(string[] ops) 
    {
        List<int> records = new List<int>();
        for(int i =  0; i < ops.Length; i++)
        {
            if(ops[i] != "D" && ops[i] != "C" && ops[i] != "+")
            {
                records.Add(int.Parse(ops[i]));
            }

            else if(ops[i] == "+")
            {
               int previousRecord =  records.ElementAtOrDefault(records.Count-1);
               int numberBeforePrevious = records.ElementAtOrDefault(records.Count - 2);
               int newRecord = previousRecord + numberBeforePrevious;

               records.Add(newRecord);
            }

            else if(ops[i] == "D")
            {
                int newScore = records.ElementAtOrDefault(records.Count - 1) * 2;
                records.Add(newScore);
            }
            
            else if(ops[i] == "C")
            {
                records.RemoveAt(records.Count - 1);
            }
        }

        return records.Sum();
    }
}