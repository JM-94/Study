package jm0531.main;

import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.GenericXmlApplicationContext;

import jm0531.cls.A;

public class JMMain1 {
	/*
	 * --------------진행예정--------------
	 * 6장까지 spring 기본
	 * 8장까지
	 * JdbcTemplate 기본 객체  -> mybatis 객체를 사용
	 * 
	 * --------------진행완료--------------
	 * 어노테이션 xml
	 * 스프링 객체 담는 통을 생성
	 * @Bean, <bean>
	 * 
	 * 생성자초기함수, 초기화 방식, 셋터 설정 초기화 방식
	 * 생성자함수  <constructor-arg name="" value="11"></constructor-arg>
	 * set 함수 <property name="a" value="11"></property>
	 * 
	 * @ComponentScan -> 기본 패키지 설정해서 bean 객체 검색
	 * @autowrid -> 스프링 컨테이너에서 자동으로 객체 가져오는거
	 * 
	 * @Component -> 객체 담기
	 * @Service -> 객체 담기
	 * @controller -> 객체 담기
	 * @Repository -> 객체 담기
	 * @Aspect -> 객체 담기 
	 * 
	 */

	public static void main(String[] args) {
		AbstractApplicationContext aac =
				new GenericXmlApplicationContext("myconf1.xml");
		
		A a = aac.getBean(A.class);
		a.doA();
		aac.close();
	}
}
