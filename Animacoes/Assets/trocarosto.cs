using UnityEngine;
using System.Collections;

public class trocarosto : MonoBehaviour {

	public GameObject player;
	private SpriteRenderer spri;
	public Sprite[] texturas;
	private int i=0;

	// Use this for initialization
	void Start () {
		spri=player.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.D)){
			print(i%texturas.Length);
			i++;
			spri.sprite = texturas[i%texturas.Length];

		}
	
	}
}
