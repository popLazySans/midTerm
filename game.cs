using System;
using System.Collections.Generic;
public class game
{
    public List<char> wordList;

    public game()
    {
        wordList = new List<char>();
    }
    public void addList(char w)//เพิ่มค่าในลิส
    {
        wordList.Add(w);
    }

    public void getList()//เช็คค่าในลิส
    {
        wordList.ForEach(value => { Console.Write(value); });
    }
    public void checkList(char alpha, char[] alphaList)//ตัวเช็คคำที่ผู้ทายทายถูกต้อง
    {
        for (int i = 0; i < alphaList.Length; i++)
        {
            if (alpha == wordList[i])
            {
                alphaList[i] = alpha;


            }
        }
    }

}
