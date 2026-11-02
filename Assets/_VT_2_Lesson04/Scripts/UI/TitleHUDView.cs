using System;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// キャンバス(または、UIDocument)を取り扱うクラス
/// </summary>
public class TitleHUDView
{
    // === メンバー変数
    public Action OnClickButtonAction;  // ボタン押下時のイベント

    private Button _clickButton;

    private TextMeshProUGUI _scoreText;

    private Slider _scoreSlider;
    /// <summary>
    /// 初期化メソッド
    /// </summary>
    public void Initialize(Canvas uiCanvas)
    {
        // キャンバス内の要素を取得する
        _clickButton = uiCanvas.GetComponentInChildren<Button>();

        TextMeshProUGUI[] textObjects= uiCanvas.GetComponentsInChildren<TextMeshProUGUI>();
        foreach (var text in textObjects)
        {
            if(text.name == "Value")
            {
                _scoreText = text;
                break;
            }
        }

        _scoreSlider = uiCanvas.GetComponentInChildren<Slider>();

        // イベントの割り当て
        if (_clickButton != null)
            _clickButton.onClick.AddListener(OnClickButton);
    }

    private void OnClickButton()
    {
        Debug.Log("ボタンが入力されました");

        // イベントを発行する
        OnClickButtonAction?.Invoke();
    }

    public void UpdateScore(int score)
    {
        if (_scoreText != null)
        {
            _scoreText.text = score.ToString();
        }
    }

    public void UpdateSlider(int score)
    {
        if(_scoreSlider != null)
        {
            _scoreSlider.value = (score % 10) * 0.1f;
        }
    }
}
