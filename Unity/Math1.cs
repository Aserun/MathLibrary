using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Math1 : MonoBehaviour {
    //小学1年生用の数学自動生成クラス
    //何故か基本情報処理も混ざってる
    public Text tx;
	// Use this for initialization
	void Start () {
        //2桁
        for (int i = 0; i < 10000; i++)
        {
            int result = Random.Range(0, 10000);
            Debug.Log(AutoMathTasu(result) + " = " + result);
            // a: 1 ～
        }
	}
    //例：N歳を20歳にするために何進法にすればよいか
    //20歳にするためのN進法を求めるアルゴリズム
    //入力は年齢
    //出力はN進法かどうか
    string AgeToN(int n)
    {

        return "20";
    }
    //2進法から10進法にするアルゴリズム
    string From16To10(string n)
    {
        int count = n.Length - 1;
        int sum = 0;
        int b = 1;
        while (0 <= count)
        {
            sum +=  ToInt(n[count].ToString()) * b;
            b = b * 16;
            count--;
        }

        return sum.ToString();
    }
    int ToInt(string s)
    {
        int result = 0;
        switch (s) {
            case "F":
                result = 15;
                break;
            case "E":
                result = 14;
                break;
            case "D":
                result = 13;
                break;
            case "C":
                result = 12;
                break;
            case "B":
                result = 11;
                break;
            case "A":
                result = 10;
                break;
            default:
                result = int.Parse(s);
                break;
        }
        return result;
    }
    //8進法から10進法にするアルゴリズム
    string From8To10(string n)
    {
        int count = n.Length - 1;
        int sum = 0;
        int b = 1;
        while (0 <= count)
        {
            sum += int.Parse(n[count].ToString()) * b;
            b = b * 8;
            count--;
        }

        return sum.ToString();
    }
    //2進法から10進法にするアルゴリズム
    string From2To10(string n)
    {
        int count = n.Length - 1;
        int sum = 0;
        int b = 1;
        while (0 <= count)
        {
            sum += int.Parse(n[count].ToString()) * b;
            b =b * 2;
            count--;
        }

        return sum.ToString();
    }
    //10進法から2進法にするアルゴリズム
    string From10To2(int n)
    {
        List<int> sinhou = new List<int>();
        int count = 0;

        while (true)
        {
            int i = n / 2;
            if (n % 2 == 0)
            {
                //割り切れたら0を入れる
                sinhou.Add(0);
                count++;
            }
            else
            {
                //割り切れなかったら1を入れる
                sinhou.Add(1);
                count++;
            }
            n = i;
            if (n == 1)
            {
                sinhou.Add(1);
                count++;
                break;
            }
            else if (n == 0)
            {
                sinhou.Add(0);
                count++;
                break;
            }
        }
        string str = "";
        for (int i = count - 1; i >= 0; i--)
        {
            str += sinhou[i];
        }
        return str;
    }
    //10進法から16進法にするアルゴリズム
    string From10To16(int n)
    {
        List<int> sinhou = new List<int>();
        int count = 0;

        while (true)
        {
            int i = n / 16;

            if (n % 16 == 0)
            {
                //割り切れたら0を入れる
                sinhou.Add(0);
                count++;
            }
            else
            {
                int i1 = n % 16;
                //割り切れなかったら1を入れる
                sinhou.Add(i1);
                count++;
            }
            n = i;
            if (n == 1)
            {
                sinhou.Add(1);
                count++;
                break;
            }
            else if (n == 0)
            {
                int i1 = n % 16;
                if (i1 == 0)
                {
                    break;
                }
                sinhou.Add(i1);
                count++;
                Debug.Log(n);
                break;
            }

        }
        string str = "";
        for (int i = count - 1; i >= 0; i--)
        {
            str += ToABDCEF(sinhou[i]);
        }
        return str;
    }
    string ToABDCEF(int s) {
        string str = s.ToString();

        switch (s)
        {
            case 15:
                str = "F";
                break;
            case 14:
                str = "E";
                break;
            case 13:
                str = "D";
                break;
            case 12:
                str = "C";
                break;
            case 11:
                str = "B";
                break;
            case 10:
                str = "A";
                break;
        }

        return str;
    }
    //10進法から8進法にするアルゴリズム
    string From10To8(int n)
    {
        List<int> sinhou = new List<int>();
        int count = 0;

        while (true)
        {
            int i = n / 8;

            if (n % 8 == 0)
            {
                //割り切れたら0を入れる
                sinhou.Add(0);
                count++;
            }
            else
            {
                int i1 = n % 8;
                //割り切れなかったら1を入れる
                sinhou.Add(i1);
                count++;
            }
            n = i;
            if (n == 1)
            {
                sinhou.Add(1);
                count++;
                break;
            }
            else if (n == 0)
            {
                int i1 = n % 8;
                if (i1 == 0) {
                    break;
                }
                sinhou.Add(i1);
                count++;
                Debug.Log(n);
                break;
            }

        }
        string str = "";
        for (int i = count - 1; i >= 0; i--)
        {
            str += sinhou[i];
        }
        return str;
    }
    //Random 2～100
    // x の範囲は2～99
    //出力はstring
    //足し算の問題
    //2桁の答えを出力する足し算のアルゾリズム
    //答え:2 ～ 99
    //自動生成足し算
    public string AutoMathTasu(int x)
    { 

        int a; 
        int b;

        if (Random.Range(0, 2) == 1)
        {
            a = Random.Range(1, x / 2);
            b = x - a;


        }
        else {
            b = Random.Range(1, x / 2);
            a = x - b;
        }

         return (a.ToString() + " + " + b.ToString());




    }
    //Random 2～99
    // x の範囲は2～99
    //出力はstring
    //引き算の問題
    // 2桁の答えを出力する引き算のアルゴリズム
    //答え:2～98
    //自動生成引き算
    public string AutoMathHiku(int x)
    {
 
        if (x < 2 || x >= 99)
        {
            return "Error";
        }
        int a;
        int b;

        do
        {
            a = Random.Range(x+1, x + 98);
            b = -(x - a);
        } while (a >= 100);
        return (a.ToString() + " - " + b.ToString());

    }

}
