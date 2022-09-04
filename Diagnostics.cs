using System;

namespace MyExtensions{
    public static class Diagnostics {
        public static T GetExecutionTime<T>(Func<T> d){
            //Start timer
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //Execute method
            var result = d();
            //Stop timer, print results and return results
            watch.Stop();
            Console.WriteLine($"Elasped time is {watch.ElapsedMilliseconds / 1000}.{watch.ElapsedMilliseconds % 1000:D3} seconds.");
            return result;
        }
    }
}