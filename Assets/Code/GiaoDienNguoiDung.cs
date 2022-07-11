using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiaoDienNguoiDung : MonoBehaviour
{
    public Text scoreText;

    public GameObject gameoverPanel;

    public void SetScoreText(string txt)
    {
        if (scoreText)
            scoreText.text = txt;
    }    

    public void ShowGameoverPanel(bool isShow)
    {
        //setActive dùng ?? hi?n ho?c ?n isshow, if true thì hi?n isshow và ng??c l?i
        if (gameoverPanel)
            gameoverPanel.SetActive(isShow);
    }
}
