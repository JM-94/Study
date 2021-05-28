class Account{
	String accNumber;	//12-34-89    '-' 문자
	String ssNumber;	//940407-1111111
	int balance;		//0
	public Account(){}
	//다른생성자를 선언하게 되면 기본 생성자가 없어지는 현상이 있다.
	public Account(String acc,String ss,int bal){
		accNumber = acc;
		ssNumber = ss;
		balance = bal;
	}
//	public void initAccount(String acc,String ss,int bal){
//		accNumber = acc;
//		ssNumber = ss;
//		balance = bal;
//	}
	public void checkAccount(){
		System.out.println("계좌번호 = "+accNumber);
		System.out.println("주민등록  = "+ssNumber);
		System.out.println("금액 = "+balance);
	}
}


public class AccountMana {
	public static void main(String[] args) {
		Account acc1 = new Account("12-34-89", "940407-1111111", 1000000);
		Account acc2 = new Account("34-89-12", "000407-1111111", 10000);
		
		
		
//		acc1.initAccount("12-34-89", "940407-1111111", 1000000);
//		acc1.initAccount("34-89-12", "000407-1111111", 10000);
		
		acc1.checkAccount();
		acc2.checkAccount();
	}
}
