using UnityEngine;

public class TitleHUDController
{
    // === メンバー変数
    private TitleHUDView _view;             // HUDのビュー
    private TitleSceneState _sceneState;    // シーンの状態

    // === コンストラクタ
    public TitleHUDController(TitleHUDView view, TitleSceneState sceneState)
    {
        _view = view;
        _sceneState = sceneState;

        // ボタン押下時のイベントを登録
        _view.OnClickButtonAction += OnClickButtonRequest;
    }

    private void OnClickButtonRequest()
    {
        _sceneState.AddScore();
        _view.UpdateScore(_sceneState.Score);
        _view.UpdateSlider(_sceneState.Score);
    }
}
