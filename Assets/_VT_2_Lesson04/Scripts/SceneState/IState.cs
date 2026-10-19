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
