class StaticValues{
	static int A = 10; //static �빮�ڰ� ǥ��
	int b = 20;
}

class A{
	public void doPrintStaticA(){ 
		System.out.println("SV.A = "+StaticValues.A++);
		StaticValues sv = new StaticValues();
		System.out.println("SV.b = "+sv.b++);
		;}
}
class B{
	public void doPrintStaticA(){ System.out.println("SV.A = "+StaticValues.A++);}
	
}
public class Ex01 {
	/*
	 * ������ ���� 
	 * ���� ���� .. ���α׷� ���ۿ��� ����ñ���
	 * 
	 * -> �̱���..
	 * 
	 * ���ؿ���
	 * auto int a = 10;
	 * �Լ����� �⺻������ ����ÿ� ����ϰ�.. �Լ������Ҷ� �޸𸮿��� ����..
	 * ������
	 * molloc calloc realloc free �����ڰ� ����ؼ� ����.. �޸� �Ҵ� �� ����
	 * c++
	 * malloc free... new ~ delete...
	 */
	
	public static void main(String[] args) {
		A a = new A();
		a.doPrintStaticA();
		B b = new B();
		b.doPrintStaticA();
		System.out.println("SV.A = "+StaticValues.A);
	}
}
