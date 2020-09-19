using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int skor;
    public Text skorTxt;

    //Skor ses efekti
    public AudioSource efekt;

    void Start()
    {
        skor = 0;
        skorTxt.text = skor.ToString();
    }
    public void SkorGuncelle()
    {
        skor++;
        skorTxt.text = skor.ToString();
        efekt.Play();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
