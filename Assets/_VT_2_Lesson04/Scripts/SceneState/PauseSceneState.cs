using UnityEngine;
using UnityEngine.InputSystem;

public class PauseSceneState : BaseSceneState
{
    // === HUDê›íË === //
    public override string HUDAddress { get; protected set; } = "Assets/_VT_2_Lesson04/Prefab/TitleHUDCanvas_FullHD.prefab";
    public override void Execute()
    {
        if(Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            _sceneManager.ChangeScene(new GameSceneState());
        }

        base.Execute();
    }
}
