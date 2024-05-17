using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class IntroText : MonoBehaviour
{
    public Text dialogText;
    public GameObject parent;
    public Image bgImage;
    public List<string> texts = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("isFirstTime", 0) == 0)
        {
            Sequence sequence = DOTween.Sequence();
            foreach (string textDialog in texts)
            {
                string currentText = textDialog; // Temporary variable to hold the current value of textDialog
                sequence.AppendCallback(() => dialogText.text = "");
                sequence.Append(DOTween.To(() => dialogText.text, x => dialogText.text = x, currentText, 1.5f)
                    .SetEase(Ease.Linear));
                sequence.AppendInterval(1.5f);
            }

            sequence.Append(bgImage.DOColor(new Color(0, 0, 0, 0), 1));
            sequence.OnComplete(() => { parent.SetActive(false); });
            PlayerPrefs.SetInt("isFirstTime", 1);
        }
        else
        {
            parent.SetActive(false);
        }
    }
}