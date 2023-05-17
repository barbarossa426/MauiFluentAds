using Android.Content;
using Android.Gms.Ads;
using Android.Views;

namespace MauiFluentAds.Components.Platforms.Android.Renderers;

public class BannerRenderer : View
{
    public AdView AdView;

    public BannerRenderer(Context? context) : base(context)
    {
        InitView();
    }

    private void InitView()
    {
        AdView = new(Context);
        AdView.AdSize = AdSize.SmartBanner;
        //AdView.LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent);
    }

    public BannerRenderer SetAdUnitId(string id)
    {
        AdView.AdUnitId = id;
        return this;
    }

    public BannerRenderer Build()
    {
        AdView.LoadAd(new AdRequest.Builder().Build());
        return this;
    }
}