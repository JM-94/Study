
public class INum {
	private int num;
	private String name;
	
	public  INum(int num, String name) {
		super();
		this.num = num;
		this.name = name;
	}

	@Override
	public boolean equals(Object obj) {
		if(this.num == ((INum)obj).num
		&& 
		this.name.equals(((INum)obj).name)
		)
		{
			return true;
		}
		else{
			return false;
		}
	}
}
