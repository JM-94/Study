//p125
public class Ex02 {

	public static void main(String[] args) {
		int total = 1;
	
		for(int i = 1; i<11; i++){
			total *=i;
			
		}
		System.out.println("1부터 10까지의 곱은? : "+total);
		
		for(int i =1; i<10; i++){
			System.out.println("5 *"+i+" = "+5*i);
		}
		for(int i =2; i<9; i= i+2){
			System.out.println("i"+i);
			for (int j=1; j<j+1; j++){
				System.out.println("j = " +j);
				System.out.println(i+"*"+j+"="+(i*j));
			}
			System.out.println();
		}
	}
}
