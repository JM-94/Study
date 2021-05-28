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
//	 * 1. �л���� 2. �л���ȸ 3. �л����� 4. �л�����
//	 * 
//	 * 5. �л� ���Ϸ� ����
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
//			System.out.println("���ҷ���? 1,2,3,4,5 ����");
//			int select = scan.nextInt();
//			System.out.println("select = " + select);
//
//			if (select == 1) {// �л����
//				for (int i = 0; i < 50; i++) {
//					scan.nextLine();
//					System.out.println("�̸���? ");
//					String name = scan.nextLine();
//					System.out.println("������? ");
//					String gender = scan.nextLine();
//					System.out.println("����? ");
//					int age = scan.nextInt();
//					student[i] = new Student(name, gender, age);
//				}
//			} else if (select == 2) {// �л���ȸ
//				System.out.println("===�л���ȸ===");
//				for (int i = 0; i < student.length; i++) {
//					System.out.println((i + 1) + "." + " = " + student[i]);
//					if (student[i] != null)
//						student[i].print();
//				}
//				System.out.println("===========");
//
//			} else if (select == 3) {// �л�����
//				scan.nextLine();
//				System.out.println("������ �л�: ");
//				int num = scan.nextInt();
//				scan.nextLine();
//				System.out.println("�̸���? ");
//				String name = scan.nextLine();
//				System.out.println("������? ");
//				String gender = scan.nextLine();
//				System.out.println("����? ");
//				int age = scan.nextInt();
//				student[num - 1] = new Student(name, gender, age);
//
//			} else if (select == 4) {// �л�����
//				System.out.println("������ �л�: ");
//				int num = scan.nextInt();
//				student[num - 1] = null;
//			} else if (select == 5) {// �л� ���Ϸ� ����
//
//			} else {
//				
//			
//				
//				FileOutputStream fos = new FileOutputStream(new File("a"));
//				ObjectOutputStream oos = new ObjectOutputStream(fos);
//				oos.writeObject(student);
//				System.out.println("����˴ϴ�.");
//				break;
//			}
//		}
//	}
//}

// ���Է� ���� ����.... �Է¹��۴� �о ���� ������
// import java.io.BufferedReader;
// import java.io.Console;
// import java.io.InputStreamReader;
// import java.util.Scanner;

public class Main {
	/*
	 * 1. �л���� 2. �л���ȸ
	 *
	 * 3. �л����� 4. �л����� 5. �л� ���Ϸ� ����
	 */

	public static Student inputStudent() {
		Scanner scan = new Scanner(System.in);
		System.out.println("�̸���? ");
		String name = scan.nextLine();
		System.out.println("������? ");
		String gender = scan.nextLine();
		System.out.println("����?");
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
		// c malloc free �������� �޸��Ҵ�...
		// ArrayList... Haspmap...
		// python... �迭...�������� �޸��Ҵ�..

		// System.out.println("student[0]="+student[0]);
		// System.out.println("student[1]="+student[1]);
		// System.out.println("student[2]="+student[2]);

		Scanner scan = new Scanner(System.in);
		while (true) {
			System.out.println("���ҷ���? 1,2,3,4 ����");
			int select = scan.nextInt();
			System.out.println("select = " + select);
			if (select == 1) {
				// �л����
				Student stu = inputStudent();
				for (int i = 0; i < student.length; i++) {
					if (student[i] == null) {
						student[i] = stu;
						break;
					}
				}
			} else if (select == 2) {
				System.out.println("===�л���ȸ===");
				for (int i = 0; i < student.length; i++) {
					// System.out.println(i+" = "+student[i]);
					if (student[i] != null)
						student[i].print();
				}
				System.out.println("============");
			} else if (select == 3) {
				System.out.println("�����ϰ� ���� �л� ��ȣ �Է� : ");
				int num = scan.nextInt();

				Student stu = inputStudent();
				student[num] = stu;

				System.out.println("�����Ǿ����ϴ�.");
			} else if (select == 4) {
				System.out.println("�����ϰ� ���� �л� ��ȣ �Է� : ");
				int num = scan.nextInt();
				student[num] = null;
				System.out.println("�����Ǿ����ϴ�.");
			} else {
				FileOutputStream fos = new FileOutputStream(new File("a"));
				ObjectOutputStream oos = new ObjectOutputStream(fos);
				oos.writeObject(student);
				System.out.println("����˴ϴ�.");
				break;
			}
		}
	}
}
