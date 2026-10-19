using UnityEngine;
using UnityEngine.InputSystem;

public class GameSceneState : BaseSceneState
{
    // === HUD設定 === //
    public override string HUDAddress { get; protected set; } = "Assets/_VT_2_Lesson04/Prefab/GameHUDCanvas_FullHD.prefab";
    private GameObject _gameCube;
    public override void Enter()
    {
        base.Enter();

        // オブジェクトを生成する
        _gameCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    public override void Execute()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            // ResultSceneState へ遷移
            _sceneManager.ChangeScene(new ResultSceneState());

            // キャラクターを消す
            GameObject.Destroy(_gameCube);
        }

        if(Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            // PauseSceneState へ遷移
            _sceneManager.ChangeScene(new PauseSceneState());
        }

        base.Execute();
    }

    public  override void Exit()
    {
        base.Exit();

        GameObject.Destroy(_gameCube);
    }
}
