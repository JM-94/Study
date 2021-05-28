package jm0525.conf;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;

import jm0525.beans.UseAABB;

@Configuration
@ComponentScan(basePackages = {"jm0525.beans"})
public class Appctx {

	@Bean
	public UseAABB useAABB() {
		UseAABB uab = new UseAABB();
		return uab;
	}
}
