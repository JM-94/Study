package jm0524;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

// Controller
public class JmMain {

	public static void main(String[] args) {
		AnnotationConfigApplicationContext acac 
			= new AnnotationConfigApplicationContext(Appctx.class);
		
//		AA aa = acac.getBean(AA.class);
//		aa.doA();
//		aa.doAA();
//		
//		BB bb = acac.getBean(BB.class);
//		bb.doB();
//		bb.doBB();
		
		
		JMService jm = acac.getBean(JMService.class);
		jm.doAABB();
	}
}
