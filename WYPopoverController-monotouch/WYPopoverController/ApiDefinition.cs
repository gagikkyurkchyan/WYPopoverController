using System.Drawing;
using System;

using Foundation;
using UIKit;
using ObjCRuntime;
using CoreGraphics;

namespace WYPopover {

	[BaseType (typeof (NSObject), 
		Delegates=new string [] { "WeakDelegate" }, 
		Events=new Type [] {typeof(WYPopoverControllerDelegate)})]
	public interface WYPopoverController {

		[Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakDelegate")]
		WYPopoverControllerDelegate Delegate { get; set; }

		[Export ("passthroughViews", ArgumentSemantic.Copy)]
		UIView [] PassthroughViews { get; set; }

		[Export ("wantsDefaultContentAppearance")]
		bool WantsDefaultContentAppearance { get; set; }

		[Export ("popoverLayoutMargins", ArgumentSemantic.Assign)]
		UIEdgeInsets PopoverLayoutMargins { get; set; }

		[Export ("popoverVisible")]
		bool PopoverVisible { [Bind ("isPopoverVisible")] get; }

		[Export ("contentViewController", ArgumentSemantic.Retain)]
		UIViewController ContentViewController { get; }

		[Export ("popoverContentSize", ArgumentSemantic.Assign)]
		CGSize PopoverContentSize { get; set; }

		[Export ("animationDuration")]
		float AnimationDuration { get; set; }

		[Export ("theme", ArgumentSemantic.Retain)]
		WYPopoverTheme Theme { get; set; }

		[Static, Export ("defaultTheme")]
		WYPopoverTheme DefaultTheme { get; set; }

		[Export ("initWithContentViewController:")]
		IntPtr Constructor (UIViewController viewController);

		[Export ("beginThemeUpdates")]
		void BeginThemeUpdates ();

		[Export ("endThemeUpdates")]
		void EndThemeUpdates ();

		[Export ("presentPopoverFromRect:inView:permittedArrowDirections:animated:options:")]
		void PresentPopoverFromRect (CGRect rect, UIView view, WYPopoverArrowDirection arrowDirections, bool animated, WYPopoverAnimationOptions options);

//		[Export ("presentPopoverFromRect:inView:permittedArrowDirections:animated:")]
//		void PresentPopoverFromRect (CGRect rect, UIView view, WYPopoverArrowDirection arrowDirections, bool animated);
//
//		[Export ("presentPopoverFromRect:inView:permittedArrowDirections:animated:completion:")]
//		void PresentPopoverFromRect (CGRect rect, UIView view, WYPopoverArrowDirection arrowDirections, bool animated, Action completion);
//
//		[Export ("presentPopoverFromRect:inView:permittedArrowDirections:animated:options:completion:")]
//		void PresentPopoverFromRect (CGRect rect, UIView view, WYPopoverArrowDirection arrowDirections, bool animated, WYPopoverAnimationOptions options, Action completion);
//
//		[Export ("presentPopoverFromBarButtonItem:permittedArrowDirections:animated:")]
//		void PresentPopoverFromBarButtonItem (UIBarButtonItem item, WYPopoverArrowDirection arrowDirections, bool animated);
//
//		[Export ("presentPopoverFromBarButtonItem:permittedArrowDirections:animated:completion:")]
//		void PresentPopoverFromBarButtonItem (UIBarButtonItem item, WYPopoverArrowDirection arrowDirections, bool animated, Action completion);
//
//		[Export ("presentPopoverFromBarButtonItem:permittedArrowDirections:animated:options:")]
//		void PresentPopoverFromBarButtonItem (UIBarButtonItem item, WYPopoverArrowDirection arrowDirections, bool animated, WYPopoverAnimationOptions options);
//
//		[Export ("presentPopoverFromBarButtonItem:permittedArrowDirections:animated:options:completion:")]
//		void PresentPopoverFromBarButtonItem (UIBarButtonItem item, WYPopoverArrowDirection arrowDirections, bool animated, WYPopoverAnimationOptions options, Action completion);
//
//		[Export ("presentPopoverAsDialogAnimated:")]
//		void PresentPopoverAsDialogAnimated (bool animated);
//
//		[Export ("presentPopoverAsDialogAnimated:completion:")]
//		void PresentPopoverAsDialogAnimated (bool animated, Action completion);
//
//		[Export ("presentPopoverAsDialogAnimated:options:")]
//		void PresentPopoverAsDialogAnimated (bool animated, WYPopoverAnimationOptions options);
//
//		[Export ("presentPopoverAsDialogAnimated:options:completion:")]
//		void PresentPopoverAsDialogAnimated (bool animated, WYPopoverAnimationOptions options, Action completion);
//
//		[Export ("dismissPopoverAnimated:")]
//		void DismissPopoverAnimated (bool animated);
//
//		[Export ("dismissPopoverAnimated:completion:")]
//		void DismissPopoverAnimated (bool animated, Action completion);
//
//		[Export ("dismissPopoverAnimated:options:")]
//		void DismissPopoverAnimated (bool animated, WYPopoverAnimationOptions aOptions);
//
//		[Export ("dismissPopoverAnimated:options:completion:")]
//		void DismissPopoverAnimated (bool animated, WYPopoverAnimationOptions aOptions, Action completion);
	}

