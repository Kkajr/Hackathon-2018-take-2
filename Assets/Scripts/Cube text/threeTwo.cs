using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class threeTwo : MonoBehaviour
{
    public GameObject vector;
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = string.Format("{0:#.00}", vector.transform.localScale.z);
    }

}
