using System;  
public class Exercise5
{  
    public static void Main() 
{
	int[] arr1 = new int[100];
	int[] arr2 = new int[100];
	int[] arr3 = new int[100];	
    int s1, mm=1,ctr=0;
    int i, j;
       Console.Write("\n\ntotal no of duplicate elements:\n");
       Console.Write("-------\n");	
	   
       Console.Write("Input the number of elements to be stored :");
	   s1 = Convert.ToInt32(Console.ReadLine()); 	   
   
       Console.Write("Input {0} elements in the array :\n",s1);
       for(i=0;i<s1;i++)
            {
	      Console.Write("element - {0} : ",i);
	     arr1[i] = Convert.ToInt32(Console.ReadLine()); 		  
	    }
		for(i=0;i<s1; i++)
        {
		arr2[i]=arr1[i];
		arr3[i]=0;
        }
	for(i=0;i<s1; i++)
        {
		for(j=0;j<s1;j++)
			{
				if(arr1[i]==arr2[j])
				{
				arr3[j]=mm;
				mm++;
				}
			}
			mm=1;
        }

   for(i=0; i<s1; i++)
    {
      if(arr3[i]==2){ctr++;}  
    }
    Console.Write("The no of duplicate elements is: {0} \n", ctr);
    
	Console.Write("\n\n");
  }
}