#if ANDROID_21

using Java.Lang;
using Android.Runtime;
using Object = Java.Lang.Object;

namespace Android.Animation
{
	public partial class FloatArrayEvaluator
	{
		Object ITypeEvaluator.Evaluate (float fraction, Object? startValue, Object? endValue)
		{
			return new JavaArray<float> (JNIEnv.NewArray<float> (Evaluate (fraction, (float []?) (JavaArray<float>?) startValue, (float []?) (JavaArray<float>?) endValue)), JniHandleOwnership.TransferLocalRef);
		}
	}
}

#endif
