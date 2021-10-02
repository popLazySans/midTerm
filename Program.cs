using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to Hangman Game\n1.Play game\n2.Exit\nPlease Select Menu : ");
            int inputPlay = int.Parse(Console.ReadLine());
            Console.Clear();
            //Menu

            if (inputPlay == 1)
            {

                char[] words = new char[10];//สร้าง array ขึ้นมา

                string[] groupWord = new string[3] { "tennis", "football", "badminton" };
                Random random = new Random();
                int resultRandom = random.Next(0, 3);
                string chooseWord = groupWord[resultRandom];
                //ได้ข้อความจากการสุ่ม

                words = chooseWord.ToCharArray();//เปลี่ยนข้อความเป็น array
                game play = new game();
                int incorrect = 0;
                bool incorrectBool = true;
                string toString;
                //ทั้งหมดนี้เป็นการตั้งตัวแปร

                foreach (char i in words)
                {
                    play.addList(i);
                }
                //นำข้อมูลจาก Array สู้ List

                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = '_';
                  
                }
                //เปลี่ยนข้อมูลใน Array ทั้้งหมดเป็น _


                Console.WriteLine("Play Game HangMan");
             
                while (incorrect != 6)
                {
                   
                    Console.WriteLine("Incorrect Score: {0}",incorrect);
                    foreach (char i in words)
                    {
                        Console.Write(i);   
                    }//เขียนข้อมูลใน Array

                    toString = new string(words);

                    if (toString == chooseWord)
                    {
                        Console.WriteLine("\nYou Win!!!!!");
                        break;
                    }
                    //เช็คค่าข้อความที่ผู้เล่นทำได้และข้อความเฉลย

                    Console.Write("\nInput letter alphabet: ");
                    char inputWord = char.Parse(Console.ReadLine());
                    play.checkList(inputWord, words);
                    //ตรวจสอยและเปลี่ยนค่าที่ถูกต้อง

                    foreach (char i in play.wordList)
                    {
                        if (inputWord == i)
                        {
                            incorrectBool = false;
                        }
                    }
                    if(incorrectBool == true)
                    {
                        incorrect += 1;
                    }
                    incorrectBool = true;
                    //ระบบตัวนับครั้งที่ผิด

                    Console.Clear();
                   
                }
                if (incorrect == 6)
                {
                    Console.WriteLine("Game Over");
                }
            }
            else if (inputPlay ==2)
            {
                
            }
           
            
        }
    }
   

}
