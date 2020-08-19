using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // コリジョンと衝突した場合の処理
    void OnCollisionEnter(Collision collision)
    {
        // 変数 hit に衝突したオブジェクトを格納
        var hit = collision.gameObject;
        // 変数 healthに、変数 hit に格納されたオブジェクトのコンポーネント Health を格納
        var health = hit.GetComponent<Health>();
        // 変数 health が空でなければ
        if (health != null)
        {
            // ダメージ処理を実行（体力値-10）
            //（スクリプト health の関数 TakeDamage を実行）
            health.TakeDamage(10);
        }
        // オブジェクトを削除
        Destroy(gameObject);
    }
}
