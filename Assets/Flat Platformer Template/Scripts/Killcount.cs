using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Killcount : MonoBehaviour
{
    public static int KillcountValue = 0;
    Text killcount;

    // Start is called before the first frame update
    void Start()
    {
     killcount = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
     killcount.text = "Kills: " + KillcountValue;   
    }
}
