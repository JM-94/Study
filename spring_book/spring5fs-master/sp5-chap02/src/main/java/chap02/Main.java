package chap02;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class Main {

	public static void main(String[] args) {
		
		// 스프링 컨테이너 만든다..
		// appContext 클래스를 가지고.. 만든다
		
		// spring 5 버전 @configuration
		// spring 4 버전 configuration.xml
		AnnotationConfigApplicationContext ctx = 
				new AnnotationConfigApplicationContext(AppContext.class);
		
		// 스프링 컨테이너 객체 안에 Greeter 객체를 가져와서 g1 에 넣어라
		Greeter g1 = ctx.getBean("greeter", Greeter.class);
		// 스프링 컨테이너 객체 안에 Greeter 객체를 가져와서 g2 에 넣어라
		Greeter g2 = ctx.getBean("greeter", Greeter.class);
		
		// g1 에 주소값이랑 g2에 주소값이 같은지 확인해서
		// 메모리 상에 하나의 싱글콘 객체인 Greeter 가 들어있는지 확인
		System.out.println("(g1 == g2) = " + (g1 == g2));
		// 스프링 컨테이너 닫아라
		ctx.close();
	}
}
