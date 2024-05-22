using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Victory : MonoBehaviour
{
    public GameObject VictoryText;
    public static GameObject VictoryStatic;
    public static bool victory;
    public GameObject VictoryImage;
    public static GameObject VictoryImageStatic;
    void Start()
    {
        victory = false;
        Victory.VictoryStatic = VictoryText;
        Victory.VictoryStatic.gameObject.SetActive(false);
        Victory.VictoryImageStatic = VictoryImage;
        Victory.VictoryImageStatic.gameObject.SetActive(false);

    }
    private void Update()
    {
        if (victory == true)
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1;
            }
    }
    public static void show()
    {
        Victory.VictoryStatic.gameObject.SetActive(true);
        Victory.VictoryImageStatic.gameObject.SetActive(true);

    }
}
