using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeController : MonoBehaviour
{
	float red, green, blue, alfa;

	public float fadeInSpeed;
	public float fadeOutSpeed;
	public bool fadeIn = false;
	public bool fadeOut = false;

	Image fadeImage;

	void Start()
	{
		fadeImage = GetComponent<Image>();
		red = fadeImage.color.r;
		green = fadeImage.color.g;
		blue = fadeImage.color.b;
		alfa = fadeImage.color.a;

		fadeIn = true;
	}

	void Update()
	{
		if (fadeIn)
		{
			StartFadeIn();
		}

		if (fadeOut)
		{
			StartFadeOut();
		}
	}

	// フェードインを行う処理
	public void StartFadeIn()
	{
		fadeIn = true;
		alfa -= fadeInSpeed;
		SetAlpha();
		if (alfa <= 0)
		{
			fadeIn = false;
			fadeImage.enabled = false;
		}
	}

	// フェードアウトを行う処理
	public void StartFadeOut()
	{
		fadeOut = true;
		fadeImage.enabled = true;
		alfa += fadeOutSpeed;
		SetAlpha();
		if (alfa >= 1)
		{
			fadeOut = false;
		}
	}

	void SetAlpha()
	{
		fadeImage.color = new Color(red, green, blue, alfa);
	}
}
