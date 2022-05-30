using System;
using System.Collections.Generic;
using System.Linq;

namespace Meeting_Rooms
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

  class Solution
  {
    public bool CanAttendMeetings(List<int[]> intervals)
    {
      bool canAttend = true;
      if (intervals.Count == 1) return canAttend;
      // a person can attaend all the meetings if -
      // 1. none of the two meetings start at the same time
      // 2. all meetings start after or at the same time of ending previou meeting 

      var sortedIntervals =  intervals.OrderBy(x => x[0]).ToList();
      for (int i = 1; i < sortedIntervals.Count; i++)
      {
        var current = sortedIntervals[i];
        var previous = sortedIntervals[i - 1];
        if (current[0] < previous[1]) return false;
      }
      return canAttend;
    }
  }
}
