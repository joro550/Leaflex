namespace Leaflex.Web.Config
{
    public class LocalStackConfig
    {
        public string ApiGateway { get; set; } = "4567";
        public string Kinesis { get; set; } = "4568";
        public string DynamoDb { get; set; } = "4569";
        public string DynamoStreams { get; set; } = "4570";
        public string ElasticSearch { get; set; } = "4571";
        public string S3 { get; set; } = "4572";
        public string FireHose { get; set; } = "4573";
        public string Lamda { get; set; } = "4574";
        public string Sns { get; set; } = "4575";
        public string Sqs { get; set; } = "4576";
        public string RedShift { get; set; } = "4577";
        public string ElasticSearchServices { get; set; } = "4578";
        public string Ses { get; set; } = "4579";
        public string Route53 { get; set; } = "4580";
        public string CloudFormation { get; set; } = "4581";
        public string CloudWatch { get; set; } = "4582";
        public string Ssm { get; set; } = "4583";
        public string SecretsManager { get; set; } = "4584";
        public string StepsFunctions { get; set; } = "4585";
        public string CloudWatchLogs { get; set; } = "4586";
        public string EventBridge { get; set; } = "4587";
        public string Sts { get; set; } = "4592";
        public string Iam { get; set; } = "4593";
        public string Ecs { get; set; } = "4597";
    }
}