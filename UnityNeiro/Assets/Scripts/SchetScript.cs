using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SchetScript : MonoBehaviour
{
    private int Game1;
    [SerializeField] private Text text;
    [SerializeField] private Text text1;
    [SerializeField] private GameObject hameObject;
    [SerializeField] private GameObject hameObject1;

    private void Start()
    {
        Game1 = PlayerPrefs.GetInt("Game1");
    }
    public void Game1No()
    {
        Game1 += 1;
        PlayerPrefs.SetInt("Game1", Game1);
    }
    public void Parol()
    {
        if(text.text == "1408ag")
        {
            hameObject.SetActive(false);
            hameObject1.SetActive(true);
            text1.text = Game1.ToString() + "/6";
            PlayerPrefs.SetInt("Game1", 0);
        }
    }
}
