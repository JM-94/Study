
public class Circle {
	private double ra;
	Circle(){}
	Circle(double r){
		ra = r;
	}
	
	double getArea(){
		return ra*ra*3.14;
	}
	
	void setRad(double r){
		if(r<0){
			r=0;
			System.out.println("반지름은 양수여야함");
			return;
		}
		ra = r;
	}
}
