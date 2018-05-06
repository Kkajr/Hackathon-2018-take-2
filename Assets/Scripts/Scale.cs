using UnityEngine;
using System.Collections;

public class Scale : MonoBehaviour {
    public static void scale(Vector3 vector, GameObject cube){
        Vector3 qBase = new Vector3(cube.transform.localScale.x, cube.transform.localScale.y, cube.transform.localScale.z);
        cube.transform.localScale = qBase - 3.334f*vector;

     }

}
