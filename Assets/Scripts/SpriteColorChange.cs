using UnityEngine;

public class SpriteColorChanger : MonoBehaviour {
    public Color fillColor = Color.white; // 塗りつぶす色を設定します

    private SpriteRenderer spriteRenderer;
    // ハローだよねー
    void Start() {
        // SpriteRendererコンポーネントを取得します
        spriteRenderer = GetComponent<SpriteRenderer>();

        // スプライトの色を変更します
        spriteRenderer.color = fillColor;
    }
}
