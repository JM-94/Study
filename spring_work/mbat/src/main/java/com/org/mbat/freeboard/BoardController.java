package com.org.mbat.freeboard;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import javax.servlet.http.HttpServletRequest;

import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;

@Controller
public class BoardController {

	/*
	 * spring 객체 담는 통안에 넣는 어노테이션
	 * @component -> 필요한객체타입
	 * 
	 * @controller -> url 요청 들어오는곳에
	 * @service -> 게시판기능 서비스들...
	 * @repository -> db 관리
	 * 
	 * @aspect -> aop
	 * 
	 */
	
	@Autowired
	SqlSessionTemplate sst;
	
	@Autowired
	BoardService bs;
	
	@RequestMapping(value = "/freeboard", method = RequestMethod.GET)
	public String freeboard(Model model) {
		System.out.println("게시판홈");
		List list = sst.selectList("freeboard.select", 0);
		model.addAttribute("list", list);
		
//		bs.select();
//		model.addAttribute("data",	"mydata");
//		List list = Arrays.asList(new Board(1,"title","pass","content", "wdate", "email",null,null),
//									new Board(2,"tit","pa","cot","wde","eil",null,null));
//		model.addAttribute("list",list);
		
		return "freeboard/freeboard";
	}
	
//	@RequestMapping(value = "/freeboard/insert")
//	public String freeboardinsert(Model model, HttpServletRequest request) {
//		String name = request.getParameter("name");
//		System.out.println("게시판홈");
////		bs.select();
//		bs.insert();
//		return "freeboard/freeboard";
//	}
	
	@RequestMapping(value = "/freeboard/insert")   //@RequestParam 안넣어도됨
//	@Transactional
	public String freeboardinsert(Model model, @RequestParam String name, Board board) {
		System.out.println("name = "+name);
		System.out.println(board);
//		bs.select();
		bs.insert(board);
		return "redirect:/freeboard";
	}
	
	
	@RequestMapping(value = "/freeboard/view")
//	@Transactional
	// @RequestParam String name 이거 있으면 안됨...
	public String freeboardview(Model model, int idx) {
		System.out.println("idx = " + idx);
		Board board = sst.selectOne("freeboard.selectone",idx);
//		board.setTitle("123123123123");
		model.addAttribute("board",board);
		return "freeboard/freeboardview";
	}
	
	@RequestMapping(value = "/freeboard/insertform", method = RequestMethod.GET)
	public String freeboardinsertfrorm(Model model) {
		System.out.println("게시판글쓰기");
//		bs.select();
//		bs.insert();
		return "freeboard/freeboardinsert";
	}
	
	@RequestMapping(value = "/freeboard/updateform", method = RequestMethod.GET)
	public String freeboardupdatefrorm(Model model, int idx) {
		System.out.println("idx = " + idx);
		Board board = sst.selectOne("freeboard.selectone",idx);
		model.addAttribute("board",board);
		return "freeboard/freeboardupdate";
	}
	
	@RequestMapping(value = "/freeboard/update", method = RequestMethod.POST)
	public String freeboardupdate(Model model, Board board) {
		sst.update("freeboard.updateone",board);
		return "redirect:/freeboard";
		
	}
	
	@RequestMapping(value = "/freeboard/delete", method = RequestMethod.POST)
	public String freeboarddelete(Model model, String[] cks) {
		ArrayList<String> cklist = new ArrayList<String>(Arrays.asList(cks));
		if (cklist.size()>0) 
			sst.delete("freeboard.delete",cklist);
//		new BoardValidater().validate(board, errors);
//		if (errors.hasErrors()) {
//			return "freeboard/freeboardupdate";
//		}
//		sst.update("freeboard.updateone", board);
		return "redirect:/freeboard";
	}
}
