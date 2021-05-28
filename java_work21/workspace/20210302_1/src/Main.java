import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.InputStreamReader;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.Scanner;
//
//public class Main {
//	/*
//	 * 1. 학생등록 2. 학생조회 3. 학생수정 4. 학생삭제
//	 * 
//	 * 5. 학생 파일로 저장
//	 */
//
//	public static void main(String[] args) throws Exception {
//		Student[] student = new Student[50];
//
//		File a = new File("a");
//		if (a.exists()) {
//			FileInputStream fis = new FileInputStream(new File("a"));
//			ObjectInputStream ois = new ObjectInputStream(fis);
//			student = (Student[]) ois.readObject();
//		}
//
//		// BufferedReader br = new BufferedReader(new InputStreamReader(fis));
//
//		Scanner scan = new Scanner(System.in);
//		while (true) {
//			System.out.println("뭐할래요? 1,2,3,4,5 선택");
//			int select = scan.nextInt();
//			System.out.println("select = " + select);
//
//			if (select == 1) {// 학생등록
//				for (int i = 0; i < 50; i++) {
//					scan.nextLine();
//					System.out.println("이름은? ");
//					String name = scan.nextLine();
//					System.out.println("성별은? ");
//					String gender = scan.nextLine();
//					System.out.println("나이? ");
//					int age = scan.nextInt();
//					student[i] = new Student(name, gender, age);
//				}
//			} else if (select == 2) {// 학생조회
//				System.out.println("===학생조회===");
//				for (int i = 0; i < student.length; i++) {
//					System.out.println((i + 1) + "." + " = " + student[i]);
//					if (student[i] != null)
//						student[i].print();
//				}
//				System.out.println("===========");
//
//			} else if (select == 3) {// 학생수정
//				scan.nextLine();
//				System.out.println("수정할 학생: ");
//				int num = scan.nextInt();
//				scan.nextLine();
//				System.out.println("이름은? ");
//				String name = scan.nextLine();
//				System.out.println("성별은? ");
//				String gender = scan.nextLine();
//				System.out.println("나이? ");
//				int age = scan.nextInt();
//				student[num - 1] = new Student(name, gender, age);
//
//			} else if (select == 4) {// 학생삭제
//				System.out.println("삭제할 학생: ");
//				int num = scan.nextInt();
//				student[num - 1] = null;
//			} else if (select == 5) {// 학생 파일로 저장
//
//			} else {
//				
//			
//				
//				FileOutputStream fos = new FileOutputStream(new File("a"));
//				ObjectOutputStream oos = new ObjectOutputStream(fos);
//				oos.writeObject(student);
//				System.out.println("종료됩니다.");
//				break;
//			}
//		}
//	}
//}

// 썜입력 버퍼 비우기.... 입력버퍼는 읽어서 삭제 가능하
// import java.io.BufferedReader;
// import java.io.Console;
// import java.io.InputStreamReader;
// import java.util.Scanner;

public class Main {
	/*
	 * 1. 학생등록 2. 학생조회
	 *
	 * 3. 학생수정 4. 학생삭제 5. 학생 파일로 저장
	 */

	public static Student inputStudent() {
		Scanner scan = new Scanner(System.in);
		System.out.println("이름은? ");
		String name = scan.nextLine();
		System.out.println("성별은? ");
		String gender = scan.nextLine();
		System.out.println("나이?");
		int age = scan.nextInt();
		Student stu = new Student(name, gender, age);
		return stu;
	}

	public static void main(String[] args) {

		Student[] student = new Student[50];

		File a = new File("a");
		if (a.exists()) {
			FileInputStream fis = new FileInputStream(new File("a"));
			ObjectInputStream ois = new ObjectInputStream(fis);
			student = (Student[]) ois.readObject();
		}
		// C#, java, python...
		// c malloc free 동적으로 메모리할당...
		// ArrayList... Haspmap...
		// python... 배열...동적으로 메모리할당..

		// System.out.println("student[0]="+student[0]);
		// System.out.println("student[1]="+student[1]);
		// System.out.println("student[2]="+student[2]);

		Scanner scan = new Scanner(System.in);
		while (true) {
			System.out.println("뭐할래요? 1,2,3,4 선택");
			int select = scan.nextInt();
			System.out.println("select = " + select);
			if (select == 1) {
				// 학생등록
				Student stu = inputStudent();
				for (int i = 0; i < student.length; i++) {
					if (student[i] == null) {
						student[i] = stu;
						break;
					}
				}
			} else if (select == 2) {
				System.out.println("===학생조회===");
				for (int i = 0; i < student.length; i++) {
					// System.out.println(i+" = "+student[i]);
					if (student[i] != null)
						student[i].print();
				}
				System.out.println("============");
			} else if (select == 3) {
				System.out.println("수정하고 싶은 학생 번호 입력 : ");
				int num = scan.nextInt();

				Student stu = inputStudent();
				student[num] = stu;

				System.out.println("수정되었습니다.");
			} else if (select == 4) {
				System.out.println("삭제하고 싶은 학생 번호 입력 : ");
				int num = scan.nextInt();
				student[num] = null;
				System.out.println("삭제되었습니다.");
			} else {
				FileOutputStream fos = new FileOutputStream(new File("a"));
				ObjectOutputStream oos = new ObjectOutputStream(fos);
				oos.writeObject(student);
				System.out.println("종료됩니다.");
				break;
			}
		}
	}
}
