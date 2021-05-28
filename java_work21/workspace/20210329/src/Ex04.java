class MyException extends Exception{
	public MyException() {
		super("내가 만든 예외상황");
	}
}
public class Ex04 {
	Ex04(){
		try{
			throw new MyException();
		}catch (Exception me){
			System.out.println(me.getMessage());
		}
		
		
	}
	public static void main(String[] args) {		
		new Ex04();
	}
}
