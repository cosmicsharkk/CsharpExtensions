using System;
using System.Collections;

namespace MyExtensions{

    public static class ListExtenstions{

        public static string ListToString(this IList input){
            string result = "[ ";
            for(int i = 0; i < input.Count; i++){
                if(!(input[i] is IList)){
                    result += input[i].ToString();     
                }else{
                    result += ((IList)input[i]).ListToString();
                }
                if (i < input.Count - 1) result += ", ";
            }
            return result + " ]";
        }

    }

}