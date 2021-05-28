package jm0525.main;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

import jm0525.beans.UseAABB;
import jm0525.conf.Appctx;

public class JMMainAuto {

	public static void main(String[] args) {
		AnnotationConfigApplicationContext acac = 
				new AnnotationConfigApplicationContext(Appctx.class);
		
		UseAABB uab = acac.getBean(UseAABB.class);
		uab.doAABB();
	}
}