	public interface UIAppearance {}

	[BaseType (typeof (UIView))]
	public interface WYPopoverBackgroundView : UIAppearance {

		[Export ("tintColor", ArgumentSemantic.Retain)]
		[Appearance] 
		UIColor TintColor { get; set; }

		[Export ("backgroundColor", ArgumentSemantic.Retain)]
		[Appearance] 
		UIColor BackgroundColor { get; set; }

		[Export ("fillTopColor", ArgumentSemantic.Retain)]
		[Appearance] 
		UIColor FillTopColor { get; set; }

		[Export ("fillBottomColor", ArgumentSemantic.Retain)]
		[Appearance] 
		UIColor FillBottomColor { get; set; }

		[Export ("glossShadowColor", ArgumentSemantic.Retain)]
		[Appearance] 
		UIColor GlossShadowColor { get; set; }

		[Export ("glossShadowOffset", ArgumentSemantic.Assign)]
		[Appearance] 
		CGSize GlossShadowOffset { get; set; }

		[Export ("glossShadowBlurRadius")]
		[Appearance] 
		nuint GlossShadowBlurRadius { get; set; }

		[Export ("borderWidth")]
		[Appearance] 
		nuint BorderWidth { get; set; }

		[Export ("arrowBase")]
		[Appearance] 
		nuint ArrowBase { get; set; }

		[Export ("arrowHeight")]
		[Appearance] 
		nuint ArrowHeight { get; set; }

		[Export ("outerShadowColor", ArgumentSemantic.Retain)]
		[Appearance] 
		UIColor OuterShadowColor { get; set; }

		[Export ("outerStrokeColor", ArgumentSemantic.Retain)]
		[Appearance] 
		UIColor OuterStrokeColor { get; set; }

		[Export ("outerShadowBlurRadius")]
		[Appearance] 
		nuint OuterShadowBlurRadius { get; set; }

		[Export ("outerShadowOffset", ArgumentSemantic.Assign)]
		[Appearance] 
		CGSize OuterShadowOffset { get; set; }

		[Export ("outerCornerRadius")]
		[Appearance] 
		nuint OuterCornerRadius { get; set; }

		[Export ("minOuterCornerRadius")]
		[Appearance] 
		nuint MinOuterCornerRadius { get; set; }

		[Export ("innerShadowColor", ArgumentSemantic.Retain)]
		[Appearance] 
		UIColor InnerShadowColor { get; set; }

		[Export ("innerStrokeColor", ArgumentSemantic.Retain)]
		[Appearance] 
		UIColor InnerStrokeColor { get; set; }

		[Export ("innerShadowBlurRadius")]
		[Appearance] 
		nuint InnerShadowBlurRadius { get; set; }

		[Export ("innerShadowOffset", ArgumentSemantic.Assign)]
		[Appearance] 
		CGSize InnerShadowOffset { get; set; }

		[Export ("innerCornerRadius")]
		[Appearance] 
		nuint InnerCornerRadius { get; set; }

		[Export ("viewContentInsets", ArgumentSemantic.Assign)]
		[Appearance] 
		UIEdgeInsets ViewContentInsets { get; set; }

		[Export ("overlayColor", ArgumentSemantic.Retain)]
		[Appearance] 
		UIColor OverlayColor { get; set; }
	}


	[Model, Protocol, BaseType (typeof (NSObject))]
	public interface WYPopoverControllerDelegate {

		[Export ("popoverControllerShouldDismissPopover:"), DelegateName("WYPopoverDelegate"), DefaultValue(false)]
		bool  ShouldDismissPopover(WYPopoverController popoverController);

