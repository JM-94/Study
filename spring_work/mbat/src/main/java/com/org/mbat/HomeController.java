package com.org.mbat;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;
import javax.sql.DataSource;

import org.mybatis.spring.SqlSessionTemplate;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;


/*
 * aop 로 공통부분 실행 세션체크
 * @responsebody ajax 통신 
 * 1. 문자열 -> 통신규약 X
 * 2. json -> 통신규약 json javascript object 문자열
 */
@Controller
public class HomeController {
	
	private static final Logger logger = LoggerFactory.getLogger(HomeController.class);
	
	@Autowired
	DataSource ds;
	
	@Autowired
	SqlSessionTemplate sst;
	
	// 세션 로그인 
	@RequestMapping("/aoplogin")
	@ResponseBody
	public String sessionlogin(HttpServletRequest request) {
		System.out.println("여기에서 aop 실행");
		HttpSession session= request.getSession();
		session.setAttribute("id", "1234");
		return "<div style='background:#ccc'>login..session..sucess<div>";
	}
	
	@RequestMapping(value = "/", method = RequestMethod.GET)
	public String home(Model model) {
		return "index";
	}
	
	
	
}
