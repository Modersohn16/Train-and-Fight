using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DamagePopUpText : MonoBehaviour {

    public Animator anim;
    private Text damageText;

	
	void OnEnable () {
        AnimatorClipInfo[] clipInfo = anim.GetCurrentAnimatorClipInfo(0);
        Destroy(gameObject, clipInfo[0].clip.length);
        damageText = anim.GetComponent<Text>();
	}
	
    public void SetText(string text)
    {
        damageText.text = text;
    }
}
