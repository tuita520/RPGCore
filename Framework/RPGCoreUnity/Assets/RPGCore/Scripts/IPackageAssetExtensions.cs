﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGCore.Behaviour.Packages;

public static class IPackageAssetExtensions
{
	public static Texture2D LoadImage(this PackageAsset asset)
	{
		var loadedImage = new Texture2D(2, 2);
		
		/*byte[] imageData = asset;
		loadedImage.LoadImage(, true);*/

		return loadedImage;
	}
}