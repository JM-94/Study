/*
 * java
 * 
 * ���� ���� ������..
 * public(�ƹ�����) protected(�����) default private(�ڱ��ڽŸ�)
 * 
 * static ���α׷����۰� ����ÿ� ��� ����
 * ����
 * �޼���
 * 
 * ������ �����ε�
 * super
 * this 1. �����ڿ��� ȣ�� 2. Ŭ���� ������ ������ �� ���
 * 
 * */



class AAAA{
	AAAA(){System.out.println("����Ŭ���� ������");}
}

//1. setter getter
// 2. �����ڸ� ���ؼ� ���� ����
public class Person extends AAAA{
 private String name;
 private int age;
 
 //������ �����ε�
 public Person() {
//	 super(); //�������� ������ ȣ��ÿ� �ٷ� �� �����ٿ� ��ġ
	 this("��浿",33);
 }
	
 
 public Person(String name, int age) {
	 super(); //��������
	 this.name = name;
	 this.age = age;
 }
 
 
 //������ �ڵ� ����� alt + shift + s + o
 
 public void doPrint(){
	 System.out.println("name = "+name);
	 System.out.println("age = "+age);
 }
}
