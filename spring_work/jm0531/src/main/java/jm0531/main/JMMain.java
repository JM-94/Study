package jm0531.main;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;

import jm0531.cls.A;
import jm0531.conf.MyConf1;

public class JMMain {
	/*
	 * 오전
	 * spring chap5
	 * mybatis 설정하고 insert
	 * 
	 * 오후
	 * opencv 라이브러리 확인
	 */	
	public static void main(String[] args) {
		// 스프링 컨테이너 생성
		AbstractApplicationContext aac =
				new AnnotationConfigApplicationContext(MyConf1.class);
		A a = aac.getBean(A.class);
		a.doA();
		aac.close();
	}

}
