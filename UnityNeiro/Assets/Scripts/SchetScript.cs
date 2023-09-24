using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SchetScript : MonoBehaviour
{
    private int Game1A;
    private int Game1B;
    private int Game1C;
    private int Game01A;
    private int Game01B;
    [SerializeField] private Text text;
    [SerializeField] private Text text1;
    [SerializeField] private Text text2;
    [SerializeField] private Text text3;
    [SerializeField] private Text text4;
    [SerializeField] private Text text5;
    [SerializeField] private GameObject hameObject;
    [SerializeField] private GameObject hameObject1;

    private void Start()
    {
        Game1A = PlayerPrefs.GetInt("Game1");
        Game1B = PlayerPrefs.GetInt("Game1B");
        Game1C = PlayerPrefs.GetInt("Game1C");
        Game01A = PlayerPrefs.GetInt("Game1A");
        Game01B = PlayerPrefs.GetInt("Game1B");
    }
    public void Game1No()
    {
        Game1A += 1;
        PlayerPrefs.SetInt("Game1", Game1A);
    }
    public void Game1BNo()
    {
        Game1B += 1;
        PlayerPrefs.SetInt("Game1B", Game1B);
    }
    public void Game1СNo()
    {
        Game1C += 1;
        PlayerPrefs.SetInt("Game1C", Game1C);
    }
    public void Game01ANo()
    {
        Game1C += 1;
        PlayerPrefs.SetInt("Game1C", Game1C);
    }
    public void Game01BNo()
    {
        Game1C += 1;
        PlayerPrefs.SetInt("Game1C", Game1C);
    }
    public void Parol()
    {
        if(text.text == "1408ag")
        {
            hameObject.SetActive(false);
            hameObject1.SetActive(true);
            text1.text = Game1A.ToString() + "/12";
            text2.text = Game1B.ToString() + "/12";
            text3.text = Game1C.ToString() + "/12";
            text4.text = Game01A.ToString() + "/60";
            text5.text = Game01B.ToString() + "/60";
            PlayerPrefs.SetInt("Game1", 0);
            PlayerPrefs.SetInt("Game1B", 0);
            PlayerPrefs.SetInt("Game1C", 0);
            PlayerPrefs.SetInt("Game01A", 0);
            PlayerPrefs.SetInt("Game01B", 0);
        }
    }
}
