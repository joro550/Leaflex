using Xunit;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using System.Threading.Tasks;
using Amazon.Runtime;

namespace Leaflex.Web.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var config = new AmazonS3Config
            {
                UseHttp = true, 
                ForcePathStyle = true,
                ServiceURL = "http://localhost:4572",
                RegionEndpoint = RegionEndpoint.USEast1
            };

            var credentials = new AnonymousAWSCredentials();
            using var client = new AmazonS3Client(credentials, config);

            await client.PutBucketAsync(new PutBucketRequest {BucketName = "myBucket"});

            var buckets = client.ListBucketsAsync();


        }
    }
}
