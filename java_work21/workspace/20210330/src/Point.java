
public class Point implements Cloneable{
	public int xpos;
	public int ypos;
	//alt + shift + s -> o
	public Point(int xpos, int ypos) {
		super();
		this.xpos = xpos;
		this.ypos = ypos;
	}
	//alt + shift + s -> s
	@Override
	public String toString() {
		return "Point [xpos=" + xpos + ", ypos=" + ypos + "]";
	}
	// alt + shfit +s -> v
//	@Override
//	protected Object clone() throws CloneNotSupportedException {
//		return super.clone();
//	}
	@Override
	protected Point clone() throws CloneNotSupportedException {
		return (Point)super.clone();
	}
	
	
}
