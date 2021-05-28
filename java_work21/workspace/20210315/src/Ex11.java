//p.309 13-2-2
public class Ex11 {
	int arr[][] = {
			{1,2,3},		//0
			{4,5,6},		//1
			{7,8,9}			//2
	};
	Ex11(){
		int temp[] = arr[0];
		//temp 1,2,3
		arr[0] = arr[2];
		arr[2] = arr[1];
		arr[1] = temp;
		/*
		 * 7,8,9
		 * 4,5,6
		 * 7,8,9
		 */
		for(int i =0; i<arr.length;i++){
			for(int j =0; j<arr[i].length;j++){
				System.out.print(arr[i][j]+" ");
			}
			System.out.println();
		}
			
	}
	/*
	 * 7,8,9
	 * 1,2,3
	 * 4,5,6
	 */
	public static void main(String[] args) {
		new Ex11();
	}
}
