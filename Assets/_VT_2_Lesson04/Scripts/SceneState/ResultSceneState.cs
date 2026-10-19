using UnityEngine;
using UnityEngine.InputSystem;

public class ResultSceneState : IState
{
    // === メンバー変数 === //
    private SceneManager _sceneManager;
    public void Enter()
    {
        Debug.Log($"{GetType().Name}が始まります");

        // SceneManager を取得
        _sceneManager = GameObject.FindAnyObjectByType<SceneManager>();
    }

    public void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // TitleSceneState へ遷移
            _sceneManager.ChangeScene(new TitleSceneState());
        }
    }

    public void Exit()
    {
        Debug.Log($"{GetType().Name}が終了します");
    }
}
