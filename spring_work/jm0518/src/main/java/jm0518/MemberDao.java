package jm0518;

import java.util.List;
import java.util.ArrayList;

public class MemberDao {

	List<MemberDTO> list = new ArrayList<MemberDTO>();
	
	public void doInsert() {
		MemberDTO mdto = new MemberDTO("ȫ�浿");
		list.add(mdto);
		System.out.println("�����߽��ϴ�.");
	}
}
