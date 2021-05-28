class AA {
	public void doMe() {
		System.out.println("AA.doMe");
	}
}

class BB {
	public void doMe() {
		System.out.println("BB.doMe");
	}
}

class CC {
	public void doMe() {
		System.out.println("CC.doMe");
	}
}

class AABBCC {
	public void doAABBCCME(AA aa) {
		aa.doMe();
	}
	public void doAABBCCME(AA aa, BB bb) {
		aa.doMe();
		bb.doMe();
	}

	public void doAABBCCME(AA aa, BB bb, CC cc) {
		aa.doMe();
		bb.doMe();
		cc.doMe();
	}
}

public class Ex03 {
	
	public static void main(String[] args) {
		AABBCC abc = new AABBCC();
//		abc.doAABBCCME(new AA(),new BB(),new CC());
		
		abc.doAABBCCME(new AA(),new BB());
	}
}
