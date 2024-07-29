using System;
namespace App{
    class prgm{
        static void Main(string[] args){
            int a=60,b=20,c=30;
            if(a>b && a>c){
                Console.WriteLine("A is greater");
            }
            else if(b>c && b>a){
                 Console.WriteLine("B is greater");
            }
            else{
                 Console.WriteLine("C is greater");
            }
             int day=2;
             switch(day){
                case 1:
                Console.WriteLine("Day 1");
                break;
                case 2:
                 Console.WriteLine("Day 2");
                 break;
                 default:
                  Console.WriteLine("Enter Valid day!!");
                  break;
             }
             int i=0, num=5,j=0;
             while(i<num){
                 Console.WriteLine(i);
                 i++;
             }
             do{
                 Console.WriteLine("Hello!");
                 j++;
             }while(j<num);

             for(i=0;i<num;i++){
                 Console.WriteLine("Welcome you!");
             }
             string[] cars={"vovo","BMW","Maruti"};
                
             foreach(string k in cars){
                 Console.WriteLine(k);
             }
                                       
             }

        }
    }
