using System;

namespace WYPopover
{
	public enum WYPopoverArrowDirection : uint {
		Up = 1U << 0,
		Down = 1U << 1,
		Left = 1U << 2,
		Right = 1U << 3,
		None = 1U << 4,
		Any = 1U << 0 | 1U << 1 | 1U << 2  | 1U << 3,
		Unknown = uint.MaxValue
	}

	public enum WYPopoverAnimationOptions : uint {
		Fade = 1U << 0,
		Scale = 1U << 1,
		FadeWithScale = 1U << 0 | 1U << 1
	}
			
}

