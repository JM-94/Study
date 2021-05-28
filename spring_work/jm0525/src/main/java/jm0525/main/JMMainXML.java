package jm0525.main;

import org.springframework.context.support.GenericXmlApplicationContext;

import jm0525.beans.UseAABB;

public class JMMainXML {

	public static void main(String[] args) {
		GenericXmlApplicationContext gxac
		= new GenericXmlApplicationContext("appctx.xml");
		
		UseAABB uab = gxac.getBean(UseAABB.class);
		uab.doAABB();
	}
}
