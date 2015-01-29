using System;
using ObjCRuntime;

[assembly: LinkWith ("WYPopoverController.a", LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Arm64, SmartLink = true, ForceLoad = true)]
