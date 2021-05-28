
public class Ex04 {
	public static void main(String[] args) {
		Point point = new Point(3,5);
//		Point cpy = new point(3,5);
//		
//		cpy.xpos = point.xpos;
//		cpy.ypos = point.ypos;
		
		Point cpy = null;
		try{
			cpy = (Point)(point.clone());
		} catch (CloneNotSupportedException e){
			e.printStackTrace();
		}
		System.out.println(point);
		System.out.println(cpy);
		
		point.xpos = 20;
		System.out.println("org = "+point);
		System.out.println("cpy = "+cpy);
	}
}
