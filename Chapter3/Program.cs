using System;
using System.Globalization;
using static System.Console;


//namespace Chapter3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            WriteLine("Chapter3");


//WriteLine("3_4_1_1");


//sbyte a = -10;
//byte b = 40;


//WriteLine($"a = {a}, b = {b}");


//short c = -30000;
//ushort d = 60000;


//WriteLine($"c = {c}, d = {d}");


//int e = -1000_0000;
//uint f = 3_0000_0000;


//WriteLine($"e = {e}, f = {f}");


//long g = -5000_0000_0000;
//ulong h = 200_0000_0000_0000_0000;


//WriteLine($"g = {g}, h = {h}");


//WriteLine("3_4_1_2");


//byte a = 240;
//WriteLine($"a = {a}");


//byte b = 0b1111_0000;
//WriteLine($"b = {b}");


//byte c = 0XF0;
//WriteLine($"c = {c}");


//uint d = 0x1234_abcd;
//WriteLine($"d = {d}");


//WriteLine("3_4_1_3");


//byte a = 255;
//sbyte b = (sbyte)a;


//WriteLine("a = {0}, b = {1}",a,b);
//WriteLine($"a = {a}, b = {(sbyte)a}");
//WriteLine(a);
//WriteLine(b);
//WriteLine((sbyte)a);


//WriteLine("3_4_1_4");


//uint a = uint.MaxValue;
//byte b = byte.MinValue;


//WriteLine(a);
//WriteLine(b);


//a = a + 1;


//WriteLine(a);


//WriteLine("3_4_2_1");


//float a = 3.1415_9265_3589_7932_3846f;
//WriteLine(a);


//double b = 3.1415_9265_3589_7932_3846;


//WriteLine(b);


//WriteLine("3_4_2_2");


//float a = 3.1415_9265_3589_7932_3846_2643_3832_79f;
//double b = 3.1415_9265_3589_7932_3846_2643_3832_79;
//decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m;


//WriteLine($"a = {a}, b = {b}, c = {c}");


//WriteLine("3_4_3_1");


//char a = '안';
//char b = '녕';
//char c = '하';
//char d = '세';
//char e = '요';


//Write(a);
//Write(b);
//Write(c);
//Write(d);
//Write(e);
//WriteLine();


//WriteLine("3_4_3_2");


//string a = "안녕하세요?";
//string b = "김진태입니다.";


//Write(a);
//WriteLine(b);


//WriteLine(a);
//WriteLine(b);


//WriteLine("3_4_4_1");


//bool a = true;
//bool b = false;


//WriteLine(a);
//WriteLine(b);


//WriteLine("3_4_5_1");


//object a = 100;
//object b = 3.141592653589793238462643383279m;
//object c = true;
//object d = "안녕하세요.";


//WriteLine(a);
//WriteLine(b);
//WriteLine(c);
//WriteLine(d);


//WriteLine("3_4_6_1");


//int a = 123;
//object b = (object)a;
//int c = (int)b;


//WriteLine(a);
//WriteLine(b);
//WriteLine(c);
//WriteLine();


//double x = 3.1414213;
//object y = x;
//double z = (double)y;


//WriteLine(x);
//WriteLine(y);
//WriteLine(z);


//WriteLine("3_4_7_1");


//sbyte a = 127;
//WriteLine(a);


//int b = (int)a;
//WriteLine(b);


//int x = 128;
//WriteLine(x);


//sbyte y = (sbyte)x;
//WriteLine(y);


//WriteLine("3_4_7_2");


//float a = 69.6875f;
//WriteLine("a : {0}", a);


//double b = (double)a;
//WriteLine("b : {0}", b);
//WriteLine("69.6875 == b : {0}", 69.6875 == b);


//float x = 0.1f;
//WriteLine("x : {0}", x);


//double y = (double)x;
//WriteLine("y : {0}", y);
//WriteLine("0.1 == b : {0}", 0.1 == b);


//WriteLine("3_4_7_3");


//int a = 500;
//WriteLine(a);


//uint b = (uint)a;
//WriteLine(b);


//int x = -30;
//WriteLine(x);


//uint y = (uint)x;


//WriteLine(y);


//WriteLine("3_4_7_4");


//float a = 0.9f;
//int b = (int)a;
//WriteLine(b);


//float x = 1.1f;
//int y = (int)x;
//WriteLine(y);


//WriteLine("3_4_7_5");


