using UnityEditor;
using UnityEngine;

/// <summary>
/// インターフェース(interface)
/// 　このインターフェースを継承するクラスは、
///   記述されているメソッドやプロパティをすべて実装しなければならない
/// </summary>
public interface IState
{
    void Enter();           // 状態の初期処理
    void Execute();         // 状態の繰り返し処理
    void Exit();            // 状態の終了処理
}

/// <summary>
/// 具象クラスに継承させる抽象クラス
/// </summary>
public abstract class BaseSceneState : IState
{
    // === 親クラスのメンバー === //
    protected SceneManager _sceneManager;

    protected GameObject _hudCanvas;

    // === Canvas 設定 === //
    // ヘッドアップディスプレイ(UI) のプレハブアドレスを入力
    public abstract string HUDAddress { get; protected set; }


    public virtual void Enter()
    {
        Debug.Log($"{GetType().Name}が始まります");

        _sceneManager = GameObject.FindAnyObjectByType<SceneManager>();

        // === プレハブの読込み === //
        GameObject hudPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(HUDAddress);
        _hudCanvas = GameObject.Instantiate(hudPrefab);
    }

    public virtual void Execute()
    {

    }

    public virtual void Exit()
    {
        Debug.Log($"{GetType().Name}が終了します");

        GameObject.Destroy(_hudCanvas);
    }
}
