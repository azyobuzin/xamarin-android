#if ANDROID_11

using Java.Lang;
using Android.Runtime;
using Object = Java.Lang.Object;

namespace Android.Animation
{
	public partial class IntEvaluator
	{
		public virtual Object? Evaluate (float fraction, Object? startValue, Object? endValue)
		{
			return Evaluate (fraction, startValue.JavaCast<Integer> (), endValue.JavaCast<Integer> ());
		}
	}
}

#endif
