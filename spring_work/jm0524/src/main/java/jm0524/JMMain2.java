package jm0524;

import org.springframework.context.support.GenericXmlApplicationContext;

public class JMMain2 {

	public static void main(String[] args) {
		GenericXmlApplicationContext gxac =
				new GenericXmlApplicationContext("appctx.xml");
		JMService jm = gxac.getBean(JMService.class);
		jm.doAABB();
	}
}
