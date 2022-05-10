using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int CloneAmount;
    public Text txtCloneAmount;

    public void CloneObject()
    {
        CloneAmount = int.Parse(txtCloneAmount.text);
        int cantDeCubos = 0;

        while(cantDeCubos < CloneAmount)
        {
            Instantiate(objectToClone);
            cantDeCubos += 1;
        }
    }
}
