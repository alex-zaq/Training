// 2 вопрос - dispose - проблема
// 5 вопрос - приведение к object "abc"+"cba" и "abccba" (равны true) 
// 2,8,9,13 вопрос отложен






//Calc.Method1(a:1,5,c:6);


//class Calc
//{

//    public static void Method1(int a, int b, int c ) => Console.WriteLine($"{a}+{b}+{c}={a+b+c}");



//}




//class MyCustomException:DivideByZeroException{ }


//class Calc
//{


//    public static void Do2()
//    {

//        try
//        {
//            Do();
//        }


//        catch (MyCustomException e)
//        {

//            Console.WriteLine("Catch Mycustom exception");
            
//        }
//        catch (DivideByZeroException e)  
//        {

//            Console.WriteLine("Catch exception");

//        }

//    }



//    public static void Do()
//    {
//        int result = 0;
//        var x = 5;
//        int y = 0;
//        try
//        {
//            result = x / y;
//        }
//        catch (MyCustomException e)
//        {
//            Console.WriteLine("catch divideByZero");
//            throw;
//        }
//        catch (Exception e)
//        {

//            Console.WriteLine("Exception");

//        }
//        finally
//        {

//            throw new MyCustomException();

//        }




//    }

//}












//class TestClass
//{

//    private static object SyncObject = new object();


//    public static void Do2()
//    {

//        lock (SyncObject)
//        {
//            Console.WriteLine("test");
//        }

//    }


//    public static void Do()
//    {

//        lock (SyncObject)
//        {

//            Do2();

//        }

//    }



//}




















//var c = new C();

//A a = c;

//a.Print2(); //A
//a.Print1(); //b
//a.Print2(); //A



//class A
//{

//    public virtual void Print1()
//    {
//        Console.WriteLine("A");

//    }

//    public void Print2()
//    {

//        Console.WriteLine("A");
//    }

//}

//class B:A
//{

//    public override void Print1()
//    {
//        Console.WriteLine("B");
//    }


//}


//class C:B
//{

//    new public void Print2()
//    {

//        Console.WriteLine("c");

//    }


//}





//var s1 = string.Format("{0}{1}","abc","cba");
//var s2 = "abc"+"cba";
//var s3 = "abccba";

//Console.WriteLine(s1==s2);
//Console.WriteLine((object)s1==(object)s2);


//Console.WriteLine(s2==s3);
//Console.WriteLine((object)s2 == (object)s3);


//int i = 1;

//Object obj = i;

//++i;


//Console.WriteLine(i);
//Console.WriteLine(obj);
//Console.WriteLine((short)obj);


//List<Action> actions = new List<Action>();

//for (var i = 0; i < 10; i++)
//{

//    actions.Add(() => Console.WriteLine(i)  );


//}


//foreach (var action in actions)
//{
//    action();
//}



//S s = new S();
//using (s)
//{

//    Console.WriteLine(s.dispose);
//    Console.WriteLine(s.value);


//}


//Console.WriteLine(s.dispose);
//Console.WriteLine(s.value);


public struct S : IDisposable
{

    public bool dispose;
    public int value;
    public void Dispose()
    {

        dispose = true;
        value = 99;

    }


    public bool GetDispose()
    {

        return dispose;

    }

}





//B obj1 = new B();
//A obj2 = new B();

//obj1.Foo();
//obj2.Foo();


//class A
//{

//    public virtual void Foo()
//    {

//        Console.WriteLine(nameof(A));
//    }

//}


//class B:A
//{

//    public override void Foo()
//    {
//        Console.WriteLine(nameof(B));
//    }


//}