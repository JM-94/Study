class Account{
	String accNumber;	//12-34-89    '-' ����
	String ssNumber;	//940407-1111111
	int balance;		//0
	public Account(){}
	//�ٸ������ڸ� �����ϰ� �Ǹ� �⺻ �����ڰ� �������� ������ �ִ�.
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
		System.out.println("���¹�ȣ = "+accNumber);
		System.out.println("�ֹε��  = "+ssNumber);
		System.out.println("�ݾ� = "+balance);
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
