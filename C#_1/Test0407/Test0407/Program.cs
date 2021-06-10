using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0407
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            /**/
            //1차원 배열 초기화
            int[] arrInt = { 10, 20, 30, 40 };
            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.Write(arrInt[i] + " ");
                string str = string.Format("배열[{0}]:{1}", i, arrInt[i]);
                Console.WriteLine(str);
            }

            // 1차원 배열 초기화2
            char[] arrCh = new char[4]
            {
                '이', '박', '김', '최'
            };
            for (int i = 0; i < arrCh.Length; i++)
            {
                Console.Write(arrCh[i] + " ");
            }
            Console.WriteLine();

            //2차원 배열 초기화1
            int[,] arrInt2 =
            {
                {1,2,3 },
                {4,5,6 }
            };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arrInt2[i, j] + " ");
                }
                Console.WriteLine();
            }

            //2차원 배열 초기화2
            const int SIZE_ROW = 2;
            const int SIZE_COL = 3;
            int[,] arrInt3 = new int[SIZE_ROW, SIZE_COL]
            {
                {10, 20, 30 }, {40, 50, 60 }
            };
            for (int i = 0; i < SIZE_ROW; i++)
            {
                for (int j = 0; j < SIZE_COL; j++)
                {
                    Console.Write(arrInt3[i, j] + " ");
                }
                Console.WriteLine();
            }

            //2차원 배열 초기화3
            string[][] arrStr1 = new string[2][];
            arrStr1[0] = new string[] { "홍길동", "김길동", "박길동" };
            arrStr1[1] = new string[] { "전우치" };
            for (int i = 0; i < arrStr1.Length; i++)
            {
                for (int j = 0; j < arrStr1[i].Length; j++)
                {
                    Console.Write(arrStr1[i][j] + " ");
                }
                Console.WriteLine();
            }

            //2차원 배열 초기화4
            int[][] arrInt4 = new int[3][];
            for (int i = 0; i < arrInt4.Length; i++)
            {
                arrInt4[i] = new int[i + 1];
                for (int j = 0; j < arrInt4[i].Length; j++)
                {
                    arrInt4[i][j] = 10 + j;
                    Console.Write(arrInt4[i][j] + " ");
                }
                Console.WriteLine();
            }

            // foreach
            int[] arrEach = { 1, 2, 3, 4, 5 };
            //var 제약 조건
            // 1. 지역변수만 사용 가능
            // 2. 변수선언 및 초기화
            foreach (var i in arrEach) {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //foreach 2차원
            string[,] arrEach2 =
            {
                {"신재용", "박영대" },
                {"하혜련", "하주머니" }
            };

            foreach (var str in arrEach2)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //List  <> 제네릭 클래스
            List<string> list = new List<string>();
            list.Add("홍길동");
            list.Add("김길동");
            list.Add("박길동");
            //배열 구성요소로 삭제
            list.RemoveAt(0);               // 0위치에 있는 데이터 삭제
            list.Remove("김길동");          // 이름으로 삭제
            
            list.Insert(0, "전우치");       // 삽입
            for (int i=0;i<list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            // hash table(key, value)  -> 반드시 키와 값을 가지는 구조
            Hashtable hTable = new Hashtable();
            hTable.Add(1, "홍길동1");
            hTable.Add(2, "김길동1");

            if(hTable.Contains(1))
            {
                Console.WriteLine(hTable[1]);
            }

            //딕셔너리
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("key1", "홍길동1");
            dic.Add("key2", "홍길동2");
            dic.Add("key3", "홍길동3");

            foreach(KeyValuePair<string,string> item in dic)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);  // item.Key  -> {0}, item.Value -> {1}
            }


            foreach(string key in dic.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (string val in dic.Values)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("값 : {0}", dic["key2"]);
        }
    }
}