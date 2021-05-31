package jm0531.cls;

import org.springframework.beans.factory.DisposableBean;
import org.springframework.beans.factory.InitializingBean;

public class A  implements InitializingBean, DisposableBean{
	public void doA() {
		System.out.println("doA");
	}

	public void afterPropertiesSet() throws Exception {
		System.out.println("A클래스 실행 후 자동실행");
		
	}

	public void destroy() throws Exception {
		System.out.println("스프링 객체담는통 없앨때");
	}
}
