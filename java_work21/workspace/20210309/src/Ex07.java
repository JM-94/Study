//p.237

class BB{
	public void doPro() {
		for(int i = 0; i<10;i++){
			Accumulator.add(i);
		}
		Accumulator.showResult();
		
	}
}
public class Ex07 {
	Ex07(){
		BB b = new BB();
		b.doPro();
	}
	public static void main(String[] args) {
		new Ex07();
	}
}
