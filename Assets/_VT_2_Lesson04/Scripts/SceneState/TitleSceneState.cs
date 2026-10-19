using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class TitleSceneState : BaseSceneState
{
    // === HUDİ’è === //
    public override string HUDAddress { get; protected set; } = "Assets/_VT_2_Lesson04/Prefab/TitleHUDCanvas_FullHD.prefab";

    public override void Enter()
    {
        base.Enter();

        // === ƒvƒŒƒnƒu‚Ì“Ç‚İ === //
        GameObject hudPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(HUDAddress);
        GameObject.Instantiate(hudPrefab);
    }

    public override void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // GameSceneState ‚Ö‘JˆÚ
            _sceneManager.ChangeScene(new GameSceneState());
        }

        base.Execute();
    }
}
