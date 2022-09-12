using System;

namespace MyExtensions{
    public static class LinkedListExtensions{
        public static string LinkedListToString(this ListNode n){
            string result = "[ ";
            while(n != null){
                result += n.val.ToString();
                if(n.next != null) result += ", ";
                n = n.next;
            }
            return result + " ]";
        }
    }
}