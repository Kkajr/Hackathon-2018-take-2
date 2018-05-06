using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class twoTwo : MonoBehaviour
{
    public GameObject vector;
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = string.Format("{0:#.00}", vector.transform.localScale.y);
    }

}
