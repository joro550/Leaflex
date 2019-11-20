using System;
using Xunit;
using Amazon.S3;
using Amazon.S3.Model;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Leaflex.Web.Tests
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public async Task Test1()
        {
            using var s3Client = new AmazonS3Client(new AmazonS3Config
            {
                ServiceURL = "http://localhost:4572",
                ForcePathStyle = true,
            });

//            var bucket = await s3Client.PutBucketAsync(new PutBucketRequest
//            {
//                BucketName = "test",
//                UseClientRegion = true
//            });

            ListBucketsResponse response = null;
            try
            {
                response = await s3Client.ListBucketsAsync();
                foreach (var bucket in response.Buckets)
                {
                    _testOutputHelper.WriteLine(bucket.BucketName);
                }

            }
            catch (Exception e)
            {

            }

            Assert.Single(response.Buckets);
        }
    }
}
