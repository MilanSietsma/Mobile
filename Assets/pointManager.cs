using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pointManager : MonoBehaviour
{

    [SerializeField]TMP_Text pointCounter;
    public double points = 0;

    private void Update()
    {
        pointCounter.text = " " + points;
    }
}
