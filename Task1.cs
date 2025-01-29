using System;

class Task1{
	
	public static void Main(string[] args){
		float[] array  = {9.1F, 8.6F, 8.65F, 8.154F, 8.267F, 10.143F};
		int[] ans = new int[array.Length];
		
		for(int i = 0; i < array.Length; i++){
			
			string num = Convert.ToString(array[i]);
			int j = 0;
			int d = 0;
			while(true){
				if(num[j + 1] == '.'){
					d = (int)(num[j + 2] - '0');
					break;
				}
				j++;
			}
			
			if(d < 5){
				
				ans[i] = (int) array[i];
				
			} else {
				
				ans[i] = (int) array[i] + 1;
			}
			
		}
		
		for(int i = 0; i < ans.Length; i++){
			Console.Write(ans[i] + " ");
		}
	}
}