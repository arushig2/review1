using System;

class Task2{
	public static double Power(int a, int b){
		int prod = 1;
		
		for(int i = 1; i <= b; i++){
			prod *= a;
		}
		
		return prod;
	}
	public static void Main(string[] args){
		Console.WriteLine("Enter a number: ");
		int a = Convert.ToInt32(Console.ReadLine());
		double sum = 0;
		
		int temp = a;
		int pow = 1;
		
		while(temp != 0){
			int d = temp%10;
			sum += Power(d, pow);
			pow++;
			temp /= 10;
		}
		
		Console.WriteLine("Sum = " + sum);
	}
}