using System;
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

    /// <summary>
    /// 初期化メソッド
    /// </summary>
    public void Initialize(Canvas uiCanvas)
    {
        // キャンバス内の要素を取得する
        _clickButton = uiCanvas.GetComponentInChildren<Button>();

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
}
