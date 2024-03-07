using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ButtonnController : MonoBehaviour
{
    public Image LeftImage;
    public Image RightImage;

    public Text LeftText;
    public Text RightText;

    public Text ButtonText;

    private Color32 m_yellowColor = Color.yellow;
    private Color32 m_redColor = Color.red;
    private Color32 m_greedColor = Color.green;

    private bool m_isStarted = false;
    public void OnClickButton()
    {
        if(m_isStarted)
            StopTimer();
        else
            StartTimer();
    }
    private void StartTimer()
    {
        UIchanges();
        m_isStarted = true;
        StartRandomCoroutine();
    }
    private void StopTimer()
    {
        UIchanges();
        m_isStarted = false;
        StopAllCoroutines();
    }
    private void UIchanges()
    {
        if (m_isStarted)
        {
            LeftImage.color = m_yellowColor;
            RightImage.color = m_yellowColor;

            LeftText.text = 0.ToString();
            RightText.text = 0.ToString();

            ButtonText.text = "Start";
        }
        else
        {
            LeftImage.color = m_redColor;
            RightImage.color = m_redColor;

            ButtonText.text = "Stop";
        }
    }
    private void StartRandomCoroutine()
    {
        int randomNumber = Random.Range(0, 11);
        if (randomNumber > 5)
            StartCoroutine(SeconndCoroutine());
        else
            StartCoroutine(FirstCoroutine());
    }
    
    #region Coroutines
    private IEnumerator FirstCoroutine()
    {
        LeftImage.color = m_greedColor;

        int second = Random.Range(10, 21);
        while (second > 0)
        {
            LeftText.text = second.ToString();
            yield return new WaitForSeconds(1f);
            second--;
        }

        LeftText.text = 0.ToString();
        LeftImage.color = m_redColor;

        StartCoroutine(SeconndCoroutine());

    }
    private IEnumerator SeconndCoroutine()
    {
        RightImage.color = m_greedColor;

        int second = Random.Range(10, 21);
        while (second > 0)
        {
            RightText.text = second.ToString();
            yield return new WaitForSeconds(1f);
            second--;
        }

        RightText.text = 0.ToString();
        RightImage.color = m_redColor;

        StartCoroutine(FirstCoroutine());
    }
    #endregion
}
