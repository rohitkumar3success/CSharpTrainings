using System;  
public class Ques8 
{  
    public static void Main()
{
   int i,j,n;
   
	Console.Write("\n\n");
    Console.Write(" first and last number of each row will be 1:\n");
    Console.Write("----------------------------------------------------------------------------");
    Console.Write("\n\n");     
   
   Console.Write("Input number of rows : ");
   n = Convert.ToInt32(Console.ReadLine());    
   for(i=0;i<=n;i++)
   {
     for(j=1;j<=n-i;j++)
	Console.Write(" ");
     for(j=1;j<=i;j++)
       Console.Write("{0}",j);
 
       for(j=i-1;j>=1;j--)
	  Console.Write("{0}",j);
 
     Console.Write("\n");
   }
  } 
}
