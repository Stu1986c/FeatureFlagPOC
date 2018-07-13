using FeatureFlagPOC.Core.Repositories;


namespace FeatureFlagPOC.Core.Services
{
    public class FeatureService : IFeatureService
    {
        private readonly IFeatureRepository _featureRepository;

        public FeatureService(IFeatureRepository featureRepository)
        {
            _featureRepository = featureRepository;
        }

        public bool IsFeatureEnabled(string flagName)
        {
            return _featureRepository.IsFeatureEnabled(flagName);
        }

        public bool IsUserFlaggedOn(int userId)
        {
            return _featureRepository.IsUserFlaggedOn(userId);
        }
    }
}