//int a = 123;
//string b = a.ToString();
//WriteLine(b);


//float c = 3.14f;
//string d = c.ToString();
//WriteLine(d);


//string e = "123456";
//int f = Convert.ToInt32(e);
//WriteLine(f);


//string g = "1.2345";
//float h = float.Parse(g);
//WriteLine(h);


//WriteLine("3_5_1_1"); // p.78
//WriteLine();


//const int MAX_INT = 2147483647;
//const int MIN_INT = -2147483648;


//WriteLine(MAX_INT);
//WriteLine(MIN_INT);
//        }
//    }
//}


namespace Chapter3
{
    class Program
    {
        //enum DialogResult
        //{
        //    YES = 10, NO, CANCEL, CONFIRM = 50, OK
        //}


        static void Main(string[] args)
        {
            WriteLine("Chapter3");
            WriteLine();
            //WriteLine("3_5_1_2");
            //WriteLine();


            //WriteLine((int)DialogResult.YES);
            //WriteLine((int)DialogResult.NO);
            //WriteLine((int)DialogResult.CANCEL);
            //WriteLine((int)DialogResult.CONFIRM);
            //WriteLine((int)DialogResult.OK);


            //WriteLine("3_5_1_3");
            //WriteLine();


            //DialogResult result = DialogResult.CANCEL;


            //WriteLine(result == DialogResult.YES);
            //WriteLine(result == DialogResult.NO);
            //WriteLine(result == DialogResult.CANCEL);
            //WriteLine(result == DialogResult.CONFIRM);
            //WriteLine(result == DialogResult.OK);


            //WriteLine("3_5_1_4");
            //WriteLine();


            //WriteLine((int)DialogResult.YES);
            //WriteLine((int)DialogResult.NO);
            //WriteLine((int)DialogResult.CANCEL);
            //WriteLine((int)DialogResult.CONFIRM);
            //WriteLine((int)DialogResult.OK);


            //WriteLine("3_6_1");
            //WriteLine();


            //int? a = null;
            //int? b = null;


            //WriteLine(a.HasValue);
            //WriteLine(a != null);


            //a = 3;


            //WriteLine(a.HasValue);
            //WriteLine(a != null);
            //WriteLine(a.Value);


            //WriteLine();
            //WriteLine(b.Value);


            //WriteLine("3_7_1");
            //WriteLine();


            //var a = 20;
            //WriteLine("Type : {0}, Value : {1}", a.GetType(), a);


            //var b = 3.1414213;
            //WriteLine("Type : {0}, Value : {1}", b.GetType(), b);


            //var c = "Hello, World!";
            //WriteLine("Type : {0}, Value : {1}", c.GetType(), c);


            //var d = new int[] { 10, 20, 30 };
            //WriteLine("Type : {0}, Value : ", d.GetType());
            //foreach(var e in d)
            //{
            //    WriteLine("{0} ", e);
            //    WriteLine();
            //}


            //WriteLine("3_8_1");
            //WriteLine();


            //System.Int32 a = 123;
            //int b = 456;


            //WriteLine("a type : {0}, value : {1}", a.GetType().ToString(), a);
            //WriteLine("b type : {0}, value : {1}", b.GetType().ToString(), b);


            //System.String c = "abc";
            //string d = "def";


            //WriteLine("c type : {0}, value : {1}", c.GetType().ToString(), c);
            //WriteLine("d type : {0}, value : {1}", d.GetType().ToString(), d);


            //WriteLine("3_9_1_1");
            //WriteLine();


            //string greeting = "Good Morning";


            //WriteLine(greeting);
            //WriteLine();


            //// IndesOf()
            //WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            //WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));


            //// LastIndexOf()
            //WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
            //WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf('o'));


            //// StartsWith()
            //WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
            //WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));


            //// EndsWith()
            //WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
            //WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));


            //// Contains()
            //WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            //WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));


            //// Replace()
            //WriteLine("Replace 'Morning' with 'Evening' : {0}", greeting.Replace("Morning", "Evening"));


            //WriteLine("3_9_1_2");
            //WriteLine();


            //WriteLine("ToLower() : '{0}'", "ABC".ToLower());
            //WriteLine("ToUpper() : '{0}'", "abc".ToUpper());


            //WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));
            //WriteLine("Remove() : '{0}'", "I Don't Love You".Remove(2, 6));


            //WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
            //WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart());
            //WriteLine("TrimEnd() : '{0}'", " No Spaces ".TrimEnd());


            //WriteLine("3_9_1_3");
            //WriteLine();


            //string greeting = "Good Morning.";


            //WriteLine(greeting.Substring(0, 5));
            //WriteLine(greeting.Substring(5));
            //WriteLine();


            //string[] arr = greeting.Split(new string[] { " " }, StringSplitOptions.None);
            //WriteLine("Word Count : {0}", arr.Length);


            //foreach(string element in arr)
            //{
            //    WriteLine("{0}", element);
            //}


            //WriteLine("3_9_1_4");
            //WriteLine();


            //string fmt = "{0, -20}{1,-15}{2, 30}";


            //WriteLine(fmt, "Publisher", "Author", "Title");
            //WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            //WriteLine(fmt, "Hanvbit", "Sanghyun Park", "This is C#");
            //WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");


            //WriteLine("3_9_1_5");
            //WriteLine();


            //WriteLine("10진수 : {0:D}", 123);
            //WriteLine("10진수 : {0:D5}", 123);


            //WriteLine("16진수 : {0:X}", 0xFF1234);
            //WriteLine("16진수 : {0:X8}", 0xFF1234);


            //WriteLine("숫자 : {0:N}", 123456789);
            //WriteLine("숫자 : {0:N0}", 123456789);


            //WriteLine("고정소수점 : {0:F}", 123.45);
            //WriteLine("고정소수점 : {0:F5}", 123.456);


            //WriteLine("공학 : {0:E}", 123.456789);


            //WriteLine("3_9_1_6");
            //WriteLine();


            //DateTime dt = new DateTime(2018, 11, 3, 23, 18, 22);


            //WriteLine("12시간 형식 : {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            //WriteLine("24시간 형식 : {0:yyyy-MM-dd HH:mm:ss (ddd)}", dt);


            //CultureInfo ciKo = new CultureInfo("ko-KR");
            //WriteLine();
            //WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
            //WriteLine(dt.ToString("yyyy-MM-dd hh:mm:ss (dddd)", ciKo));
            //WriteLine(ciKo);


            //CultureInfo ciEn = new CultureInfo("en-US");
            //WriteLine();
            //WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            //WriteLine(dt.ToString("yyyy-MM-dd hh:mm:ss (dddd)", ciEn));
            //WriteLine(ciEn);


            //WriteLine("3_9_1_7");
            //WriteLine();


            //string name = "김튼튼";
            //int age = 23;
            //WriteLine($"{name,-10}, {age:D3}");


            //name = "박날씬";
            //age = 30;
            //WriteLine($"{name}, {age,-10:D3}");


            //name = "이비실";
            //age = 17;
            //WriteLine($"{name}, {(age > 20 ? "성인" : "미성년자")}");


            WriteLine("3_TEST");
            WriteLine();


            WriteLine("1");
            WriteLine();


            WriteLine("사각형의 너비를 입력하세요.");
            string width = ReadLine();


            WriteLine("사각형의 높이를 입력하세요.");
            string height = ReadLine();


            int area = Convert.ToInt32(width) * int.Parse(height);
            WriteLine(area);


            WriteLine();
            WriteLine("2");
            WriteLine();


            WriteLine("int a = 7.3; -> float");
            WriteLine("float b = 3.14; -> 3.14f");
            WriteLine("double c = a * b; -> 형식이 다름");
            WriteLine("char d = abc; -> string");
            WriteLine("string e = '한'; -> char");


            WriteLine();
            WriteLine("3");
            WriteLine();


            WriteLine("값 형식은 스택 형식으로 {}괄호가 끝나는 부분에서 데이터가 쌓인 순서대로 걷히고 제거되지만, 참조 형식은 힙 형식으로 값을 순서대로 아래부터 쌓는건 같지만 힙에는 값을 저장하고 힙에 값의 주소를 스택에 저장한다.");


            WriteLine();
            WriteLine("4");
            WriteLine();


            WriteLine("박싱은 object 형식에 값 형식의 데이터를 할당하려는 시도가 이루어지면 박싱을 수행하여 해당 데이터를 힙에 넣는 과정, 언박싱은 박싱된 값을 꺼내 값 형식 변수에 저장하는 과정");


            WriteLine();
            WriteLine("5");
            WriteLine();


            WriteLine("a는 int 형식, b 는 string 형식");
        }
    }
}


