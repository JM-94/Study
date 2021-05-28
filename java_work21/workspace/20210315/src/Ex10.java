//p.309 13-2-1
public class Ex10 {
	
	public static void doPrintArr(int[] arr) {
		for (int i = 0; i<arr.length; i++){
			System.out.println("arr["+i+"] = "+arr[i]);
		}
	}
	
	public static void addOneDArr(int[] arr, int add){
		for(int i =0; i<arr.length; i++)
			arr[i] += add;
		
		doPrintArr(arr);
		
	}
	
	public static void addTwoDArr(int[][] arr, int add){
		//이 안에서 addOneDArr 메소드를 호출한다.
		for(int i =0; i<arr.length;i++)
			addOneDArr(arr[i],add);
		
	}
	
	public static void main(String[] args) {
//		addOneDArr( new int[]{4,5,6}, 10);
		addTwoDArr( new int[][]{ {4,5,6}, {7,8,9} }, 10);
	}
	
}
