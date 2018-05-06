using UnityEngine;
using System.Collections;// MAKE A PARENT SCRIPT IN CANVAS THAT FINDS THE Vectors

public class Determinant : MonoBehaviour
{
    //called at different points in the code
    //float initialY = sphere.tranform.position.y - 1.8f;
    //float finalY = sphere.transform.position.y -1.8f

    float[,] arr1 = new float[3, 3] { { 1f, 1f, 1f }, { 1f, 1f, 1f }, { 1f, 1f, 1f } }; //this should be the base for the new matrix the user will make when they manipulate the vectors 

    Vector3 row1 = new Vector3(1, 0, 0); //initialX - finalX
    Vector3 row2 = new Vector3(0, 1, 0); //initialY - finalY
    Vector3 row3 = new Vector3(0, 0, 1); //initialZ - finalZ





    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //fill arry1 with the values from the 3 vector3's
        int choice = 0;
        int i, j;
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            {
                if (choice == 0)
                {
                    arr1[i, j] = row1[j];
                    if (j == 2) { choice = 1; }
                }
                else if (choice == 1)
                {
                    arr1[i, j] = row2[j];
                    if (j == 2) { choice = 2; }
                }
                else
                {
                    arr1[i, j] = row3[j];
                    if (j == 2) { choice = 0; }
                }
            }



            //calculate determinant of arr1
            /*
            int det = 0;

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {

                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }

                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                        Console.Write("{0}  ", arr1[i, j]);
                    Console.Write("\n");
                }

                for (i = 0; i < 3; i++)
                    det = det + (arr1[0, i] * (arr1[1, (i + 1) % 3] * arr1[2, (i + 2) % 3] - arr1[1, (i + 2) % 3] * arr1[2, (i + 1) % 3]));

                Console.Write("\nThe Determinant of the matrix is: {0}\n\n", det);
            }
        }*/

        }
    }
}