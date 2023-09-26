
namespace BuilderPattern
{
    internal interface IBuilder
    {
        void AddFeatureA();
        void AddFeatureB();
        void AddFeatureC();
        void Reset();
    }
}
