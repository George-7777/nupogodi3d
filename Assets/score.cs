using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{
    public int Scor;
    public TMP_Text text;
    void Start()
    {
        
    }

    
    void Update()
    {
        text.text = Scor.ToString();
    }
    public void Add()
    {
        
        Scor++;
    }
}
