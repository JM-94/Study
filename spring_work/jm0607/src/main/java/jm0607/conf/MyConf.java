package jm0607.conf;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.EnableAspectJAutoProxy;

import jm0607.cls.Calc;
import jm0607.cls.MyAspect;

@Configuration
@EnableAspectJAutoProxy
public class MyConf {
	
	@Bean
	public MyAspect mtAspect() {
		MyAspect ma = new MyAspect();
		return ma;		
	}
	
	@Bean
	public Calc calc() {
		Calc cl = new Calc();
		return cl;
	}
	
	

}
