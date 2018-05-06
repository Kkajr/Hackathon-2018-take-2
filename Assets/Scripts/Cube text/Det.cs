using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Det : MonoBehaviour {
    public GameObject vector;
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = string.Format("Determinant: {0:#.00}", vector.transform.localScale.z * vector.transform.localScale.y * vector.transform.localScale.x);
    }
}
