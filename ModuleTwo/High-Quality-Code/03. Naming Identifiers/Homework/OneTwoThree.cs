internal class OneTwoThree
{
     internal const int MAX_COUNT = 6;

     public static void Main(string[] args)
     {
         OneTwoThree.InnerClass innerClassInstantion = new OneTwoThree.InnerClass();

         innerClassInstantion.PrintBooleanVariale(true);
     }

     internal class InnerClass
     {
         internal void PrintBooleanVariale(bool isTrue)
         {
             Console.WriteLine(isTrue);
         }
     }
 }