package jm0531.main;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;

import jm0531.cls.A;
import jm0531.conf.MyConf1;

public class JMMain {
	/*
	 * ����
	 * spring chap5
	 * mybatis �����ϰ� insert
	 * 
	 * ����
	 * opencv ���̺귯�� Ȯ��
	 */	
	public static void main(String[] args) {
		// ������ �����̳� ����
		AbstractApplicationContext aac =
				new AnnotationConfigApplicationContext(MyConf1.class);
		A a = aac.getBean(A.class);
		a.doA();
		aac.close();
	}

}
