using UnityEngine;
using System.Collections;

public class touch_cube : MonoBehaviour {
	public bool blocked = false;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void activate(bool state) {
		if(!blocked)
			anim.CrossFade((state)?"to_active":"to_idle", 1);
	}

	void OnTriggerEnter(Collider other) {
        activate(true);
    }
    void OnTriggerExit(Collider other) {
        activate(false);
    }
}
