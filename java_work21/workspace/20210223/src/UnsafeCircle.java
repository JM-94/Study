// private �ڱ� �ڽ� Ŭ���������� ���ٰ����ϴ�
public class UnsafeCircle {
	public static void main(String[] args) {
		Circle c = new Circle(1.5);
		double area = c.getArea();
		System.out.println("c���̴� = "+area);
		
		c.setRad(2.5);
		area = c.getArea();
		System.out.println("c���̴� = "+area);
		
		c.setRad(-1.5);
	}
}
