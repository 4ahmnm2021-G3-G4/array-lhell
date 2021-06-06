using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrays : MonoBehaviour
{
     
        string [] arrayString = new string [4];
        float [] arrayFloat = new float [] {1f, 2f, 3f, 4f};
        int [] arrayInt = {1, 2, 3, 4};
        

    // Start is called before the first frame update
    void Start()
    {
   
        PrintArrayContents(arrayInt);
        DisplayArrayLength(arrayInt);
        ChangeValuesDirectly(arrayInt);
        ChangeImageColors();

    }

    // Update is called once per frame
    void PrintArrayContents(int [] intArray)
    {

            string tmp = "";
            for (int i = 0; i < intArray.Length; i++)
            {
                tmp += intArray[i].ToString() + " ";
            }

    }

    void DisplayArrayLength(int[] intArray)
    {
        print(intArray.Length.ToString());
    
    }

    void ChangeValuesDirectly(int[] intArray)
    {
        intArray[1] = 2;
        intArray[2] = 3;
    }

    void ChangeImageColors()
    {
        GameObject[] images = GameObject.FindGameObjectsWithTag("Black_Image");
        images[2].GetComponent<Image>().color = Color.black;
    }
}

/*Aufgaben

1) Durchlaufen ausgegeben der Werte
2) Länge der Arrays ausgeben durch Debug.Log
3) 2 Werte direkt ändern

4) GameObjects images anlegen, Tag vergeben, Zuweisen und Farbe ändern


*/