﻿// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Xamarin.Cognitive.Face.Sample.iOS
{
	[Register ("IdentifyFaceViewController")]
	partial class IdentifyFaceViewController
	{
		[Outlet]
		UIKit.UIButton GoButton { get; set; }

		[Action ("ChooseImageAction:")]
		partial void ChooseImageAction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (GoButton != null) {
				GoButton.Dispose ();
				GoButton = null;
			}
		}
	}
}
