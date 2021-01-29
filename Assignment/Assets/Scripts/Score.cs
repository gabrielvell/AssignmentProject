using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	[SerializeField] private int  startingValue = 0;
	[SerializeField] private int  targetValue = 0;
	[SerializeField] private float incrementTime = 0;
	[SerializeField] private GameObject enableWhenDone;

	private Text label
	{
		get
		{
			if ( mLabel == null )
				mLabel = GetComponent<Text>();
			return mLabel;
		}
	}
	private Text mLabel;

	private void OnEnable ()
	{
		StartCoroutine(IncrementCoroutine());
	}

	private IEnumerator IncrementCoroutine ()
	{
		float time = 0;
		label.text = startingValue.ToString();

		while ( time < incrementTime )
		{
			yield return null;

			time += Time.deltaTime;
			float factor = time / incrementTime;

			label.text = ((int) Mathf.Lerp(startingValue, targetValue, factor)).ToString();
		}

		if ( enableWhenDone != null )
			enableWhenDone.SetActive(true);

		yield break;
	}
}