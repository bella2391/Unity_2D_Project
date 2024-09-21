using UnityEngine;

public class SpriteColorChanger : MonoBehaviour {
    public Color fillColor = Color.white;

    private SpriteRenderer spriteRenderer;
    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.color = fillColor;
    }
}
