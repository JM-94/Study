package chap02;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

// 싱글톤 담는 통 객체
@Configuration
public class MhContext {
	
	@Bean
	public AA aa() {
		AA aa = new AA();
		return aa;
	}
	
	@Bean
	public BB bb() {
		BB bb = new BB();
		return bb;
	}
}
