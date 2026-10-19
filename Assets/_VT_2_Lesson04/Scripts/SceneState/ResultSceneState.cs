using UnityEngine.InputSystem;

public class ResultSceneState : BaseSceneState
{
    // === HUDİ’è === //
    public override string HUDAddress { get; protected set; } = "Assets/_VT_2_Lesson04/Prefab/TitleHUDCanvas_FullHD.prefab";
    public override void Enter()
    {
        base.Enter();
    }

    public override void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // TitleSceneState ‚Ö‘JˆÚ
            _sceneManager.ChangeScene(new TitleSceneState());
        }

        base.Execute();
    }
}
