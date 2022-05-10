using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;

    public void CloneObject()
    {
        int cantDeCubos = 0;

        while(cantDeCubos < 3)
        {
            Instantiate(objectToClone);
            cantDeCubos += 1;
        }
    }
}
