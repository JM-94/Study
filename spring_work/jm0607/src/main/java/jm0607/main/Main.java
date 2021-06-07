package jm0607.main;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

import jm0607.cls.Calc;
import jm0607.conf.MyConf;
/*
 * MyConf 스프링 객체담는 통 만들기
 * Calc 계산기 클래스
 * MyAsepect aop생성 클래스
 * main 함수 실행하는 클래스
 * 
 * aop 데코레이션
 * requestMapping("/") -> url 매핑
 * home();
 */

public class Main {
	public static void main(String[] args) {
	
		AnnotationConfigApplicationContext acac = 
				new AnnotationConfigApplicationContext(MyConf.class);
		
		
		Calc cl = acac.getBean(Calc.class);
//		cl.doA();
		cl.doB(10,20);
		
		acac.close();
	}
	
	

	
}
