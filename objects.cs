using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class objects : MonoBehaviour
{
    static int count = 3;
    public GameObject image;
    [SerializeField] TextMeshProUGUI text;
    void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(text);
        count = count - 1;
        if(count ==0)
        {
            image.SetActive(true);
        }
    }
}
