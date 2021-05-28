// private 자기 자신 클래스에서만 접근가능하다
public class UnsafeCircle {
	public static void main(String[] args) {
		Circle c = new Circle(1.5);
		double area = c.getArea();
		System.out.println("c넓이는 = "+area);
		
		c.setRad(2.5);
		area = c.getArea();
		System.out.println("c넓이는 = "+area);
		
		c.setRad(-1.5);
	}
}
