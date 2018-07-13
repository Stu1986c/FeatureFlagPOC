namespace FeatureFlagPOC.Core.Services
{
    public interface IFeatureService
    {
        bool IsFeatureEnabled(string flagName);

        bool IsUserFlaggedOn(int userId);
    }
}