using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinBehavior : MonoBehaviour
{
    public static int value ;
    private Text score;
   // public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        value = 0;
        //UI = GameObject.FindGameObjectsWithTag("score");
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score : " + value;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("joueur"))
        {
            
            Destroy(gameObject);
            score.text += value;
            //int coinUI = int.Parse(UI.GetComponent<Text>().text) + value;
            //UI.GetComponent<Text>().text = coinUI + "";
        }
    }
}
