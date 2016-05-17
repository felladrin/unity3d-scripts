using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadNextSceneAfterPlayingAnimation : MonoBehaviour
{
	public int AnimationClipIndex = 0;

	IEnumerator Start ()
	{
		Animator animator = GetComponent<Animator> ();
		yield return new WaitForSeconds (animator.runtimeAnimatorController.animationClips [AnimationClipIndex].length);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}