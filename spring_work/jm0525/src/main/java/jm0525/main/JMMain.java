package jm0525.main;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

import jm0525.beans.AA;
import jm0525.conf.Appctx;

public class JMMain {

	public static void main(String[] args) {
		AnnotationConfigApplicationContext acac =
				new AnnotationConfigApplicationContext(Appctx.class);
		AA aa1 = acac.getBean(AA.class);
		aa1.doA();
		aa1.doB();	
		AA aa2 = acac.getBean(AA.class);
		System.out.println(aa1);
		System.out.println(aa2);
		
		System.out.println("aa1.a = " + aa1.a);
		aa1.a = 20;
		System.out.println("aa2.a = " + aa2.a);
	}
}
