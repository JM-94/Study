package jm0525.beans;

import org.springframework.stereotype.Component;

@Component
public class AA {
	public int a = 10;
	public void doA() {
		System.out.println("doA");
	}
	public void doB() {
		System.out.println("doB");
	}
}
