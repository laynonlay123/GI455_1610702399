using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class TextMatching : MonoBehaviour
{
    public GameObject Search, Gotit ;
    public string Word ;
    public string[] AllName ;
    
    public void SearchName()
    {
        Word = Search.GetComponent<Text>().text ;

        for (int i = 0; i < AllName.Length ; i++)
        {
            if (Word == AllName[i])
            {
                Gotit.GetComponent<Text>().text = "[" + Word + "]" + "Yes it have "; break;
            }
            else
            {
                Gotit.GetComponent<Text>().text = "[" + Word + "]" + "it not have ";
            }
        }
    }
}
