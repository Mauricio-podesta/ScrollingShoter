using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text TimeTXT;
    public float TimeGame = 30f;
    void Start()
    {
        StartCoroutine(Comenzarcronometro(30));
    }

    // Update is called once per frame
    void Update()
    {

        if (TimeGame == 0)
        {
            Victory.show();
            Time.timeScale = 0;
            Victory.victory = true;
        }
        TimeTXT.text = "Survive: " + TimeGame.ToString();
    }
    public IEnumerator Comenzarcronometro(float valorcronometro = 30)
    {
        TimeGame = valorcronometro;
        while (TimeGame > 0)
        {
            yield return new WaitForSeconds(1.0f);
            TimeGame--;
        }
    }
}
