Functionalities:

1. Log contents of an array
2. Get execution time of any method

Usage:
1. To log contents to console
var myArrray = new int[] {2,7,11,15}; // could be of any type
myArray.ArrayToString();

2. To get execution time
var result = Diagnostics.GetExecutionTime(() => AnyMethod(args));
//result contains returned values, execution time is logged to console
