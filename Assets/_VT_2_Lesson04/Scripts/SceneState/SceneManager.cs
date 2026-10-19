using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // === メンバー変数 === //
    private IState _currentSceneState;      // 現在実行中の画面

    void Start()
    {
        _currentSceneState = new TitleSceneState();     // タイトル画面の状態を生成
        _currentSceneState.Enter();                     // タイトル画面を開始する
    }

    void Update()
    {
        _currentSceneState.Execute();                   // 現在の画面を実行中
    }

    /// <summary>
    /// 画面の状態を切り替える
    /// </summary>
    public void ChangeScene(IState nextScene)
    {
        // 現在の画面処理を終了させる
        _currentSceneState.Exit();

        // 現在の画面を、次の画面で上書き
        _currentSceneState = nextScene;

        // 新しい画面を開始させる
        _currentSceneState.Enter();
    }
}
