using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("버그픽스");
            Console.WriteLine("둘째 버그픽스");
            //있는코드 볼수있음 : f12/// random볼때등
            //천천히 반복 , 초단위
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    Thread.Sleep(2000);//2초간 잠깐 멈춤

            //}

            //함수 4가지 형태 존재함
            //1. 아무 입력을 요구하지 않고, 결과물 반환이 없는형태
            //2. 입력을 요구하고, 연산 후 반환이 없는 형태의 함수
            //3. 아무 입력을 요구하지 않고, 결과물 반환이 있는 형태의 함수
            //4. 입력값을 요구하고, 연산 후 반환이 있는 형태의 함수

            // 함수에는 계산을 거쳐 나온 결과를 앞으로 '반환값' 이라고 부를거임
            // 준비물 주는걸 '인자값' 이라고 부를거임

            //string dd = "hello good moning";

            //TellWhatISaid(dd);//인자값 매개변수
            //TellWhatISaid(Console.ReadLine());

            //NameAndGrad(9, "dd");


            // 함수
            //인자값X 반환값X
            //static void nn()
            //{
            //    Console.WriteLine("인자값X 반환값X");
            //}

            //인자값X 반환값0
            //static int nn()
            //{
            //    Console.WriteLine("인자값X 반환값0");
            //    return 55; 55로 반환
            //}

            //인자값0 반환값X
            //static void nn(int a, int b) //(int a, int b)를 인자값이라고 부름
            //{
            //    Console.WriteLine("인자값0 반환값X");
            //    Console.WriteLine("a = {0}, b = {1}",a,b);
            //}

            //인자값0 반환값0
            //static int nn(int a, int b)
            //{
            //    Console.WriteLine("인자값0 반환값0");
            //    return a+b; //입력 받고 반환
            //}



            //GetPI();
            //double num = 1;
            //num = GetPI() - num;
            //Console.WriteLine(num);

            //double temp;
            //temp = calArea(12.45, 78.52);
            //Console.WriteLine(temp);

            //double calculatedArea;

            //isBiggerThan100(10,20,out calculatedArea);
            //Console.WriteLine(calculatedArea);


            //int a = 10;
            //int b = 20;


            //Console.WriteLine(a);
            //Console.WriteLine(b);



            //// Myswap( a, b);
            //SwapNumByRef(ref a, ref b);



            //Console.WriteLine(a);
            //Console.WriteLine(b);

            int[] myArr = new int[] { 1, 2, 3, 4 };

            ArrTest(myArr);
            Console.WriteLine("메인");
            Console.WriteLine(myArr[2]);
            
        }


        //배열을 인자값으로 넘기는 방법
        //배열은 있던주소에서 값을 매김   배열은 함수 안쓰는게좋다?
        static void ArrTest(int[] inputArray)
        {
            inputArray[2] = 111;
            Console.Write("함수 안");
            Console.WriteLine($"{inputArray[2]}");
        }





        //반환값 함수이름(인자값)
        //{
        //  내용
        //}
        //반환값X
        static void PrintMyName()
        {
            Console.WriteLine("cdo");
            Console.WriteLine("hello");
            Console.WriteLine("what's happen");
        }


        //반환값X  기능 만들고 싶은데 , 결과는 딱히 없고, 준비물은 잇엇으면 좋겟고 
       static void TellWhatISaid(string inputString)
        {
            Console.WriteLine("당신은 이런 말을 했습니다 : " + inputString);
        }

        //준비물로 정수, 점수 문자열 이름을 받아오면 묶어서 출력하는 기능
        static void NameAndGrad(int grad, string name)
        {
            grad = grad + 5;
            Console.WriteLine($"{name}의 점수는 {grad} 입니다");



        }

        //반환값 0 PI를 반환하는 함수 제작, 준비물 딱히 필요 없음
        static double GetPI()
        {
            double pi = 3.14159265;
            Console.WriteLine("파이 값을 반환하였습니다");
            return pi;
            //return 뒤에 다 사라짐

        }

        //벌써 피곤한데 , 

        //return 반환값
        static double calArea(double height, double width)
        {
            double area; //지역 변수
            area = height * width / 2;

            return area;
        }

        //두 실수를 받고, 면적을 구해보고 100보다 크면 참을 반환
        //area도 결과로 받고 싶어
        //함수 결과값이 두개 out
        static bool isBiggerThan100(double height, double width, out double myArea)
        {
            double area; //지역 변수            
            area = height * width / 2;

            myArea = area;

            bool isBigger = area > 100;
            
            return isBigger;
        }
        
        //변수2개가 추가댐 
        static void Myswap(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

            Console.Write("함수 안 : ");
            Console.WriteLine($"{a} {b}");

            //return a;

        }
        

        //ref 같은주소라고 생각
        static void SwapNumByRef(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

            Console.Write("함수 안 : ");
            Console.WriteLine($"{a} {b}");



        }









    }
}
