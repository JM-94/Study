class Box{
	private String content;
	Box(){}
	Box(String contnnt){
		this.content = content;
	}
	//alt + shift +s ->s toString �����
	//alt + shift +s ->r getter setter �����
	//alt + shift +s -> ������ �����
	@Override
	public String toString() {
		return "Box [content=" + content + "]";
	}
	
}
/* import java.lang.*
 * toString() ��������
 * �⺻������ ����
 * this ����
 * */


public class Ex08 {
	//oxf3 0xeee f2 xe3
	public static void main(String[] args) {
		StringBuilder stb= new StringBuilder("12");
		stb.append("34");
		System.out.println(stb.toString());
		System.out.println(stb);
		
		Box box = new Box(); //�⺻�����ڵ� ���� �Ǿ��� ǥ��
		System.out.println(box);
		System.out.println(box.toString());
	}
}