		[Export ("popoverControllerDidPresentPopover:"), DelegateName("WYPopoverDelegate")]
		void  DidPresentPopover(WYPopoverController popoverController);

		[Export ("popoverControllerDidDismissPopover:"), DelegateName("WYPopoverDelegate")]
		void  DidDismissPopover(WYPopoverController popoverController);

//		[Export ("popoverController:willRepositionPopoverToRect:inView:")]
//		void WillRepositionPopover (WYPopoverController popoverController, [unmapped: pointer: Pointer] rect, out UIView view);
//
//		[Export ("popoverControllerShouldIgnoreKeyboardBounds:")]
//		bool  (WYPopoverController popoverController);
//
//		[Export ("popoverController:willTranslatePopoverWithYOffset:")]
//		void WillTranslatePopoverWithYOffset (WYPopoverController popoverController, [unmapped: pointer: Pointer] value);
	}

	[BaseType (typeof (NSObject))]
	public interface WYPopoverTheme {

		[Export ("tintColor", ArgumentSemantic.Retain)]
		UIColor TintColor { get; set; }

		[Export ("fillTopColor", ArgumentSemantic.Retain)]
		UIColor FillTopColor { get; set; }

		[Export ("fillBottomColor", ArgumentSemantic.Retain)]
		UIColor FillBottomColor { get; set; }

		[Export ("glossShadowColor", ArgumentSemantic.Retain)]
		UIColor GlossShadowColor { get; set; }

		[Export ("glossShadowOffset", ArgumentSemantic.Assign)]
		CGSize GlossShadowOffset { get; set; }

		[Export ("glossShadowBlurRadius")]
		nuint GlossShadowBlurRadius { get; set; }

		[Export ("borderWidth")]
		nuint BorderWidth { get; set; }

		[Export ("arrowBase")]
		nuint ArrowBase { get; set; }

		[Export ("arrowHeight")]
		nuint ArrowHeight { get; set; }

		[Export ("outerShadowColor", ArgumentSemantic.Retain)]
		UIColor OuterShadowColor { get; set; }

		[Export ("outerStrokeColor", ArgumentSemantic.Retain)]
		UIColor OuterStrokeColor { get; set; }

		[Export ("outerShadowBlurRadius")]
		nuint OuterShadowBlurRadius { get; set; }

		[Export ("outerShadowOffset", ArgumentSemantic.Assign)]
		CGSize OuterShadowOffset { get; set; }

		[Export ("outerCornerRadius")]
		nuint OuterCornerRadius { get; set; }

		[Export ("minOuterCornerRadius")]
		nuint MinOuterCornerRadius { get; set; }

		[Export ("innerShadowColor", ArgumentSemantic.Retain)]
		UIColor InnerShadowColor { get; set; }

		[Export ("innerStrokeColor", ArgumentSemantic.Retain)]
		UIColor InnerStrokeColor { get; set; }

		[Export ("innerShadowBlurRadius")]
		nuint InnerShadowBlurRadius { get; set; }

		[Export ("innerShadowOffset", ArgumentSemantic.Assign)]
		CGSize InnerShadowOffset { get; set; }

		[Export ("innerCornerRadius")]
		nuint InnerCornerRadius { get; set; }

		[Export ("viewContentInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets ViewContentInsets { get; set; }

		[Export ("overlayColor", ArgumentSemantic.Retain)]
		UIColor OverlayColor { get; set; }

		[Static, Export ("theme")]
		WYPopoverTheme Theme { get; }

		[Static, Export ("themeForIOS6")]
		WYPopoverTheme ThemeForIOS6 { get; }

		[Static, Export ("themeForIOS7")]
		WYPopoverTheme ThemeForIOS7 { get; }
	}

	[BaseType (typeof (UIStoryboardSegue))]
	public interface WYStoryboardPopoverSegue {

		[Export ("popoverControllerWithSender:permittedArrowDirections:animated:")]
		WYPopoverController PopoverControllerWithSender (NSObject sender, WYPopoverArrowDirection arrowDirections, bool animated);

		[Export ("popoverControllerWithSender:permittedArrowDirections:animated:options:")]
		WYPopoverController PopoverControllerWithSender (NSObject sender, WYPopoverArrowDirection arrowDirections, bool animated, WYPopoverAnimationOptions options);
	}
}
