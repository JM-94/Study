/*
 * �޼ҵ念��
 * 	�޼ҵ� ����Ʈ�ڵ�, static ����
 * 	- ���α׷� �������� ����ɶ����� �޸𸮻� �����Ѵ�.
 * ���ÿ���
 * 	�Լ����� ���������� �Ű�����
 * 	- �Լ����� ���������� �밳������ �Լ� ����ÿ� �ڵ����� �����Ѵ�.
 * ������
 * 	�����ڰ� new ��� ���� ���ؼ� ���� �����ÿ� ����ϴ� ����
 * 	- �������� �������� null�� �����Ҷ� �ڹ� ������ �÷����� �ڵ����� �����ȴ�.
 */

public class Ex01 {
	public static void main(String[] args) {
		Person p1 = new Person("��翬");
		Person p2 = new Person("��Ǹ�");
		
		System.gc();
		System.runFinalization();
		
		System.out.println("�����");
	}
}
