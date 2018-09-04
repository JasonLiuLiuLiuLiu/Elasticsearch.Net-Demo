using Nest;

namespace Elasticsearch.Service
{
    public interface IEsClientProvider
    {
        ElasticClient GetClient();
    }
}