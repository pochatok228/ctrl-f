using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_typing : MonoBehaviour
{
    public string text_to_type = "> COVID-2019-nCOV /> относится к роду Betacoronavirus/> выявлен в конце 2019 года/> вызвает опасное инфекционное/> заболевание 'Covid 19'";
    public GameObject text_object;
    public int iterator = 0;
    public string current_typed = "";
    public int current_typed_length = 0;

    public int delay = 0;


    // Start is called before the first frame update


    void Start()
    {
    }
 

    // Update is called once per frame
    void Update()
    {
        if (iterator == 0)
        {
            current_typed_length = current_typed.Length;
            if (current_typed_length - text_to_type.Length == 0) 
            { 
                delay++;
                if (delay == 300)
                {
                    iterator = 0;
                    delay = 0;
                    current_typed = "";
                }
            }
            else
            {
                if (text_to_type[current_typed_length] == '/')
                {
                    current_typed = current_typed + "\n";
                }
                else
                {
                    current_typed = current_typed + text_to_type[current_typed_length];
                }
                text_object.GetComponent<TextMesh>().text = current_typed;
                // Debug.Log(current_typed);
            }
        }
        else if (iterator == 25) iterator = 0;
        else iterator++;
        
    }
}
