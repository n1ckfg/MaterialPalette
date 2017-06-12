using UnityEngine;

// Draws 3 meshes with the same material but with different colors.
public class MaterialPalette : MonoBehaviour
{
	public Color[] color;
	public Renderer[] target;

	private MaterialPropertyBlock block;

	void Start() {
		block = new MaterialPropertyBlock();

		for (int i=0; i<target.Length; i++) {
			target[i].GetPropertyBlock(block);
			block.SetColor("_Color", color[i]);
			target[i].SetPropertyBlock(block);
		}
	}

}