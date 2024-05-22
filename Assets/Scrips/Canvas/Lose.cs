using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public GameObject LoseText;
    public static GameObject LoseStatic;
    public static bool lose;
    public GameObject LoseImage;
    public static GameObject LoseImageStatic;
    void Start()
    {
        lose = false;
        Lose.LoseStatic = LoseText;
        Lose.LoseStatic.gameObject.SetActive(false);
        Lose.LoseImageStatic = LoseImage;
        Lose.LoseImageStatic.gameObject.SetActive(false);

    }
    private void Update()
    {
        if (lose == true)
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1;
            }
    }
    public static void show()
    {
        Lose.LoseStatic.gameObject.SetActive(true);
        Lose.LoseImageStatic.gameObject.SetActive(true);

    }
}
