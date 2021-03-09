using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour
{
    // this variable can be edited in unity 
    public string startMessage;
    public string spamMessage;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError(startMessage);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning(spamMessage);
    }
}
