using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using System;

public class AdventCode1 : MonoBehaviour
{
    public List<string> textArray = new List<string>();

    int [] data; 
    public TextAsset textAsset;
    public string fileName;
    void Start()
    {    
        for (int i = 0; i < textAsset.dataSize; i++)
        {  
        textArray[i] = textAsset.text.Split("\n").ToString(); 
        Debug.Log(i +  " is " + textArray[i]);
        }

        
    }
}
#region Test
/*

for (int i = 0; i < textArray.Count; i++)
        {       
                
    
                Debug.Log(i +  " is " + textArray[i]);
                if (textArray[i]!=" \n")
                {
                data[i] = int.Parse(textArray[i]);
                Debug.Log(data[i]);
                }
                else{
                Debug.Log("break;");
                break;

                }
    
         }
    **littlefurther*
    textArray = textAsset.text.Split('\n').ToList(); 

    for (int i = 0; i < textArray.Count; i++)
    {
        if (textArray[i]!="\n\n")
                {
                data[i] == textArray.ConvertAll(textArray[i], int.Parse);
                Debug.Log(sum);    
                }
        else 
        { 


        }
         break;
    }


    **little closer**



        {
        if (textArray[i]!="\n\n")
                {
                var sum =+ textArray[i].(text => int.TryParse(text, out var number) ? number : 0);
                Debug.Log(sum);    
                }
         break;
    }

    **getting there**
    for (int i = 0; i < textArray.Count; i++)
    { 
        Debug.Log("The element at index" + i + " has a value of " + textArray[i]);
    }

    ** WHAT YOU LAST TRIED **
      int i = 0;
        if ( i < textArray.Count && textArray[i]!="\n\n")
                {             
                var sum = textArray.Sum(text => int.TryParse(text, out var number) ? number : 0);
                Debug.Log(sum);    
                }   

    ** FROM ANOTHER FILE**
    public int[] ProcessArrays(int[] data)
    { 
        data = new int[20];
        for (int i = 0; i < data.Length; i++)
        {
            data [i] = Random.Range(0, 100);
            Debug.Log("The element at index" + i + " has a value of " + data[i]);
        }
        Debug.Log("winner is " + data[0]);
        return data;
    }
*/
#endregion