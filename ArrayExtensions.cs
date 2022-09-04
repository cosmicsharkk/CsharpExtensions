using System;

namespace MyExtensions
{
    public static class ArrayExtensions
    {

        public static string ArrayToString<T>(this T[] input){
            string result = "";
            for(int i = 0; i < input.Length; i++){
                result += input[i].ToString();
                if(i < input.Length - 1) result += ", ";
            }
            return result;
        }

    }
}
