package com.org.mbat;

import java.sql.Connection;
import java.sql.SQLException;
import java.text.DateFormat;
import java.util.Date;
import java.util.Locale;

import javax.sql.DataSource;

import org.mybatis.spring.SqlSessionTemplate;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller
public class HomeController {
	
	private static final Logger logger = LoggerFactory.getLogger(HomeController.class);
	
	@Autowired
	DataSource ds;
	
	@Autowired
	SqlSessionTemplate sst;
	
	@RequestMapping(value = "/", method = RequestMethod.GET)
	public String home(Locale locale, Model model) {
		sst.insert("member.insert");
		Connection conn = null;
		try {
			// 자료형에서 가져오기
			conn = ds.getConnection();
			System.out.println("연결성공");
		}catch (Exception e) {
			e.printStackTrace();
		}
		finally {
			// 자료형으로 넣어주기
			try {
				conn.close();
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
		
		logger.info("Welcome home! The client locale is {}.", locale);
		
		Date date = new Date();
		DateFormat dateFormat = DateFormat.getDateTimeInstance(DateFormat.LONG, DateFormat.LONG, locale);
		
		String formattedDate = dateFormat.format(date);
		
		model.addAttribute("serverTime", formattedDate );
		
		return "home";
	}
	
}
