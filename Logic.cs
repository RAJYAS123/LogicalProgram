//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace array
//{
//    public class Logic
//    {
//        public class App2
//        {
//            public static void addarr(int[] arr)
//            {
//                int len = arr.Length;
//                int sum = 0;
//                for (int i = 0; i < len; i++)
//                {
//                    sum = sum + arr[i];
//                }
//                System.out.println("total sum-==>" + sum);
//            }
//            public static void shifting(int[] arr2)
//            {
//                int len = arr2.length;
//                int[] temp = new int[len];
//                int j = 0;
//                int k = len - 1;
//                for (int i = 0; i < len; i++)
//                {
//                    if (arr2[i] == 0)
//                    {
//                        temp[k] = arr2[i];
//                        k--;
//                    }
//                    else
//                    {
//                        temp[j] = arr2[i];
//                        j++;
//                    }
//                }
//                arr2 = temp;
//                for (int n:arr2)
//                {
//                    System.out.print(n + ",");
//                }
//                System.out.println();
//            }
//            public static void negetivshifting(int[] arr3)
//            {
//                int len = arr3.length;
//                int[] temp = new int[len];
//                int j = 0;
//                int k = len - 1;
//                for (int i = 0; i < len; i++)
//                {
//                    if (arr3[i] < 0)
//                    {
//                        temp[k] = {
//                            System.out.println("elemet exist=>" + i);
//                            flag = true;
//                            break;
//                        }
//                    }
//                    if (flag == false)
//                    {
//                        System.out.println("Element is not exist");
//                    }

//                }
//                public static void sortarray(int[] arr5)
//                {
//                    int len = arr5.length;
//                    for (int i = 0; i < len - 1; i++)
//                    {
//                        for (int j = i + 1; j < len; j++)
//                        {
//                            if (arr5[i] > arr5[j])
//                            {
//                                int temp = arr5[i];
//                                arr5[i] = arr5[j];
//                                arr5[j] = temp;
//                            }
//                        }
//                    }
//                    for (int n:arr5)
//		{
//                    System.out.print(n + ",");
//                }
//            }
//            public static void rempveDuplicate(int[] arr6)
//            {
//                int len = arr6.length;
//                int[] temp = new int[len];
//                int j = 0;
//                for (int i = 0; i < len - 1; i++)
//                {
//                    if (arr6[i] != arr6[i + 1])
//                    {
//                        temp[j] = arr6[i];
//                        j++;
//                    }
//                }
//                temp[j++] = arr6[len - 1];
//                for (int k = 0; k < j; k++)
//                {
//                    System.out.print(temp[k] + ",");
//                }
//public class App2
//            {
//                public static void addarr(int[] arr)
//                {
//                    int len = arr.length;
//                    int sum = 0;
//                    for (int i = 0; i < len; i++)
//                    {
//                        sum = sum + arr[i];
//                    }
//                    System.out.println("total sum-==>" + sum);
//                }
//                public static void shifting(int[] arr2)
//                {
//                    int len = arr2.length;
//                    int[] temp = new int[len];
//                    int j = 0;
//                    int k = len - 1;
//                    for (int i = 0; i < len; i++)
//                    {
//                        if (arr2[i] == 0)
//                        {
//                            temp[k] = arr2[i];
//                            k--;
//                        }
//                        else
//                        {
//                            temp[j] = arr2[i];
//                            j++;
//                        }
//                    }
//                    arr2 = temp;
//                    for (int n:arr2)
//                    {
//                        System.out.print(n + ",");
//                    }
//                    System.out.println();
//                }
//                public static void negetivshifting(int[] arr3)
//                {
//                    int len = arr3.length;
//                    int[] temp = new int[len];
//                    int j = 0;
//                    int k = len - 1;
//                    for (int i = 0; i < len; i++)
//                    {
//                        if (arr3[i] < 0)
//                        {
//                            temp[k] = arr3[i];
//                            k--;
//                        }
//                        else
//                        {
//                            temp[j] = arr3[i];
//                            j++;
//                        }
//                    }
//                    arr3 = temp;
//                    for (int n:arr3)
//                    {
//                        System.out.print(n + ",");
//                    }
//                }
//                public static void linearsearch(int[] arr4)
//                {
//                    int len = arr4.length;
//                    Scanner sc = new Scanner(System.in);
//                    System.out.println("Enter searched element=>>");
//                    int search = sc.nextInt();
//                    boolean flag = false;
//                    for (int i = 0; i < len; i++)
//                    {
//                        if (search == arr4[i])
//                        {
//                            System.out.println("elemet exist=>" + i);
//                            flag = true;
//                            break;
//                        }
//                    }
//                    if (flag == false)
//                    {
//                        System.out.println("Element is not exist");
//                    }

//                }
//                public static void sortarray(int[] arr5)
//                {
//                    int len = arr5.length;
//                    for (int i = 0; i < len - 1; i++)
//                    {
//                        for (int j = i + 1; j < len; j++)
//                        {
//                            if (arr5[i] > arr5[j])
//                            {
//                                int temp = arr5[i];
//                                arr5[i] = arr5[j];
//                                arr5[j] = temp;
//                            }
//                        }
//                    }
//                    for (int n:arr5)
//                    {
//                        System.out.print(n + ",");
//                    }
//                }
//                public static void rempveDuplicate(int[] arr6)
//                {
//                    int len = arr6.length;
//                    int[] temp = new int[len];
//                    int j = 0;
//                    for (int i = 0; i < len - 1; i++)
//                    {
//                        if (arr6[i] != arr6[i + 1])
//                        {
//                            temp[j] = arr6[i];
//                            j++;
//                        }
//                    }
//                    temp[j++] = arr6[len - 1];
//                    for (int k = 0; k < j; k++)
//                    {
//                        System.out.print(temp[k] + ",");
//                    }
//                }
//                public static void main(String[] args)
//                {
//                    //		int[] arr= {1,4,5,8,7};
//                    //		addarr(arr);
//                    //		int[] arr2= {1,4,7,0,2,0,5,0,8};
//                    //		shifting(arr2);
//                    //		int[] arr3= {1,4,-7,8,-5,2,-3,6,-7};
//                    //		negetivshifting(arr3);
//                    //		int[] arr4= {1,4,7,0,2,0,5,0,8};
//                    //		linearsearch(arr4);
//                    //		int[] arr5= {1,4,7,2,2,10,5,9,8};
//                    //		sortarray(arr5);
//                    //		int [] arr6= {1,1,4,4,7,7,8,8,9,9};
//                    //		rempveDuplicate(arr6);
//                }
//            }
//        }
//}
