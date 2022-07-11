using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCotroller : MonoBehaviour
{
    public GameObject ball;
    //Kho?ng time t?o ra qua b�ng ti?p theo sau l?n t?o tr??c
    public float spawnTime;
    float m_spawnTime;

    int m_score;
    bool m_isGameOver;

    GiaoDienNguoiDung m_ui;

    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
        m_ui = FindObjectOfType<GiaoDienNguoiDung>();
        m_ui.SetScoreText("Score: " + m_score);
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;

        if (m_isGameOver)
        {
            m_spawnTime = 0;
            m_ui.ShowGameoverPanel(true); 
            //g?t t?t c? c�c d�ng ? d??i
            return;
        }

        if (m_spawnTime <= 0)
        {
            SpawnBall();

            m_spawnTime = spawnTime;
        }
    }
    public void SpawnBall()
    {
        //vector2 ch? c� x, y
        Vector2 spawnPos = new Vector2(Random.Range(-7, 7), 6);

        if (ball)
        {
            //t?o ra ??i t??ng(??u v�o, v? tr� mu?n kh?i t?o, g�c xoay c?a ??i t??ng)
            //Quaternion.identity: kh�ng mu?n xoay
            Instantiate(ball, spawnPos, Quaternion.identity);
        }
    }
    public void Replay()
    {
        m_score = 0;
        m_isGameOver = false;
        m_ui.SetScoreText("Score: " + m_score);
        m_ui.ShowGameoverPanel(false);
    }    
    //l?y gi� tr?
    public void SetScore(int value)
    {
        m_score = value;
    }
    //L?u l?i gi� tr?
    public int GetScore()
    {
        return m_score;
    }
    //T?ng ?i?m khi h?ng ???c b�ng
    public void IncrementScore()
    {
        m_score++;

        m_ui.SetScoreText("Score: " + m_score);
    }
    
    public bool IsGameover()
    {
        return m_isGameOver;
    }

    public void SetGameoverState(bool state)
    {
        m_isGameOver = state;
    }
}
