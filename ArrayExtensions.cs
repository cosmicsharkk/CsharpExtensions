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

        //Does not work for a mix of jagged and multidimensional jagged arrays
        public static string JaggedArrayToString<T>(this T[][] input){
            string result = "[ ";
            for(int i = 0; i < input.Length; i++){
                result += $"[{input[i].ArrayToString()}]";
                if(i < input.Length - 1) result += ", ";
            }
            result += " ]";
            return result;
        }

        //Only works for integer arrays as our scope is to use this while solving leetcode problems
        public static ListNode ArrayToLinkedList(this int[] input){
            if(input.Length == 0) return null;
            ListNode head = new ListNode(input[0]);
            ListNode pointer = head;
            for(int i = 1; i < input.Length; i++){
                pointer.next = new ListNode(input[i]);
                pointer = pointer.next;
            }
            return head;
        }

    }
}
