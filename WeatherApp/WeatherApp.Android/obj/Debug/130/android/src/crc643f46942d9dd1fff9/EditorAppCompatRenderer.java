package crc643f46942d9dd1fff9;


public class EditorAppCompatRenderer
	extends crc643f46942d9dd1fff9.EditorRendererBase_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAttachedToWindow:()V:GetOnAttachedToWindowHandler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.EditorAppCompatRenderer, Xamarin.Forms.Platform.Android", EditorAppCompatRenderer.class, __md_methods);
	}


	public EditorAppCompatRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == EditorAppCompatRenderer.class) {
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.EditorAppCompatRenderer, Xamarin.Forms.Platform.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public EditorAppCompatRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == EditorAppCompatRenderer.class) {
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.EditorAppCompatRenderer, Xamarin.Forms.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public EditorAppCompatRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == EditorAppCompatRenderer.class) {
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.EditorAppCompatRenderer, Xamarin.Forms.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public void onAttachedToWindow ()
	{
		n_onAttachedToWindow ();
	}

	private native void n_onAttachedToWindow ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
