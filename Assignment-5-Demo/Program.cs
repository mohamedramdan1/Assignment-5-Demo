namespace Assignment_5_Demo
{
    internal class Program
    {
        public static void PrintShape(int count, string shape)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(shape);
            }
        }

        public static void SWAP(int X, int Y) //value type passing by value
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }

        public static void SWAP(ref int X,ref int Y) //value type passing by refrence
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }

        public static int SumArray(int[] Arr)   // refrence type passing by value
        {
            int Sum = 0;
            Arr[0] = 100;
            for (int i = 0; i < Arr.Length; i++)
                Sum += Arr[i];
            return Sum;
        }

        public static int SumArray(ref int[] Arr)// refrence type passing by value
        {
            int Sum = 0;
            //Arr[0] = 100;
            Arr = new int[] { 4, 5, 6 };
            for (int i = 0; i < Arr.Length; i++)
                Sum += Arr[i];
            return Sum;
        }

        public static void SumMul(int x , int y , out int sum , out int mul) 
        {
            sum = x + y;
            mul = x * y;
        }

        public static int SumArray01(params int[] Arr) { 
            int Sum = 0;
            for (int i = 0; i < Arr.Length; i++)
                Sum += Arr[i];
            return Sum;
        }

        public static void SumSub(int x , int y , out int sum , out int sub)
        {
            sum = x + y;
            sub = x - y;
        }

        public static int SumDigit(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10; 
                num /= 10;       
            }
            return sum;
        }
        static void Main(string[] args)
        {
            #region Demo
            #region Boxing - UnBoxing
            // refrence type cating : convert from refrence type to refrence type
            // Boxing casting : convert from value type to refrence type [save casting] take the object in stack 
            // put it in  heep
            // Un Boxing casting : convert from  refrence type To value type [un save] take the object in heep
            // put it in stack

            #region Boxing[save cast]
            //object obj = new object();
            //obj = "hfhgfhfh";// refrence type cating
            //obj = 1; //Boing casting cast from value type [int] to refrences type [object]
            //obj = true; //Boing casting cast from value type [bool] to refrences type [object]
            //            //Any Date Type Inherted from object

            //int x = 20;
            //object obj02 = new object();
            //obj02 = x;//Boing casting cast from value type [int] to refrences type [object]
            //Console.WriteLine(obj02);
            #endregion

            #region UnBoxing [un save casting]
            //object obj02 = new object();
            //obj02 = 20;
            ////x = obj02;// error it must make unboxing [Explict cast]
            //int x = (int) obj02;// Un Boxing casting
            //Console.WriteLine(x); 
            #endregion
            #endregion

            #region Nullable Data type
            #region Value type with Nullable
            //int x = null;// int number only
            //int? x = null; // int?  accept null and number
            //Nullable<int> x = null; // old one 
            //int x = 10;
            //int? y = x;
            //int? x = null;
            //int y = (int)x; // warning here becouse (int)x cannot convert null to int 
            // we should make check using if condation
            //int? x = null;
            //int y;
            //if (x != null)
            //{
            //    y = (int) x;
            //}
            //else
            //{
            //    y = 0;
            //}

            // or use property in nullable data type [hasvalue:it is bool true if x donot have null ,value]
            //if (x.HasValue) // x is number not null
            //{
            //    y = x.Value;// it is not casting 
            //}
            //else
            //{
            //    y = 0;
            //}

            // y = x.HasValue ? x.Value : 0; // ternary operator 

            #endregion

            #region refrences type with Nullable
            // it is compiler inhansed mean that say to compiler i know it is have null
            //string name = null;// == string name = defult
            // to hide warning in null using ? 
            //string? name = null;
            //Console.WriteLine(name);
            ////or using !
            //string name01 = null!;
            //Console.WriteLine(name01);

            #endregion
            #endregion

            #region Null Propagetion Operators ?
            //int[] number = null;
            //for (int i = 0; i < number?.Length; i++) //there are warning becouse the refrences [array] is null
            //                                         // مش بيشاور على object 
            //                                         // Null Propagetion Operators الحل هنا ان نستخدم ال 
            //                                         // but Null Propagetion Operators here not good
            //                                         // لانوا هنا كده هيفضل يعمل check على ال lenght  كل شويه
            //                                         // الافضل نعمل if قبل ال loop

            //{
            //    Console.WriteLine(number[i]);
            //}

            //i < number?.Length; 
            // number >>>> object [lenght]
            // number >>>> null [null]

            //if (number != null)
            //{
            //    for (int i = 0; i < number.Length; i++)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}
            // if we want save the number.length in varables use nullable >> int? , and null poropagetion number?.Length
            //int? lenght = number?.Length;
            //or 
            // use null collase operatoe ??
            //int lenght = number?.Length ?? 0;// it mean if the number?.Length retuen null the lenght = 0

            //Employee employee = new Employee();
            //employee.Department = new Department();
            //if (employee !=null)
            //{
            //    if (employee.Department != null)
            //    {
            //        Console.WriteLine(employee.Department.name);
            //    }
            //}
            // or we can use Null propagation operation 
            //Console.WriteLine(employee?.Department?.name ?? " not found");

            #endregion

            #region Function
            // function types 
            // class member function 
            // object member function

            //Program.PrintShape(5, "*-*");// we can delete program becouse function in the same class
            //PrintShape(5, "*-*");// passing by order
            //PrintShape(shape:"*-*",count:5);// passing by name
            //PrintShape();
            //Console.WriteLine("Hellow Mohamed\nhellow\tMO");
            //PrintShape(5,"/*\\");// to make \ meaning make \ after it 
            #endregion

            #region Value Type Parameters
            #region [Passing By Value]
            //int A = 9, B = 4;
            //Console.WriteLine(A); // 9
            //Console.WriteLine(B); // 4
            //SWAP(A, B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion

            #region [Passing By Ref]
            //int A = 9, B = 4;
            //Console.WriteLine(A); // 9
            //Console.WriteLine(B); // 4
            //SWAP(ref A, ref B);
            //Console.WriteLine(A); // 4
            //Console.WriteLine(B); // 9

            #endregion
            #endregion

            #region Reference Type Parameters
            #region [Passing By Value]
            //int[] Numbers = { 1, 2, 3 }; //refrence type
            //Console.WriteLine(SumArray(Numbers));//105 // passing by value [address]
            //Console.WriteLine(Numbers[0]);//100
            #endregion

            #region [Passing By Refrence]
            //int[] Numbers = { 1, 2, 3 }; //refrence type
            //Console.WriteLine(SumArray(ref Numbers));//105 // passing by refrence [address & object]
            //Console.WriteLine(Numbers[0]);//100
            #endregion
            #endregion

            #region Passing by out paramter
            //int A = 10;
            //int B = 20;
            //int sum, mul;
            //SumMul(A, B, out sum, out mul);
            //Console.WriteLine(sum);
            //Console.WriteLine(mul);
            #endregion

            #region Params
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray01(1,2,3));
            #endregion
            #endregion

            #region Assignment

            #region Q1
            /*
            the diffrence between the [Valua type] passing by paramter & passing by refrence that
            passing by paramter : pass the value only in stack , and any change inside the main()
            will not affect the original variable. 

            passing by refrence :using Keyword ref pass value and varaibles in stack , and any change inside the main()
            will affect the original variable, and funcrion swap() will make swap stack frame that have only
            varaible and the parameter will be with main stack frame .
            */
            //ex Passing By Value 
            //int A = 9, B = 4;
            //Console.WriteLine(A); // 9
            //Console.WriteLine(B); // 4
            //SWAP(A, B);
            //Console.WriteLine(A);//9
            //Console.WriteLine(B);//4

            //ex Passing By Refence 
            //int A = 9, B = 4;
            //Console.WriteLine(A); // 9
            //Console.WriteLine(B); // 4
            //SWAP(ref A, ref B); 
            //Console.WriteLine(A); // 4
            //Console.WriteLine(B); // 9
            #endregion

            #region Q2
            /*
            the diffrence between the [Refrence type] passing by paramter & passing by refrence that
            passing by paramter : pass the address only to the parameter in the stack so that parameter in the 
            stack will will have the address of the same address of the refrence in the main(), 
            and any change inside the heep will  affect the original variable. 


            passing by refrence :using Keyword ref pass the refrence and object in heep
            to the method parameter and the method[function] will be in the same stack of main ,and this allow
            Modify the object's contents, and Change the reference itself (e.g.,  new object in the function itself)
            */
            //ex Passing By Value
            //int[] Numbers = { 1, 2, 3 }; //refrence type
            //Console.WriteLine(SumArray(Numbers));//105 // passing by value [address]
            //Console.WriteLine(Numbers[0]);//100

            //ex Passing By Refrence
            //int[] Numbers = { 1, 2, 3 }; //refrence type
            //Console.WriteLine(SumArray(ref Numbers));//15 // passing by refrence [address & object]
            //Console.WriteLine(Numbers[0]);//4
            #endregion

            #region Q3
            //Console.Write("Enter the num01 : ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Enter the num02 : ");
            //int y = int.Parse(Console.ReadLine());
            //int sum, sub;
            //SumSub(x,y,out sum, out sub);
            //Console.WriteLine($"Summation result : {sum}");
            //Console.WriteLine($"Subtraction result : {sub}");
            #endregion

            #region Q4
            //Console.Write("Enter the number : ");
            //int num;
            //while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
            //{
            //    Console.Write("Invalid input! Please enter a valid integer : ");
            //}
            //int res = SumDigit(num);
            //Console.Write($" The sum of the digits of the number {num} is : {res}");
            #endregion
            #endregion
        }
    }
}