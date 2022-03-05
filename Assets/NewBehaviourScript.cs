using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    ///public List<GameObject> Children;
    public Text WordToGuess;
    public InputField InputWord;
    // Start is called before the first frame update
    void Start()
    {
         
         foreach (Transform child in transform)
         {
             if (child.tag == "Word")
             {
               // WordToGuess = (Text)child.gameObject;
                
             }
             else if (child.tag == "Input")
             {
                //InputWord = child.gameObject;
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
