
public class Bank {
	public static void main(String[] args) {
		
		Account yoon;
		Account park;
		
		yoon = new Account();
		park = new Account();
		
		yoon.printAL();
		park.printAL();
		
		yoon.setName("��");
		park.setName("��");
		
		yoon.setAl(1000);
		park.setAl(3000);
		
		yoon.printAL();
		park.printAL();
		
	}	
}
