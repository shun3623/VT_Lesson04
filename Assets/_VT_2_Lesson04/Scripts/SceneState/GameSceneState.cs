using UnityEngine;
using UnityEngine.InputSystem;

public class GameSceneState : IState
{
    // === メンバー変数 === //
    private SceneManager _sceneManager;

    private GameObject _gameCube;
    public void Enter()
    {
        Debug.Log($"{GetType().Name}が始まります");

        // SceneManager を取得
        _sceneManager = GameObject.FindAnyObjectByType<SceneManager>();

        // オブジェクトを生成する
        _gameCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    public void Execute()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            // ResultSceneState へ遷移
            _sceneManager.ChangeScene(new ResultSceneState());
        }
    }

    public void Exit()
    {
        Debug.Log($"{GetType().Name}が終了します");

        GameObject.Destroy(_gameCube);
    }
}
