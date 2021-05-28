package jm0524;

import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class Appctx {

	@Bean
	public AA aa() {
		AA aa =new AA();
		return aa;
	}
	
	@Bean
	public BB bb() {
		BB bb =new BB();
		return bb;
	}
	
	@Bean
	@Qualifier("cc1")
	public CC cc1() {
		CC cc =new CC();
		return cc;
	}
	
	@Bean
	@Qualifier("cc2")
	public CC cc2() {
		CC cc =new CC();
		return cc;
	}
	
	@Bean
	public DD dd2() {
		DD dd =new DD();
		return dd;
	}
	
	@Bean
	public JMService jmservice() {
		JMService jm = new JMService();
		return jm;
	}
}
