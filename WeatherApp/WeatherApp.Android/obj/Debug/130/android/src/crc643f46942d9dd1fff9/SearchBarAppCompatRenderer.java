package crc643f46942d9dd1fff9;


public class SearchBarAppCompatRenderer
	extends crc643f46942d9dd1fff9.ViewRenderer_2
	implements
		mono.android.IGCUserPeer,
		androidx.appcompat.widget.SearchView.OnQueryTextListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onQueryTextChange:(Ljava/lang/String;)Z:GetOnQueryTextChange_Ljava_lang_String_Handler:AndroidX.AppCompat.Widget.SearchView/IOnQueryTextListenerInvoker, Xamarin.AndroidX.AppCompat\n" +
			"n_onQueryTextSubmit:(Ljava/lang/String;)Z:GetOnQueryTextSubmit_Ljava_lang_String_Handler:AndroidX.AppCompat.Widget.SearchView/IOnQueryTextListenerInvoker, Xamarin.AndroidX.AppCompat\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.SearchBarAppCompatRenderer, Xamarin.Forms.Platform.Android", SearchBarAppCompatRenderer.class, __md_methods);
	}


	public SearchBarAppCompatRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SearchBarAppCompatRenderer.class) {
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.SearchBarAppCompatRenderer, Xamarin.Forms.Platform.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public SearchBarAppCompatRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SearchBarAppCompatRenderer.class) {
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.SearchBarAppCompatRenderer, Xamarin.Forms.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public SearchBarAppCompatRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SearchBarAppCompatRenderer.class) {
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.SearchBarAppCompatRenderer, Xamarin.Forms.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public boolean onQueryTextChange (java.lang.String p0)
	{
		return n_onQueryTextChange (p0);
	}

	private native boolean n_onQueryTextChange (java.lang.String p0);


	public boolean onQueryTextSubmit (java.lang.String p0)
	{
		return n_onQueryTextSubmit (p0);
	}

	private native boolean n_onQueryTextSubmit (java.lang.String p0);

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
